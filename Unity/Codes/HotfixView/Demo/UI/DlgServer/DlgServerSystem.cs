using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [FriendClass(typeof(DlgServer))]
    [FriendClassAttribute(typeof(ET.ServerInfosComponent))]
    [FriendClassAttribute(typeof(ET.ServerInfo))]
    public static class DlgServerSystem
    {

        public static void RegisterUIEvent(this DlgServer self)
        {
            self.View.EButton_ConfirmButton.AddListenerAsync(() => { return self.OnConfirmClickHandler(); });
            self.View.ELoopScrollList_ServerLoopVerticalScrollRect.AddItemRefreshListener((Transform transform, int index) =>
            {
                self.OnScrollItemFefreshHandler(transform, index);
            });
        }

        public static void ShowWindow(this DlgServer self, Entity contextData = null)
        {
            
            int count = self.ZoneScene().GetComponent<ServerInfosComponent>().ServerInfoList.Count;
            self.AddUIScrollItems(ref self.scrollItemServersT,count);
            self.View.ELoopScrollList_ServerLoopVerticalScrollRect.SetVisible(true,count);
            
        }


        public static void HideWindow(this DlgServer self)
        {
            self.RemoveUIScrollItems(ref self.scrollItemServersT);
        }

        public static void OnScrollItemFefreshHandler(this DlgServer self, Transform transform, int index)
        {
            Scroll_Item_Server serverTest = self.scrollItemServersT[index].BindTrans(transform);
            ServerInfo info = self.ZoneScene().GetComponent<ServerInfosComponent>().ServerInfoList[index];
            serverTest.EButton_ServerIdImage.color =
                    info.Id == self.ZoneScene().GetComponent<ServerInfosComponent>().CurrentServerId ? Color.red : Color.yellow;
            serverTest.ELabel_NameText.SetText(info.ServerName);
            serverTest.EButton_ServerIdButton.AddListener(() => { self.OnSelectServerItemHandler(info.Id);});

        }


        public static void OnSelectServerItemHandler(this DlgServer self,long serverId)
        {
            self.ZoneScene().GetComponent<ServerInfosComponent>().CurrentServerId = int.Parse(serverId.ToString());
            Log.Debug($"当前选择的服务器Id是：{serverId}");
            self.View.ELoopScrollList_ServerLoopVerticalScrollRect.RefillCells();
        }
        
        
        
        

        public static async ETTask OnConfirmClickHandler(this DlgServer self)
        {
            bool isSelcect = self.View.ZoneScene().GetComponent<ServerInfosComponent>().CurrentServerId != 0;
            if (!isSelcect)
            {
                Log.Error("请先选择区服");
                return;
            }

            try
            {
                int errorCode = await LoginHelper.GetRoles(self.ZoneScene());
                if (errorCode != ErrorCode.ERR_Success)
                {
                    Log.Error(errorCode.ToString());
                    return;
                }

                self.ZoneScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID__Roles);
                self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Server);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                throw;
            }
        }

    }
}
