using System;
using Microsoft.AspNetCore.Mvc;
//using LucasHelloWorldMVC.Models;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using ChocolateMVC.Models;
using System.Linq;

namespace LucasHelloWorldMVC.Controllers
{
    public class LucasController : Controller
    {
        static private List<string> Users_list = new List<string>();
        static private List<Chocolate> Chocolates = new List<Chocolate>();

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

        // GET: /Lucas/Chocolate
        [HttpGet]
        public IActionResult Chocolate(string name, string description)
        {

          ViewBag.Chocolates = Chocolates;

          return View();
        }

        // POST: /Lucas/Chocolate/New
        [HttpPost("Lucas/Chocolate/New")]
        // [Route("Lucas/Chocolate/New")]
        public IActionResult ChocolateNew(string name, string description)
        {
          Chocolate some_chocolate = new Chocolate();
          some_chocolate.Name = name;
          some_chocolate.Description = description;
          Chocolates.Add(some_chocolate);

          ViewBag.Chocolates = Chocolates;

          return View("Chocolate");
        }

        // POST: /Lucas/Chocolate/Remove
        [HttpPost("Lucas/Chocolate/Remove")]
        public IActionResult ChocolateRemove(int[] chocolateIds)
        {
          Console.WriteLine("chocolateIds before: ");
          foreach (int item in chocolateIds)
          {
            Console.WriteLine("id is: " + item);
          }
          Console.WriteLine(">>> Removing from list.");
          foreach (int id in chocolateIds)
          {
            Chocolates.RemoveAll(x => x.ID == id);
          }

          return Redirect("Chocolate");
        }

        // GET: /Lucas/New
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
