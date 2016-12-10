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

        public override Dictionary<string, System.Type> GetFieldsTypes()
        {
            Dictionary<string, System.Type> result = new Dictionary<string, System.Type>();
            result.Add("id", typeof(int));
            result.Add("order_id", typeof(int));
            result.Add("product_id", typeof(int));
            result.Add("amount", typeof(int));
            return result;
        }
    }
}
