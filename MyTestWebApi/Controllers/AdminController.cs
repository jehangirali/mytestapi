using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyTestWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        [HttpGet(Name = "GetMyName")]
        public string Get()
        {
            return "Jahangir Ali!";
        }
    }
}
