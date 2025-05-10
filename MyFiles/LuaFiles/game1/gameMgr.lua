local GamePanel = require("game1.ui.GamePanel");
local ver = require("game1.config.version");

---@class gameMgr
local gameMgr = class("gameMgr");


---@type GamePanel
local gamePanel;

local pressPos =nil;
local changeNum =1;
local width =5;
local height =10;
local mapData ={}
function gameMgr:ctor()
end

function gameMgr:awake()
    if (not G1) then
        G1 = self;
    end
    print("gameMgr awake！ others is ", G1, self, gameMgr,ver.ver);

    self.gameState = GAME_State.null;
end

function gameMgr:start()
    gamePanel = GamePanel.inst;--G1是gameMgr的单例，GamePanel.inst是ins面板点了之后的单例。

    print("gameMgr start！ inst is ", gamePanel);

    self:initMap();

    self:drawMap();
end

function gameMgr:initMap()
    for i=1,height do
        local t ={}
        for i=1,width do
            t[i]=0;
        end
        mapData[i]=t;
    end
end

function gameMgr:drawMap()

    self.tableMap= gamePanel:drawBlocks(mapData);

    self:realDrawMap();

    self:startTimer();
end

function gameMgr:startTimer()
    cs_coroutine.start(function()

        -- 定时器，停了再生成呢。
        for i=1,height do
            self:createRow();
            coroutine.yield(CS.UnityEngine.WaitForSeconds(2))
            if(changeNum<height)then
                changeNum=changeNum+1;
            end
        end

    end)
end

function gameMgr:realDrawMap()
    for j=1,height do
        for i=1,width do
            if(mapData[j][i]==0)then
                self.tableMap[j][i]:toggleImg(false);
            else
                self.tableMap[j][i]:toggleImg(true);
            end
        end
    end
end


function gameMgr:createRow()
    local t =self:getRandomTable();
    mapData[changeNum]=t;
    self:realDrawMap();


end

function gameMgr:getRandomTable()
    local bigT ={
        {0,1,1,1,1},
        {1,0,1,1,1},
        {1,1,1,0,1},
        {1,1,0,1,1},
        {1,1,1,1,0},
    };
    return randomKit.randomItem(bigT);
end

function gameMgr:startFill(num)
  local t =  mapData[changeNum];
    local isFillRight =false;
    if(t[num]==0)then
        isFillRight=true;
    else
        isFillRight=false;
        print("game over");
    end

    if(isFillRight)then
        t[num]=1;
        self:realDrawMap();

        cs_coroutine.start(function()
            coroutine.yield(CS.UnityEngine.WaitForSeconds(0.5));
            mapData[changeNum]={0,0,0,0,0};
            self:realDrawMap();
            coroutine.yield(CS.UnityEngine.WaitForSeconds(0.5));

            if(changeNum>0)then
                changeNum=changeNum-1;
            end

        end);
    end
end

function gameMgr:update()

    if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Q))then

        self:startFill(1);
    end
    if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.W))then
        self:startFill(2);
    end
    if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.E))then
        self:startFill(3);
    end
    if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.R))then
        self:startFill(4);
    end
    if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.T))then
        self:startFill(5);
    end
end

function gameMgr:switchState(game_state)
    if (self.gameState ~= game_state) then
        self.gameState = game_state;
        evt.sendEvent(enumKit.numberToEnum(self.gameState), self.gameState);
        print("now gameState is " .. enumKit.numberToEnum(GAME_State, self.gameState));
    end
end

return gameMgr;