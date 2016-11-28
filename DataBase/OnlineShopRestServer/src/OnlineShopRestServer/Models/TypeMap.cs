using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public static class TypeMap
    {
        static Dictionary<string, System.Type> type_map;
        static TypeMap()
        {
            type_map = new Dictionary<string, System.Type>();
            type_map.Add("address", typeof(Address));
            type_map.Add("client", typeof(Client));
            type_map.Add("item", typeof(Item));
            type_map.Add("manager", typeof(Manager));
            type_map.Add("order", typeof(Order));
            type_map.Add("product", typeof(Product));
            type_map.Add("type", typeof(Models.Type));
        }

        public static System.Type GetTableType(string name)
        {
            return type_map[name];
        }
    }
}
