namespace ET
{


    public enum ServerStaturs
    {
        Normal = 0,
        Stop = 1
    }
    
    
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(Session))]
    public class ServerInfo:Entity,IAwake
    {
        public int Status;
        public string ServerName;

    }
}