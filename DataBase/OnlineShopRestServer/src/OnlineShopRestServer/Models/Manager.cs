using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public class Manager : Model
    {
        public int id { get; set; }
        public string fio { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }

        public override Dictionary<string, System.Type> GetFieldsTypes()
        {
            Dictionary<string, System.Type> result = new Dictionary<string, System.Type>();
            result.Add("id", typeof(int));
            result.Add("fio", typeof(string));
            result.Add("birthday", typeof(string));
            result.Add("phone", typeof(string));
            return result;
        }
    }
}
