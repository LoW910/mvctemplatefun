using Microsoft.AspNetCore.Mvc;
using MVCTemplate.Models;

namespace MVCTemplate.Controllers
{
    public class UserController : Controller{

        [HttpGet("user")]
        public IActionResult UserDetail(){
            
            User someUser = new User() {
                FirstName = "Tommy",
                LastName = "Mangled"
            };

            return View(someUser);
        }





    }
}