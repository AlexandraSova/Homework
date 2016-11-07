using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopREST.Models
{
    public class Client: Model
    {
        public int id { get; set; }
        public string name { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
        public int manager_id { get; set; }
        public int address_id { get; set; }
    }
}
