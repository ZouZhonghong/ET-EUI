namespace ET
{
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(Session))]
    public class AccountInfoComponent:Entity,IAwake,IDestroy
    {
        public string Token;
        public long AccountId;
    }
}