-- Author: skyAllen
-- Date: 2023-09-07 15:01:08
-- Email: 894982165@qq.com
-- Copyright: © 2023 skyAllen

---@class UIPanel
local UIPanel = class("UIPanel");

function UIPanel:awake()
    local rect = self.go:GetComponent(typeof(RectTransform));
    self.rect = rect;
end

function UIPanel:show()
    --self.go:SetActive(true)
    self.is_show = true;

    local rect = self.rect;
end

function UIPanel:hide()
    --self.go:SetActive(false)
    self.is_show = false;

    local rect = self.rect;
end

return UIPanel;