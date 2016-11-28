using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OnlineShopRestServer.Models;

namespace OnlineShopRestServer.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        DataBase data_base;

        // GET api/{table}
        [HttpGet("{table}")]
        public JsonResult Get(string table)
        {
            data_base = new DataBase("127.0.0.1", "5432", "postgres", "666", "online_shop");
            return Json(data_base.Select("select * from " + table));
        }

        // GET api/{table}/{id}
        [HttpGet("{table}/{id:int}")]
        public JsonResult Get(string table, int id)
        {
            data_base = new DataBase("127.0.0.1", "5432", "postgres", "666", "online_shop");
            return Json(data_base.Select("select * from " + table + " where id = '" + id.ToString() + "'"));
        }

        // POST api/{table}
        [HttpPost("{table}")]
        public JsonResult Post(string table, [FromBody] JObject data)
        {
            data_base = new DataBase("127.0.0.1", "5432", "postgres", "666", "online_shop");
            Model model = (Model)data.ToObject(TypeMap.GetTableType(table));
            return Json(data_base.Insert(table, model));
        }

        // PUT api/{resource}/{id}
        [HttpPut("{table}/{id:int}")]
        public void Put(string table, int id, [FromBody] JObject data)
        {
            data_base = new DataBase("127.0.0.1", "5432", "postgres", "666", "online_shop");
            Model model = (Model)data.ToObject(TypeMap.GetTableType(table));
            data_base.Update(table, "id = " + id.ToString(), model);
        }

        // DELETE api/values/{id}
        [HttpDelete("{table}/{id:int}")]
        public void Delete(string table, int id)
        {
            data_base = new DataBase("127.0.0.1", "5432", "postgres", "666", "online_shop");
            data_base.Delete(table, "id = " + id.ToString());
        }
    }
}
