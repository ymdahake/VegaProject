using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vega.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuIteamId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public float Price { get; set; }
        public Boolean IsActive { get; set; }
        [Required]
        public int MenuCategoryId { get; set; }
        public int FoodCategory { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
    }
}