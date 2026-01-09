using Microsoft.AspNetCore.Mvc;
using TwoToFour.Services;

namespace TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpController : ControllerBase
    {
        private readonly WakeUpService _wakeUpService;

        public WakeUpController(WakeUpService wakeUpService)
        {
            _wakeUpService = wakeUpService;
        }

        [HttpGet]
        [Route("GetWakeUpInfo/{userName}/{wakeUpTime}")]
        public string GetWakeUpInfo(string userName, string wakeUpTime)
        {
            return _wakeUpService.CalculateWakeUp(userName, wakeUpTime);
        }
    }
}