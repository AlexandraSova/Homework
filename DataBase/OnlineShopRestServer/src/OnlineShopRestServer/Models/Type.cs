using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public class Type : Model
    {
        public int id { get; set; }
        public string name { get; set; }

        public override Dictionary<string, System.Type> GetFieldsTypes()
        {
            Dictionary<string, System.Type> result = new Dictionary<string, System.Type>();
            result.Add("id", typeof(int));
            result.Add("name", typeof(string));
           
            return result;
        }
    }
}
