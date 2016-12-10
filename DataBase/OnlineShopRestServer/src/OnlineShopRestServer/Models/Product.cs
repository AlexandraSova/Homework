using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
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

        public override Dictionary<string, System.Type> GetFieldsTypes()
        {
            Dictionary<string, System.Type> result = new Dictionary<string, System.Type>();
            result.Add("id", typeof(int));
            result.Add("name", typeof(string));
            result.Add("price", typeof(double));
            result.Add("colour", colour.GetType());
            result.Add("type_id", typeof(int));
            result.Add("amount", typeof(int));
            result.Add("material", typeof(string));
            result.Add("print", typeof(string));
            result.Add("description", typeof(string));
            result.Add("characteristics", typeof(string));
            return result;
        }
    }
}
