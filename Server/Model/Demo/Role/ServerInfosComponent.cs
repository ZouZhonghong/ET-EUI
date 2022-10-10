using System.Collections.Generic;

namespace ET
{
    public class ServerInfosComponent:Entity,IAwake,IDestroy
    {
        public List<ServerInfo> ServerInfonList = new List<ServerInfo>();
        public int CurrentServerId = 0;
    }
}