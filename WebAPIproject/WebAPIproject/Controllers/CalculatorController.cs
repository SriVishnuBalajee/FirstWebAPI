using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //api/[Calculator]/Add?x=10&y=2
       [HttpGet("/Add")]
        
        public int Add(int x, int y)
        {
            return x+y;
        }
        //api/[Calculator]/Subtract?x=11&y=2
        [HttpGet("/Subtract")]
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        //api/[Calculator]/Multiply?x=12&y=2
        [HttpGet("/Multiply")]
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        //api/[Calculator]/Divide?x=14&y=2
        [HttpGet("/Divide")]
        public int Divide(int x, int y)
        {
            return x / y;
        }


    }
}
