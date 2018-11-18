using System;
using Microsoft.AspNetCore.Mvc;
//using LucasHelloWorldMVC.Models;
using System.Text.Encodings.Web;
using System.Collections.Generic;

namespace LucasHelloWorldMVC.Controllers
{
    public class LucasController : Controller
    {
        static private List<string> Users_list = new List<string>();

        // GET: /Lucas/
        public IActionResult Index()
        {
            List<string> cheeses = new List<string>();

            cheeses.Add("Cheddar");
            cheeses.Add("American");
            cheeses.Add("Provolone");

            ViewBag.cheeses = cheeses;
            return View();
        }

        // GET: /Lucas/Add
        public IActionResult New()
        {
            return View();
        }

        // POST: /Lucas/List
        [HttpPost]
        public IActionResult List(string user)
        {
            Users_list.Add(user);

            ViewBag.users = Users_list;
            return View();
        }

        // GET: /Lucas/Welcome/
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}
