using System;


namespace ET
{
    [FriendClassAttribute(typeof(ET.AccountInfoComponent))]
    [FriendClassAttribute(typeof(ET.ServerInfosComponent))]
    [FriendClassAttribute(typeof(ET.RoleInfosComponent))]
    public static class LoginHelper
    {
        public static async ETTask<int> Login(Scene zoneScene, string address, string account, string password)
        {

            A2C_LoginAccount a2CLoginAccount = null;
            Session accountSession = null;

            try
            {
                accountSession = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                password = MD5Helper.StringMD5(password);
                a2CLoginAccount = (A2C_LoginAccount)await accountSession.Call(new C2A_LoginAccount() { AccountName = account, Password = password });


            }
            catch (Exception e)
            {
                accountSession?.Dispose();
                Log.Error(e.ToString());
                return ErrorCode.Err_NetWorkError;
            }

            if (a2CLoginAccount.Error != ErrorCode.ERR_Success)
            {
                accountSession?.Dispose();
                return a2CLoginAccount.Error;
            } 

            zoneScene.AddComponent<SessionComponent>().Session = accountSession;
            zoneScene.GetComponent<SessionComponent>().Session.AddComponent<PingComponent>();

            zoneScene.GetComponent<AccountInfoComponent>().Token = a2CLoginAccount.Token;
            zoneScene.GetComponent<AccountInfoComponent>().AccountId = a2CLoginAccount.AccountId;

            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> GetServerInfos(Scene zoneScene)
        {
            Log.Debug("GetServerInfos");
            A2C_GetServerInfos a2CGetServerInfos = null;

            try
            {
                a2CGetServerInfos=(A2C_GetServerInfos)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_GetServerInfos()
                {
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    Token = zoneScene.GetComponent<AccountInfoComponent>().Token
                });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.Err_NetWorkError;
            }


            if (a2CGetServerInfos.Error != ErrorCode.ERR_Success)
                return a2CGetServerInfos.Error;

            Log.Debug("serverinfolist.cont "+a2CGetServerInfos.ServerInfoList.ToString());
            foreach (var serverInfoProto in a2CGetServerInfos.ServerInfoList)
            {
                ServerInfo serverInfo = zoneScene.GetComponent<ServerInfosComponent>().AddChild<ServerInfo>();
                
                serverInfo.FromMessage(serverInfoProto);
                
                zoneScene.GetComponent<ServerInfosComponent>().Add(serverInfo);
            }


            await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> GetRoles(Scene zoneScene)
        {
            A2C_GetRoles a2CGetRoles = null;
            try
            {
                a2CGetRoles = (A2C_GetRoles)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_GetRoles()
                {
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    Token = zoneScene.GetComponent<AccountInfoComponent>().Token,
                    ServerId = zoneScene.GetComponent<ServerInfosComponent>().CurrentServerId
                });
            }
            catch (Exception e)
            {
               Log.Error(e.ToString());
               return ErrorCode.Err_NetWorkError;
            }

            if (a2CGetRoles.Error != ErrorCode.ERR_Success)
            {
                Log.Error(a2CGetRoles.Error.ToString());
                return a2CGetRoles.Error;
            }
            zoneScene.GetComponent<RoleInfosComponent>().RoleInfos.Clear();

            foreach (var roleInfoProto in a2CGetRoles.RoleInfo)
            {
                RoleInfo roleInfo = zoneScene.GetComponent<RoleInfosComponent>().AddChild<RoleInfo>();
                roleInfo.FromMessage(roleInfoProto);
                zoneScene.GetComponent<RoleInfosComponent>().RoleInfos.Add(roleInfo);
            }

            return ErrorCode.ERR_Success;

        }
        public static async ETTask<int> CreateRole(Scene zoneScene, string name)
        {


            A2C_CreateRole a2CCreateRole = null;
            try
            {
                a2CCreateRole = (A2C_CreateRole)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_CreateRole()
                {
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    Token = zoneScene.GetComponent<AccountInfoComponent>().Token,
                    Name = name,
                    ServerId = zoneScene.GetComponent<ServerInfosComponent>().CurrentServerId,

                });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.Err_NetWorkError;
            }

            if (a2CCreateRole.Error != ErrorCode.ERR_Success)
            {
                Log.Error(a2CCreateRole.Error.ToString());
                return a2CCreateRole.Error;
            }

            RoleInfo newroRoleInfo = zoneScene.GetComponent<RoleInfosComponent>().AddChild<RoleInfo>();
            newroRoleInfo.FromMessage(a2CCreateRole.RoleInfo);

            zoneScene.GetComponent<RoleInfosComponent>().RoleInfos.Add(newroRoleInfo);
            
           // await ETTask.CompletedTask;
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> DeleteROle(Scene zoneScene)
        {

            A2C_DeleteRole a2CDeleteRole = null;
            try
            {
                a2CDeleteRole = (A2C_DeleteRole)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_DeleteRole()
                {
                    Token = zoneScene.GetComponent<AccountInfoComponent>().Token,
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    RoleInfoId = zoneScene.GetComponent<RoleInfosComponent>().CurrentRoleId,
                    ServerId = zoneScene.GetComponent<ServerInfosComponent>().CurrentServerId
                });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.Err_NetWorkError;
            }

            int index = zoneScene.GetComponent<RoleInfosComponent>().RoleInfos.FindIndex((info) =>
            {
                return info.Id == a2CDeleteRole.DeletedRoleInfoId;
            });
            
            zoneScene.GetComponent<RoleInfosComponent>().RoleInfos.RemoveAt(index);
             await ETTask.CompletedTask;
             return ErrorCode.ERR_Success;
        }

    }


}