using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ChocolateMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ChocolateMVC.ViewModels
{
    public class AddChocolateViewModel
    {
      // [Required] needs "using System.ComponentModel.DataAnnotations;"
      [Required]
      [Display(Name="Chocolate Name")]
      public string Name { get; set; }

      [Required(ErrorMessage = "GIMME A CHOCOLATE DESCRIPTION, DAMN IT!")]
      public string Description { get; set; }

      public ChocolateType Type { get; set; }

      public List<SelectListItem> ChocolateTypes { get; set; }

      public AddChocolateViewModel()
      {
        ChocolateTypes = new List<SelectListItem>();

        ChocolateTypes.Add(new SelectListItem {
          Value = ((int)ChocolateType.White).ToString(),
          Text = ChocolateType.White.ToString()
          });

        ChocolateTypes.Add(new SelectListItem {
          Value = ((int)ChocolateType.Dark).ToString(),
          Text = ChocolateType.Dark.ToString()
          });

        ChocolateTypes.Add(new SelectListItem {
          Value = ((int)ChocolateType.Milk).ToString(),
          Text = ChocolateType.Milk.ToString()
          });
      }
    }
}
