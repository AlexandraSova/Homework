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

        public override Dictionary<string, System.Type> GetFieldsTypes()
        {
            Dictionary<string, System.Type> result = new Dictionary<string, System.Type>();
            result.Add("id", typeof(int));
            result.Add("start", typeof(string));
            result.Add("finish", typeof(string));
            result.Add("manager_id", typeof(int));
            result.Add("client_id", typeof(int));
            return result;
        }
    }
}
