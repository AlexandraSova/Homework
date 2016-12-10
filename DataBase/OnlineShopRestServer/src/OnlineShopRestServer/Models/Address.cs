using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
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
        public override Dictionary<string, System.Type> GetFieldsTypes()
        {
            Dictionary<string, System.Type> result = new Dictionary<string, System.Type>();
            result.Add("id", typeof(int));
            result.Add("country", typeof(string));
            result.Add("region", typeof(string));
            result.Add("city", typeof(string));
            result.Add("street", typeof(string));
            result.Add("house", typeof(string));
            result.Add("flat", typeof(string));
            return result;
        }
    }
}
