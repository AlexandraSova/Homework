using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopREST.Models
{
    public class Product : Model
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string colour { get; set; }
        public int type_id { get; set; }
        public int amount { get; set; }
        public string material { get; set; }
        public string print { get; set; }
        public string description { get; set; }
        public string characteristics { get; set; }
    }
}
