using MongoDB.Driver;

namespace ET
{
    /// <summary>
    /// 用来缓存数据
    /// </summary>
  [ComponentOf(typeof(Scene))]
  
    public class DBComponent: Entity, IAwake<string, string, int>, IDestroy
    {
        public const int TaskCount = 32;

        public MongoClient mongoClient;
        public IMongoDatabase database;
    }
}