
--不用hump之类的lua库，不做ucg了，python和typescript和cpp都给爷忘掉。
local cs = {}

function cs.add(t, item)
    t[#t + 1] = item;
end

function cs.clear(t)
    while #t > 0 do
        table.remove(t);
    end
end

function cs.insert(arr, idx, item)
    table.insert(arr, idx, item)
end

function cs.remove(arr, item)
    local idx = cs.indexOf(arr, item);
    if (idx ~= 0) then
        table.remove(arr, idx);
    end
end

function cs.indexOf(arr, item)
    for i, v in ipairs(arr) do
        if (v == item) then
            return i;
        end
    end
    return 0;
end

function cs.count(arr,fn)
    local res =0;
    for i, v in ipairs(arr) do
        if fn(v) then
            res=res+1;
        end
    end
    return res;
end

function cs.aggregate(array, callback, initialValue)
    local accumulator = initialValue
    local startIndex = 1

    if initialValue == nil then
        accumulator = array[1]
        startIndex = 2
    end

    for i = startIndex, #array do
        accumulator = callback(accumulator, array[i], i, array)
    end

    return accumulator
end

function cs.zip(arr,arr2,fn)
    local res ={};
    for i, v in ipairs(arr) do
        local newItem =fn(v,arr2[i]);
        res[#res+1]=newItem;
    end
    return res;
end

function cs.range( start, count)
    local res ={};

    for i = start,start+count-1 do
        res[#res+1]=i;
    end
    return res;
end

function cs.removeAt(arr, idx)
    table.remove(arr, idx);
end

function cs.single(tbl,predicate)
    predicate = predicate;-- or (function(x) return true end)
    local result = nil
    local count = 0

    for _, v in ipairs(tbl) do
        if predicate(v) then
            result = v
            count = count + 1
            if count > 1 then
                break
            end
        end
    end

    if count == 0 then
        error("No matching element found")
    elseif count > 1 then
        error("More than one matching element found")
    end

    return result
end

function cs.removeAll(arr,func)
    local arrArr =cs.findAll(arr,func);
    for i,v in ipairs(arrArr) do
        cs.remove(arr,v);
    end
end

function cs.union(arr,arr2)
    local t =cs.concat(arr,arr2);
    return cs.distinct(t);
end

--交集
function cs.intersect(a,b)
    local result = {}
    local hashA = {}
    local hashB = {}

    -- 为两个表创建查找表并去重
    for _, v in ipairs(a) do
        hashA[v] = true
    end

    for _, v in ipairs(b) do
        hashB[v] = true
    end

    -- 找出两个集合中都存在的元素
    for k in pairs(hashA) do
        if hashB[k] then
            table.insert(result, k)
        end
    end

    return result
end

-- 差集
function cs.except(a,b)
    local result = {}
    local hashA = {}
    local hashB = {}

    -- 为两个表创建查找表并去重
    for _, v in ipairs(a) do
        hashA[v] = true
    end

    for _, v in ipairs(b) do
        hashB[v] = true
    end

    -- 找出只在第一个集合中存在的元素
    for k in pairs(hashA) do
        if not hashB[k] then
            table.insert(result, k)
        end
    end

    return result
end

function cs.skip(tbl,count)
    local result = {}
    for i = count + 1, #tbl do
        table.insert(result, tbl[i])
    end
    return result
end

function cs.take(tbl,count)
    local result = {}
    for i = 1, math.min(count, #tbl) do
        table.insert(result, tbl[i])
    end
    return result
end

function cs.sequenceEqual(arr,arr2)
    if (#arr ~= #arr2) then
        return false;
    end

    for i,v in ipairs(arr) do
        if(arr[i]~=arr2[i])then
            return false;
        end
    end

    return true;
end

function cs.reverse(arr)
    local l = 1;
    local r = #arr;

    while l < r do
        arr[l], arr[r] = arr[r], arr[l];
        l = l + 1;
        r = r - 1;
    end
end

function cs.max(arr)
    local minVal = arr[1]
    local maxVal = arr[1]
    for i = 2, #arr do
        if arr[i] < minVal then
            minVal = arr[i]
        end
        if arr[i] > maxVal then
            maxVal = arr[i]
        end
    end
    return maxVal,minVal
end

function cs.min(arr)
    local minVal = arr[1]
    local maxVal = arr[1]
    for i = 2, #arr do
        if arr[i] < minVal then
            minVal = arr[i]
        end
        if arr[i] > maxVal then
            maxVal = arr[i]
        end
    end
    return minVal, maxVal
end

function cs.addRange(arr, range)
    for i, v in ipairs(range) do
        arr[#arr + 1] = v;
    end
end

function cs.contains(arr, val)
    for i, v in ipairs(arr) do
        if val == v then
            return true;
        end
    end
    return false;
end

function cs.forEach(t, func)
    for i = 1, #t do
        func(t[i]);
    end
end

function cs.in_case(val_item)
    if val_item == 0 then
        return false;
    elseif val_item == "" then
        return false
    end
    return val_item;
end;

function cs.trueForAll(t,func)
    return cs.all(t,func);
end

function cs.binarySearch(t,item)
    local left, right = 1, #arr

    while left <= right do
        local mid = math.floor((left + right) / 2)
        if arr[mid] == target then
            return mid  -- 找到目标值，返回其索引
        elseif arr[mid] < target then
            left = mid + 1  -- 调整搜索区间到右侧
        else
            right = mid - 1  -- 调整搜索区间到左侧
        end
    end

    return 0  -- 如果没有找到目标值，返回0
end

function cs.all(t, func)
    for i, v in ipairs(t) do
        if func(v) == false then
            return false;
        end
    end
    return true;
end

function cs.findAll(arr, fn)
    local res = {};
    for i, v in ipairs(arr) do
        if fn(v) then
            res[#res + 1] = v;
        end
    end
    return res;
end

function cs.exists(arr, fn)
    for i, v in ipairs(arr) do
        if fn(v) then
            return true;
        end
    end
    return false;
end


function cs.find(arr, fn)
    for i, v in ipairs(arr) do
        if fn(v) then
            return v;
        end
    end
    return nil;
end

function cs.sort(arr)
   table.sort(arr);
end

function cs.keys(hash)
    local res = {};
    for i, v in pairs(hash) do
        res[#res + 1] = i;
    end
    return res;
end

function cs.values(hash)
    local res = {};
    for i, v in pairs(hash) do
        res[#res + 1] = v;
    end
    return res;
end

function cs.containsKey(hash, key)
    return hash[key] ~= nil;
end

function cs.containsValue(hash, val)
    local values = cs.values(hash);

    return cs.indexof(values, val) ~= 0;
end

function cs.getRange(arr, start, count)
    local res = {};
    local endIndex = start + count - 1;
    for i = start, endIndex do
        res[#res + 1] = arr[i];
    end
    return res;
end

function cs.insertRange(arr, start, range)
    cs.reverse(range);
    for i, v in ipairs(range) do
        table.insert(arr, start, v);
    end
end

function cs.removeRange(arr, start, count)
    local endIndex = start + count - 1;

    for i = start, endIndex do
        table.remove(arr, start);
    end
end

function cs.distinct(arr)
    local res = {};
    for i, v in ipairs(arr) do
        if not cs.contains(res, v) then
            res[#res + 1] = v;
        end
    end
    return res;
end

function cs.any(arr, fn)
    for i, v in ipairs(arr) do
        if fn(v) then
            return true;
        end
    end
    return false;
end

function cs.concat(t, t2)
    local t3 = {};
    for i, v in ipairs(t) do
        t3[#t3 + 1] = v;
    end
    for i, v in ipairs(t2) do
        t3[#t3 + 1] = v;
    end
    return t3;
end

function cs.where(t, func)
    local res = {};
    for i = 1, #t do
        local item = t[i];
        if (func(item)) then
            table.insert(res, item);
        end
    end
    return res;
end

function cs.select(t, func)
    local res = {};
    for i, v in ipairs(t) do
        res[i] = func(v);
    end
    return res;
end

function cs.join(flag, arr)
    flag = flag or "";
    return table.concat(arr, flag);
end

function cs.startsWith(str, prefix)
    return str:sub(1, #prefix) == prefix
end

function cs.sum(arr)
    local total =0;
    for i,v in ipairs(arr)do
        total =total +v;
    end;
    return total;
end

function cs.average(arr)
    local sum =cs.sum(arr);
    return sum/(#arr);
end

local function test()
    local a = { 1, 2, 3 };
    local a2 = cs.select(a, function(item)
        return item * 2
    end);
    assert(#a2 == 3);
end
test();
return cs;