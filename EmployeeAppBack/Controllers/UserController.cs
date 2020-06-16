using EmployeeAppBack.DAL;
using EmployeeAppBack.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

namespace EmployeeAppBack.Controllers
{

    // TODO Get CompletedTrainingInfo By user
    // TODO Get AcceptedTrainingInfo By user
    // TODO Get EligibleTrainingInfo By user
    // TODO Get InterestedTrainingInfo By user

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class UserController : ControllerBase
    {
        private DALUser daluser;

        public UserController(DALUser daluser)
        {
            this.daluser = daluser;
        }

        // GET api/Accounts/Accounts
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return daluser.GetUsers();
        }

        [HttpGet("getImage")]
        public ActionResult GetImage()
        {
            string file = "weddingprofile.jpg";
            string path = @"C:\Users\Raizel Seliger\source\repos\IYEproj\emAppBack\EmployeeAppBack\images";
            string filepath = Path.Combine(path, file);

            return File(filepath, "image/jpg", Path.GetFileName(filepath));
        }

        [HttpGet("{uname}/{password}")]
        public ActionResult<User> GetUser(string uname, string password)
        {
            return daluser.GetUser(uname, password);
        }
    }
}