using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LucasHelloWorld2.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("Hello Lucas! Have a good day - From Lucas");
        }
        public IActionResult Goodbye()
        {
            return Content("Now we say goodbye");
        }
        public IActionResult Sasha()
        {
          return Content("Sashinha test");
        }
    }
}
