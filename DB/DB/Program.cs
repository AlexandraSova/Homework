using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
   
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Base DataBase = new Base();
            DataBase.ConnectToDataBase();
            DataBase.ConnectToAllTables();
            
            //создание новой таблицы
            string s = "id:int:Unique|name:string:AllowDbNull|city:string:AllowDbNull";
            List<string> Lines = new List<string>();
            Lines.Add("4|Олег|Москва");
            Lines.Add("3|Маргарита|Москва");
            DataBase.Create("Proba", s, Lines);

            //изменение
            DataBase.Update("emploee", "city", "Вологда", "city", "==", "Москва");

            //получить все с id>1
            List<Base.Row> rows1 = DataBase.Get("emploee", "id", ">", "1");

            //удалить запись с id==0
            DataBase.Delete("customer", "id", "==", "2");

            //получить все записи таблицы
            List<Base.Row> rows2 = DataBase.GetAllLines("customer");

            //вставить Lines в emploee
            DataBase.Insert("emploee", Lines);

            //coхранить
            DataBase.Save();
        }
    }
}
