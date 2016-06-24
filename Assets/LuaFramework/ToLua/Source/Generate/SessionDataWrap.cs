﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SessionDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SessionData), typeof(System.Object));
		L.RegFunction("clear", clear);
		L.RegFunction("New", _CreateSessionData);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Id", get_Id, set_Id);
		L.RegVar("ServiceCode", get_ServiceCode, set_ServiceCode);
		L.RegVar("LuaFunction", get_LuaFunction, set_LuaFunction);
		L.RegVar("Args", get_Args, set_Args);
		L.RegVar("ByteBuffer", get_ByteBuffer, set_ByteBuffer);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSessionData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SessionData obj = new SessionData();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SessionData.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SessionData obj = (SessionData)ToLua.CheckObject(L, 1, typeof(SessionData));
			obj.clear();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			int ret = obj.Id;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Id on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ServiceCode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			int ret = obj.ServiceCode;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ServiceCode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaFunction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			LuaInterface.LuaFunction ret = obj.LuaFunction;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index LuaFunction on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Args(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			object[] ret = obj.Args;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Args on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ByteBuffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			LuaFramework.ByteBuffer ret = obj.ByteBuffer;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ByteBuffer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Id = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Id on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ServiceCode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.ServiceCode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ServiceCode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_LuaFunction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 2);
			obj.LuaFunction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index LuaFunction on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Args(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			object[] arg0 = ToLua.CheckObjectArray(L, 2);
			obj.Args = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Args on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ByteBuffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SessionData obj = (SessionData)o;
			LuaFramework.ByteBuffer arg0 = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 2, typeof(LuaFramework.ByteBuffer));
			obj.ByteBuffer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ByteBuffer on a nil value" : e.Message);
		}
	}
}

