﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UVChannelFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UVChannelFlags");
		addMember(l,1,"UV0");
		addMember(l,2,"UV1");
		addMember(l,4,"UV2");
		addMember(l,8,"UV3");
		LuaDLL.lua_pop(l, 1);
	}
}
