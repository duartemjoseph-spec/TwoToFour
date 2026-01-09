using Microsoft.AspNetCore.Mvc;
using TwoToFour.Services;

namespace TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComparisonController : ControllerBase
    {
        private readonly ComparisonService _comparisonService;

        public ComparisonController(ComparisonService comparisonService)
        {
            _comparisonService = comparisonService;
        }

        [HttpGet]
        [Route("Compare/{num1}/{num2}")]
        public string Compare(int num1, int num2)
        {
            return _comparisonService.CompareNumbers(num1, num2);
        }
    }
}