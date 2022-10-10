using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgTest))]
	public static  class DlgTestSystem
	{

		public static void RegisterUIEvent(this DlgTest self)
		{
			self.View.E_EnterMapButton.AddListener(self.OnEnterMapClickHandler);
			self.View.EButton_TestButton.AddListener(self.OnTestClickHandler);
			self.AddComponent<UIComponent>();
		}

		public static void ShowWindow(this DlgTest self, Entity contextData = null)
		{
			self.View.ELabel_TestText.text = "Hello";
			self.View.ESCommonUI_1.SetLabelConten("测试界面");
		}
 
		public static void OnEnterMapClickHandler(this DlgTest self)
		{
			Log.Debug("Enter Map");


			self.DomainScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Test);
			self.DomainScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Login);
			
		}

		public static void OnTestClickHandler(this DlgTest self)
		{
			Log.Debug("Test Click");
		}
		
		 

	}
}
