using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vega.Models
{
    public class MenuCategory
    {
        [Key]
        public int MenuCategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

    }
}