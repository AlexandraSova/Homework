using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OnlineShopREST.Models;

namespace OnlineShopREST.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        DataBase data_base;

        public ApiController()
        {
            data_base = new DataBase("127.0.0.1", "5432", "postgres", "666", "shop");
        }

        // GET api/{table}
        [HttpGet("{table}")]
        public JsonResult Get(string table)
        {
            return Json(data_base.Select("select * from " + table));
        }

        // GET api/{table}/{id}
        [HttpGet("{table}/{id:int}")]
        public JsonResult Get(string table, int id)
        {
            return Json(data_base.Select("select * from " + table + " where id = '" + id.ToString() + "'"));
        }

        // POST api/{table}
        [HttpPost("{table}")]
        public JsonResult Post(string table, [FromBody] JObject data)
        {
            Model model = (Model)data.ToObject(TypeMap.GetTableType(table));
            return Json(data_base.Insert(table, model));
        }

        // PUT api/{resource}/{id}
        [HttpPut("{table}/{id:int}")]
        public JsonResult Put(string table, int id, [FromBody] JObject data)
        {
            Model model = (Model)data.ToObject(TypeMap.GetTableType(table));
            return Json(data_base.Update(table, "id = " + id.ToString(), model));
        }

        // DELETE api/values/{id}
        [HttpDelete("{table}/{id:int}")]
        public void Delete(string table, int id)
        {
            data_base.Delete(table, "id = " + id.ToString());
        }
    }
}
