using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public class Client : Model
    {
        public int id { get; set; }
        public string fio { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
        public int manager_id { get; set; }
        public int address_id { get; set; }

        public override Dictionary<string, System.Type> GetFieldsTypes()
        {
            Dictionary<string, System.Type> result = new Dictionary<string, System.Type>();
            result.Add("id", typeof(int));
            result.Add("fio", typeof(string));
            result.Add("birthday", typeof(string));
            result.Add("phone", typeof(string));
            result.Add("manager_id", typeof(int));
            result.Add("address_id", typeof(int));
            return result;
        }
    }
}
