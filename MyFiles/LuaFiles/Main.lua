local Main = {};

-- idea2019.3.4付费版和市场插件emmylua1.3.3.150和emmyluaunity1.09是最好用，因为之前验证过1.4安装不了，并且还有bug，依据来自maplestory2

local function init()
    print("Main init lua version ！", _VERSION);

    require("lib.functions");

    -- luajit不支持^、//两个运算符，另外loadstring在5.3变成了load，unpack在5.3变成了table.unpack
    unpack = unpack or table.unpack;

    ue = require("lib.ue_api");

    cs_coroutine = require("lib.cs_coroutine");

    local dbg = 0;
    if (dbg == 1) then
        package.cpath = package.cpath .. ';C:/Users/justi/.IntelliJIdea2019.3/config/plugins/intellij-emmylua/classes/debugger/emmy/windows/x64/?.dll'
        dbg = require('emmy_core')
        dbg.tcpConnect('localhost', 9966)
    end
    bp_debug = function(t)
        if (type(dbg) == "number") then
            return ;
        end
        if (type(t) == "nil") then
            dbg.breakHere();
        else
            if (t) then
                dbg.breakHere();
            end
        end
    end

    cs = require("lib.cs_api");
    qa = require("lib.unit_test");
    evt = require("lib.eventMgr");
    randomKit = require("lib.randomKit");
    js = require("lib.js_api");
    _G.Main = Main;
    saveData = false;
    enumKit = require("lib.enumKit");
    utilFunc = require("lib.utilFunc")
    TEST_MODE = false;

    -- todo warn game1文件夹下所以的lua对象中，持有的全局变量只有G1和GlobalData中的对象，之前持有的UIPanel即使在下一秒也清理不掉的，xlua内存释放这块不熟悉。
    G1 = false;-- 表示gameMgr
    require("game1.common.GlobalData");

    setmetatable(_G, {
        __index = function(t, _)
            error("read nil value " .. _, 2)
        end,
        __newindex = function(t, _)
            error("write nil value " .. _, 2)
        end
    });
    local gKeyCount = 0;
    for i, v in pairs(_G) do
        gKeyCount = gKeyCount + 1;
    end
    local targetGKeyCount =95;
    if (gKeyCount == targetGKeyCount) then
        print("global Count is right!", "gCount is ", gKeyCount);
    else
        print("lua global count is",gKeyCount);
    end
end

function Main.bigOver()
    -- 第二次玩G1就要清理了。
    if (G1) then
        -- local a, b = G1:getWinUI();

        for i, v in pairs(package.loaded) do
            if (cs.startsWith(i, "game1")) then
                --print("i", i);
                package.loaded[i] = nil;
            end
        end

        -- print("Main.bigOver second", G1, a, b);--a,b只所以存在，是因为内存要在下一帧或下一秒才能释放！

        G1 = false;
    end
    -- UIPanel=require("game1.common.UIPanel");--无论第一次还是第二次都重新require，哪怕第二次也是清理之后的require
    print("Main.bigOver first call");
end

function Main.bigOver2()
    evt.clearAllData();
    ue.loadScene("main");
end

function Main.test()
    if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.A)) then
    end
end

function Main.update()
    if(TEST_MODE)then
        Main.test();
    end
end

function Main.RootGo()
    return UnityEngine.GameObject.Find("GameRoot");
end

function Main.testDoTween(trans)
    trans:DOScale(3, 3):OnComplete(function()
        trans:DOScale(1, 3):OnComplete(function ()
            print("doScale over")
            cs_coroutine.start(function()
                print('cs_coroutine test wait 3')
                coroutine.yield(CS.UnityEngine.WaitForSeconds(3))
                print('cs_coroutine test wait over')
            end)
        end);
    end)
end

--[[
function Main.OnBeginDrag(eventData, go)
    print("OnBeginDrag", go);
end;

function Main.OnDrag(eventData, go)
    print("OnDrag", go);
end;

function Main.OnEndDrag(eventData, go)
    print("OnEndDrag", go);
end;

function Main.OnMouseDown(go)
    print("OnMouseDown", go);
end;

function Main.OnMouseDrag(go)
    print("OnMouseDrag", go);
end;

function Main.OnMouseUp(go)
    print("OnMouseUp", go);
end;
--]]


init();
return Main;
