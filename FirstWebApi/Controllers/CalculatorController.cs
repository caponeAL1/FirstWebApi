using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // api/Calculator/Add?x=5&y=10
        [HttpGet("Calculator/Add")]
        public int Add(int x,int y)
        {
            return x + y;
        }
        [HttpGet("Calculator/Sum")]
        public int Sum(int x, int y)
        {
            return x + y+1000;
        }
        // api/Calculator/Subtract?x=5&y=10
        [HttpPost]
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        // api/Calculator/Multiply?x=5&y=10
        [HttpPut]
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        // api/Calculator/Divide?x=5&y=10
        [HttpDelete]
        public int Divide(int x, int y)
        {
            return x / y;
        }

    }
}
