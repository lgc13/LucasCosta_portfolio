using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using System.Collections.Generic;
using CheeseMVC.ViewModels;
using CheeseMVC.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly CheeseDbContext context;

        public MenuController(CheeseDbContext dbContext)
        {
          context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Menu> menus = context.Menus.ToList();

            return View(menus);
        }

        public IActionResult Add()
        {
            AddMenuViewModel addMenuViewModel = new AddMenuViewModel();
            return View(addMenuViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddMenuViewModel addMenuViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new menu to my existing menu
                Menu newMenu = new Menu
                {
                    Name = addMenuViewModel.Name
                };

                context.Menus.Add(newMenu);
                context.SaveChanges();

                return Redirect("/Menu/ViewMenu/" + newMenu.ID);
            }

            return View(addMenuViewModel);
        }

        public IActionResult ViewMenu(int id)
        {
            Menu menu = context.Menus.Single(c => c.ID == id);
            List<CheeseMenu> items = context
                .CheeseMenus
                .Include(item => item.Cheese)
                .Where(cm => cm.MenuID == id)
                .ToList();
            ViewMenuViewModel viewMenuViewModel = new ViewMenuViewModel
            {
                Menu = menu,
                Items = items

            };

            return View(viewMenuViewModel);
        }

        public IActionResult AddItem(int id)
        {
            Menu menu = context.Menus.Single(c => c.ID == id);
            List<Cheese> cheeses = context.Cheeses.ToList();
            AddMenuItemViewModel addMenuItemViewModel = new AddMenuItemViewModel(menu, cheeses);
            return View(addMenuItemViewModel);
        }

        [HttpPost]
        public IActionResult AddItem(AddMenuItemViewModel addMenuItemViewModel)
        {
          if (ModelState.IsValid)
          {
              var cheese = addMenuItemViewModel.cheeseID;
              var menu = addMenuItemViewModel.menuID;

              IList<CheeseMenu> existingItems = context.CheeseMenus
                .Where(cm => cm.CheeseID == cheese)
                .Where(cm => cm.MenuID == menu).ToList();

              if (existingItems.Count == 0) {
                  CheeseMenu menuItem = new CheeseMenu
                  {
                      Cheese = context.Cheeses.Single(c=> c.ID == cheese),
                      Menu = context.Menus.Single(c => c.ID == menu),
                  };

                  context.CheeseMenus.Add(menuItem);
                  context.SaveChanges();
              }
              return Redirect("/Menu/ViewMenu/" + menu);
          }

          return View(addMenuItemViewModel);
      }
    }
}
