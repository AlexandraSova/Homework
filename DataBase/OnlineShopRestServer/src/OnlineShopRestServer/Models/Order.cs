using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public class Order : Model
    {
        public int id { get; set; }
        public string start { get; set; }
        public string finish { get; set; }
        public int manager_id { get; set; }
        public int client_id { get; set; }
    }
}
