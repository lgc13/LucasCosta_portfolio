using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            ViewBag.check = "all";
            return View();
        }

        // TODO #1 - Create a Results action method to process
        // search request and display results
        public IActionResult Results(string searchType, string searchTerm)
        {

            List<Dictionary<string, string>> jobs = new List<Dictionary<string, string>>();
            if (searchType != "all")
            {
                jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            else { // if they are searchign for "all"
                jobs = JobData.FindByValue(searchTerm);
            }


            ViewBag.jobs = jobs;

            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Results";
            ViewBag.check = searchType;

            return View("Index"); // Redirecting to the Index() method
        }

    }
}
