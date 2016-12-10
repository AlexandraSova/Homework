using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer.Models
{
    public class Model
    {
        public virtual Dictionary<string, System.Type> GetFieldsTypes()
        {
            return new Dictionary<string, System.Type>();
        }
    }
}
