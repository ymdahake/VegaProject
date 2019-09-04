using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vega.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public String Status { get; set; }

        public int PerPersonAmount { get; set; }

        public Boolean IsActive { get; set; }

        public virtual List<MenuCategory> MenuCategories { get; set; }

        

    }
}