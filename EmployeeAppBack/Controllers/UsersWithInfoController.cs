using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class UsersWithInfoController : ControllerBase
    {
    }
}