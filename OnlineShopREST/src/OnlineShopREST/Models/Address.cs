using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopREST.Models
{
    public class Address : Model
    {
        public int id { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string flat { get; set; }
    }
}
