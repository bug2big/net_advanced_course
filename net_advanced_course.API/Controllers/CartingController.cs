using Microsoft.AspNetCore.Mvc;

namespace net_advanced_course.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartingController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CartingController> _logger;

        public CartingController(ILogger<CartingController> logger)
        {
            _logger = logger;
        }
    }
}