using ASP_work.Interface;

namespace ASP_work.Service
{
    public class EmailNotificationService : INotificationService
    {
        private readonly Guid _instanceId = Guid.NewGuid();

        public string GetNotification() => "Notification sent via Email!";
        public Guid GetInstanceId() => _instanceId;
    }
}
