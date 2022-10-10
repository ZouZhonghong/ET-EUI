﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ET
{
	public static  class DlgLoginSystem
	{

		public static void RegisterUIEvent(this DlgLogin self)
		{
			self.View.E_LoginButton.AddListenerAsync(() => { return self.OnLoginClickHandler();});
			
		}

		public static void ShowWindow(this DlgLogin self, Entity contextData = null)
		{
			self.View.ESCommonUI_1.SetLabelConten("登录界面");
		}
		
		public static  async ETTask OnLoginClickHandler(this DlgLogin self)
		{
			Log.Debug("OnLoginClickHandler");
			self.DomainScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Login);
			self.DomainScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Test);
			await ETTask.CompletedTask;
			// try
			// {
			// 	int errorCode = await LoginHelper.Login(self.DomainScene(),
			// 		ConstValue.LoginAddress,
			// 		self.View.E_AccountInputField.GetComponent<InputField>().text,
			// 		self.View.E_PasswordInputField.GetComponent<InputField>().text);
			//
			// 	if (errorCode != ErrorCode.ERR_Success)
			// 	{
			// 		Log.Error(errorCode.ToString());
			// 		return;
			// 	}
			//
			// 	errorCode = await LoginHelper.GetServerInfos(self.ZoneScene());
			// 	if (errorCode != ErrorCode.ERR_Success)
			// 	{
			// 		Log.Error(errorCode.ToString());
			// 		return;
			// 	}
			// 	
			// 		//显示登录之后的页面逻辑
			// 		self.DomainScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Login);
			// 		self.DomainScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Lobby);
			//
			// }
			// catch (Exception e)
			// {
			// 	Log.Error(e.ToString());
			// }





		}
		
		public static void HideWindow(this DlgLogin self)
		{

		}
		
	}
}
