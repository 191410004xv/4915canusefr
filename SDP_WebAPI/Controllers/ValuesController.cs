using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;

namespace SDP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet("SimpleGetMethod")]

        public String Get()
        {
            return $"this is returned by the web API server. Current time is: {DateTime.Now}";
        }
    }
}
  
