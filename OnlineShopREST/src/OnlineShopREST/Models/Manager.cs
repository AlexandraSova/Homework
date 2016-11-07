using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopREST.Models
{
    public class Manager : Model
    {
        public int id { get; set; }
        public string name { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
    }
}
