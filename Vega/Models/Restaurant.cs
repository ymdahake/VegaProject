using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vega.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public String Status { get; set; }

        public int PerPersonAmount { get; set; }

        public virtual List<MenuCategory> MenuCategories { get; set; }


    }
}