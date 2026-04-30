using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyTestWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet(Name = "GetDepartment")]
        public string Get()
        {
            return "My Department!";
        }
    }
}
