using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public static class TypeMap
    {
        static Dictionary<string,Table> type_map;
        static TypeMap()
        {
            type_map = new Dictionary<string, Table>();
            type_map.Add("address", new Table(typeof(Address), "address_id"));
            type_map.Add("client", new Table(typeof(Client), "client_id"));
            type_map.Add("item", new Table(typeof(Item), "item_id"));
            type_map.Add("manager", new Table(typeof(Manager), "manager_id"));
            type_map.Add("order", new Table(typeof(Order), "order_id")); ;
            type_map.Add("product", new Table(typeof(Product), "product_id"));
            type_map.Add("type", new Table(typeof(Type), "type_id"));
        }

        public static System.Type GetTableType(string name)
        {
            try
            {
                return type_map[name].Type;
            }
            catch
            {
                return null;
            }
        }

        public static string GetTableFK(string name)
        {
            try
            {
                return type_map[name].FK;
            }
            catch
            {
                return "";
            }
        }

        public class Table
        {
            public System.Type Type;
            public string FK;
            public Table(System.Type type, string fk)
            {
                this.Type = type;
                this.FK = fk;
            }
        }
    }
}
