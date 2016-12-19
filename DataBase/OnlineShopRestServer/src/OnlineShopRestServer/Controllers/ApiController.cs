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
        const string server = "127.0.0.1";
        const string port = "5432";
        const string user = "postgres";
        const string password = "666";
        const string database = "online_shop";

        // GET api/client
        // GET api/client/?manager_id=2&address_id=1
        [HttpGet("{table}")]
        public IActionResult Get(string table)
        {
            data_base = new DataBase(server, port, user, password, database);
            try
            {
                if (Request.Query.Count > 0)
                {
                    return Json(data_base.SelectByFilter(table, Request.Query.ToList()));
                }

                return Json(data_base.Select("select * from " + table));
            }
            catch(Npgsql.PostgresException)
            {
                return StatusCode(400);
            }
        }

        // GET api/client/2
        [HttpGet("{table}/{id:int}")]
        public IActionResult Get(string table, int id)
        {
            data_base = new DataBase(server, port, user, password, database);
            try
            {
                return Json(data_base.Select("select * from " + table + " where id = '" + id.ToString() + "'"));
            }
            catch(Npgsql.PostgresException)
            {
                return StatusCode(400);
            }
        }

        // GET api/manager/2/client
        [HttpGet("{table}/{id:int}/{subTable}")]
        public IActionResult Get(string table, int id, string subTable)
        {
            data_base = new DataBase(server, port, user, password, database);
            try
            {
                return Json(data_base.Select("SELECT * FROM " + subTable + " WHERE " + TypeMap.GetTableFK(table) + "=" + id.ToString()));
            }
            catch(Npgsql.PostgresException)
            {
                return StatusCode(400);
            }
        }

        // POST api/clint
        [HttpPost("{table}")]
        public JsonResult Post(string table, [FromBody] JObject data)
        {
            data_base = new DataBase(server, port, user, password, database);
            try
            {
                Model model = (Model)data.ToObject(TypeMap.GetTableType(table));
                return Json(data_base.Insert(table, model));
            }
            catch
            {
                return Json("Ошибка");
            }
        }

        // PUT api/client/2
        [HttpPut("{table}/{id:int}")]
        public JsonResult Put(string table, int id, [FromBody] JObject data)
        {
            data_base = new DataBase(server, port, user, password, database);
            try
            {
                Model model = (Model)data.ToObject(TypeMap.GetTableType(table));
                return Json(data_base.Update(table, "id = " + id.ToString(), model));
            }
            catch
            {
                return Json("Ошибка");
            }
        }

        // DELETE api/client/2
        [HttpDelete("{table}/{id:int}")]
        public IActionResult Delete(string table, int id)
        {
            try
            {
                data_base = new DataBase(server, port, user, password, database);
                data_base.Delete(table, "id = " + id.ToString());
                return Json(new KeyValuePair<string, int>(key: "delete id", value: id));
            }
            catch(Npgsql.PostgresException)
            {
                return StatusCode(400);
            }
        }
    }
}
