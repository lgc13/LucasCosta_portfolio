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
    public class Chocolate
    {
      public int ID { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public ChocolateType Type { get; set; }
      private static int nextId = 1;

      public Chocolate() {
        ID = nextId;
        nextId++;
      }

      public Chocolate(string name, string description)
      {
        Name = name;
        Description = description;
      }
    }
}
