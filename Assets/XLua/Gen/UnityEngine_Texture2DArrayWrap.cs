﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineTexture2DArrayWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Texture2DArray);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels", _m_GetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels32", _m_GetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels", _m_SetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels32", _m_SetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "format", _g_get_format);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isReadable", _g_get_isReadable);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "allSlices", _g_get_allSlices);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					int _mipCount = LuaAPI.xlua_tointeger(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					int _mipCount = LuaAPI.xlua_tointeger(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 8 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					bool _createUninitialized = LuaAPI.lua_toboolean(L, 8);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipCount, _linear, _createUninitialized);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipCount, _linear);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 8 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					bool _createUninitialized = LuaAPI.lua_toboolean(L, 8);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipChain, _linear, _createUninitialized);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipChain, _linear);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipChain);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels( _arrayElement );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels( _arrayElement, _miplevel );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.GetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels32( _arrayElement );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels32( _arrayElement, _miplevel );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.GetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color[] _colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetPixels( _colors, _arrayElement );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Color[] _colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.SetPixels( _colors, _arrayElement, _miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.SetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color32[] _colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetPixels32( _colors, _arrayElement );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Color32[] _colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.SetPixels32( _colors, _arrayElement, _miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.SetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.Apply(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Apply( _updateMipmaps );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool _updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    bool _makeNoLongerReadable = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Apply( _updateMipmaps, _makeNoLongerReadable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.Apply!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allSlices(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Texture2DArray.allSlices);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.depth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_format(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.format);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isReadable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isReadable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
