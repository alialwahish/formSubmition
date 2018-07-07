using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formValid.Models;

namespace formValid.Controllers
{
    public class HomeController : Controller
    {
        User user = new User();

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(user);
        }
       
       [HttpPost("Home/create")]
       public IActionResult Display(User user){
           Console.WriteLine("trying to create a user ");
           if(ModelState.IsValid){
           Console.WriteLine("User validation success");    
           return View();
           }
           else
           {
               Console.WriteLine("Validation is Wrong");
               return View("Index");
           }

       }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
