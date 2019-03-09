using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
        [Display(Name = "Menu Name")]
        public Menu Menu { get; set; }

        [Display(Name = "Items Name")]
        public IList<CheeseMenu> Items { get; set; }
    }
}
