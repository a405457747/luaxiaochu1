using System;

public enum ArgTypes
{
    Float,
    Int,
    Boolean,
    String,
    GameObject,
    LuaTable,
    LuaFunction
}



[Serializable]
public class LuaArg
{
    public ArgTypes ArgType;
    public string ArgValue;
}