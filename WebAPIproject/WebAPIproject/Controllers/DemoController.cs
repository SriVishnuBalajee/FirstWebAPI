using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("Demo/Add")]
        public int Add(int x, int y)
        {
            return x + y + 50;
        }
        [HttpGet("Demo/Subtract")]
        public int Subtract(int x, int y)
        {
            return x - y - 10;
        }
        //api/[Calculator]/Multiply?x=12&y=2
        [HttpGet("Demo/Multiply")]
        public int Multiply(int x, int y)
        {
            return x * y * x;
        }
        //api/[Calculator]/Divide?x=14&y=2
        [HttpGet("Demo/Divide")]
        public int Divide(int x, int y)
        {
            return (x / y) / y;
        }
    }
}
