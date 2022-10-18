using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ET
{
	[FriendClass(typeof(DlgTest))]
	public static  class DlgTestSystem
	{

		public static void RegisterUIEvent(this DlgTest self)
		{
			self.View.E_EnterMapButton.AddListener(self.OnEnterMapClickHandler);
			self.View.EButton_TestButton.AddListener(self.OnTestClickHandler);
			self.View.ELoopScrollList_TestLoopHorizontalScrollRect.AddItemRefreshListener((Transform Transform,int index)=>{self.OnLoopListItemRefreshHandler(Transform,index);});
		}

		public static void ShowWindow(this DlgTest self, Entity contextData = null)
		{
			self.View.ELabel_TestText.text = "Hello";
			self.View.ESCommonUI_1.SetLabelConten("测试界面");
			

			int count = 100;
			self.AddUIScrollItems(ref self.ScrollItemServerTest1sDict,count);
			self.View.ELoopScrollList_TestLoopHorizontalScrollRect.SetVisible(true,count);
		}


		public static void HideWindow(this DlgTest self)
		{
			self.RemoveUIScrollItems(ref self.ScrollItemServerTest1sDict);
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

		public static void OnLoopListItemRefreshHandler(this DlgTest self, Transform transform, int index)
		{
			Scroll_Item_ServerTest1 itemServerTest1 = self.ScrollItemServerTest1sDict[index].BindTrans(transform);
			itemServerTest1.ELabel_serverTestTextMeshProUGUI.text = $"{index}Server";

		}
		
		 

	}
}
