using System;
using Microsoft.AspNetCore.Mvc;
//using LucasHelloWorldMVC.Models;
using System.Text.Encodings.Web;

namespace LucasHelloWorldMVC.Controllers
{
    public class LucasController : Controller
    {
        //
        // GET: /Lucas/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /Lucas/Welcome/
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}
