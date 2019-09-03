using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vega.Models
{
    public class MenuItem
    {
        public int MenuIteamId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        
        public virtual MenuCategory MenuCategory { get; set; }
    }
}