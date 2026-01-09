using Microsoft.AspNetCore.Mvc;
using TwoToFour.Services;

namespace TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingController : ControllerBase
    {
        private readonly AddingService _addingService;

        public AddingController(AddingService addingService)
        {
            _addingService = addingService;
        }

        [HttpGet]
        [Route("AddNumbers/{num1}/{num2}")]
        public string AddNumbers(int num1, int num2)
        {
            return _addingService.AddTwoNumbers(num1, num2);
        }
    }
}