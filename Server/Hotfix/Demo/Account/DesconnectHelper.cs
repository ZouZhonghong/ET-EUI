namespace ET
{
    public static class DesconnectHelper
    {
        public static async ETTask Disconnect(this Session self)
        {
            if (self == null || self.IsDisposed)
            {
                return;
            }

            long instancedId = self.InstanceId;

            await TimerComponent.Instance.WaitAsync(1000);

            if (self.InstanceId != instancedId)
            {
                return;
            }
            
            self.Dispose();
            
            
        }
    }
}