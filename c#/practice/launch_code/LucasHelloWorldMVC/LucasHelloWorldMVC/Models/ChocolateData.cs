using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChocolateMVC.Models
{
    public class ChocolateData
    {
      static private List<Chocolate> chocolatesList2 = new List<Chocolate>();

      // GetAll
      public static List<Chocolate> GetAll(){
        return chocolatesList2;
      }

      // Add
      public static void Add(Chocolate newChocolate) {
        chocolatesList2.Add(newChocolate);
      }

      // Remove
      public static void Remove(int id) {
        Chocolate chocolateToRemove = GetById(id);
      }

      // GetById
      public static Chocolate GetById(int id) {
        return chocolatesList2.Single(item => item.ID == id);
      }

    }
}
