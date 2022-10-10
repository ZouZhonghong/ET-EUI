namespace ET
{

    public class AccountSeesionsComponentDestroySystem: DestroySystem<AccountSessionsComponent>
    {
        public override void Destroy(AccountSessionsComponent self)
        {
            self.AccountSessionsDictionary.Clear();
        }
    }
    [FriendClassAttribute(typeof(ET.AccountSessionsComponent))]
    public static class AccountSessionsComponentSystem
    {
        public static long Get(this AccountSessionsComponent self, long accountId)
        {
            if (!self.AccountSessionsDictionary.TryGetValue(accountId, out long intancedId))
            {
                return 0;
            }

            return accountId;
        }

        public static void Add(this AccountSessionsComponent self, long accountId, long sessionInstanceId)
        {
            if (self.AccountSessionsDictionary.ContainsKey(accountId))
            {
                self.AccountSessionsDictionary[accountId] = sessionInstanceId;
                return;
            }
            
            self.AccountSessionsDictionary.Add(accountId,sessionInstanceId);
        }


        public static void Remove(this AccountSessionsComponent self, long accountId)
        {
            if (self.AccountSessionsDictionary.ContainsKey(accountId))
            {
                self.AccountSessionsDictionary.Remove(accountId);
            }
        }

    }
}