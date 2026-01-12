using ASP_work.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service1;
        private readonly INotificationService _service2;

        public NotificationController(INotificationService s1, INotificationService s2)
        {
            _service1 = s1;
            _service2 = s2;
        }

        [HttpGet("test-lifetime")]
        public IActionResult Test() => Ok(new { Id1 = _service1.GetInstanceId(), Id2 = _service2.GetInstanceId() });    
    }
}
