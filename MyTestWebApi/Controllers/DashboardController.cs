using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyTestWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        [HttpGet(Name = "GetDashboard")]
        public string Get()
        {
            return "My Dashboard!";
        }
    }
}
