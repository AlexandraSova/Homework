using Npgsql;
using OnlineShopRestServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopRestServer
{
    public class DataBase
    {
        private NpgsqlConnection connection;

        public DataBase(string server, string port, string user, string password, string database)
        {
            connection = new NpgsqlConnection("Server=" + server + ";Port=" + port + ";User Id=" + user + ";Password=" + password + ";Database=" + database + ";");
            connection.Open();
        }

        public List<Dictionary<string, object>> Select(string command_text)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(command_text, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader[i]);
                    }
                    result.Add(row);
                }
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public void Update(string table, string where, Model model)
        {
            string command_text = "update " + table + " set " + UpdateData(ConvertModel(model)) + " where " + where + ";";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(command_text, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
        public int Insert(string table, Model model)
        {
            string command_text = "insert into " + table + InsertData(ConvertModel(model)) + " SELECT currval('" + table + "_id_seq');";
            int insert_id = -1;
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(command_text, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();
                insert_id = Convert.ToInt32(reader[0]);
            }
            finally
            {
                connection.Close();
            }
            return insert_id;
        }
        public void Delete(string table, string where)
        {
            string command_text = "DELETE FROM " + table + " WHERE " + where;
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(command_text, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
            }
            catch (Npgsql.PostgresException e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
        }

        private Dictionary<string, object> ConvertModel(Model model)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(model);
            for (int i = 0; i < properties.Count; i++)
            {
                result.Add(properties[i].Name, properties[i].GetValue(model));
            }
            return result;
        }
        private string InsertData(Dictionary<string, object> model)
        {
            model.Remove("id");//postgres сам проставит id (serial)
            string result = " (";
            string values = string.Join(", ", model.Keys);
            result = result + values + ") values ";
            values = "(";

            for (int i = 0; i < model.Count - 1; i++)//ставим кавычки, если string
            {
                KeyValuePair<string, object> element = model.ElementAt<KeyValuePair<string, object>>(i);
                if (element.Value.GetType() == typeof(string))
                {
                    values = values + "'" + element.Value + "'" + ", ";
                }
                else
                {
                    values = values + element.Value.ToString() + ", ";
                }
            }
            KeyValuePair<string, object> last_element = model.Last<KeyValuePair<string, object>>();
            if (last_element.Value.GetType() == typeof(string))
            {
                values = values + "'" + last_element.Value + "'";
            }
            else
            {
                values = values + last_element.Value.ToString();
            }
            result = result + values + ");";

            return result;
        }

        private string UpdateData(Dictionary<string, object> model)
        {
            model.Remove("id");
            string result = "";
            for (int i = 0; i < model.Count - 1; i++)
            {
                KeyValuePair<string, object> element = model.ElementAt<KeyValuePair<string, object>>(i);
                if (element.Value.GetType() == typeof(string))
                {
                    result = result + element.Key + " = " + "'" + element.Value + "', ";
                }
                else
                {
                    result = result + element.Key + " = " + element.Value.ToString() + ", ";
                }
            }

            KeyValuePair<string, object> last_element = model.Last<KeyValuePair<string, object>>();
            if (last_element.Value.GetType() == typeof(string))
            {
                result = result + last_element.Key + " = " + "'" + last_element.Value + "'";
            }
            else
            {
                result = result + last_element.Key + " = " + last_element.Value.ToString();
            }
            return result;
        }

    }
}
