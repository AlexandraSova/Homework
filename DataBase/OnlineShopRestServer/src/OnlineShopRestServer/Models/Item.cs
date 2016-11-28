using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public class Item : Model
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int amount { get; set; }
    }
}
