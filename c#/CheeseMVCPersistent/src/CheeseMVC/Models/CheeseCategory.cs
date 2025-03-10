using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<Cheese> Cheese { get; set; }
        public IList<CheeseMenu> CheeseMenus { get; set; }
    }
}
