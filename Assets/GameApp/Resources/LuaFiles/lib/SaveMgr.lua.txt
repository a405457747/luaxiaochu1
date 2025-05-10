-- Author: skyAllen
-- Date: 2023-09-07 15:01:08
-- Email: 894982165@qq.com
-- Copyright: © 2023 skyAllen

---@class SaveManager
local SaveMgr = class("SaveManager");

function SaveMgr.Init()
    SaveMgr.Load();
end

function SaveMgr.Save()
    local data_str = js.stringify(saveData);
    UnityEngine.PlayerPrefs.SetString("player_data", data_str);
end

function SaveMgr._GetString()
    return UnityEngine.PlayerPrefs.GetString("player_data");
end

function SaveMgr.Load()
    local data_str = UnityEngine.PlayerPrefs.GetString("player_data", "");
    --print("data_str is", data_str)
    if data_str == "" then
        saveData = {
            userSet = {
                _musicEnable = true,
                _soundEnable = true,
            },
            testObj = 1;
        }
    else
        saveData = js.parse(data_str);
    end
end

function SaveMgr.test()
    if UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.S) then
        saveData.testObj = saveData.testObj + 1;
        SaveMgr.Save();
        print("save success ", saveData.testObj);
        print(SaveMgr._GetString());
    end
end

return SaveMgr
