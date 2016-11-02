using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn
{
    public class Provider
    {
        public void WriteClient(string name, string last_name, string pass, string mail)
        {
            using (var connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=666;Database=check_in;"))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO client (name, lastname, password, email) VALUES(:value1, :value2, :value3, :value4)";
                    cmd.Parameters.AddWithValue("value1", name);
                    cmd.Parameters.AddWithValue("value2", last_name);
                    cmd.Parameters.AddWithValue("value3", pass);
                    cmd.Parameters.AddWithValue("value4", mail);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public bool CorrectFirstName(string name, string key)
        {
            return CorrectField(name, key, 1);
        }
        public bool CorrectLastName(string name,string key)
        {
            return CorrectField(name, key, 4);
        }
        public bool CorrectPass(string pass, string key)
        {
            return CorrectField(pass, key, 2);
        }
        public bool HaveMail(string mail)
        {
            bool b = false;
            using (var connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=666;Database=check_in;"))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select * from client";
                    NpgsqlDataReader reader;

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            string result = reader.GetString(3);//Получаем значение из 4 столбца! 3 это (2)!
                            if (mail == result) b = true;
                        }
                        catch { }
                    }
                    connection.Close();
                }
            }
            return b;
        }
        public Table GetPatient()
        {
            return GetTable("patient");
        }
        public Table GetDiagnosis()
        {
            return GetTable("diagnosis");
        }

        public bool AddPatient(string fio, string address, string tel, string policy, string passport, string diagnosis)
        {
            bool b;
            try
            {
                string cmd_string = "insert into patient values('" + fio + "','" + address + "','" + tel + "','" + policy + "','" + passport + "'," + diagnosis + ")";
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=666;Database=check_in;");
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(cmd_string, conn);
                command.ExecuteNonQuery();
                conn.Close();
                b = true;
            }
            catch
            {
                b = false;
            }
            return b;
        }
        public bool ChangePatient(string fio, string address, string tel, string policy, string passport, string diagnosis)
        {
           
                string cmd_string = "update patient set \"fio\"='" + fio + "',\"address\"='" + address + "',\"tel\"='" + tel + "',\"policy\"='" + policy + "',\"passport\"='" + passport + "',\"diagnosis_id\"=" + diagnosis + " where \"passport\"='" + passport + "'";
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=666;Database=check_in;");
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(cmd_string, conn);
                command.ExecuteNonQuery();
                conn.Close();
                bool b = true;
                return b;
        }
        public bool DeletePatient(string key)
        {
            bool b;
            try
            {
                string cmd_string = "delete from patient WHERE \"passport\"='" + key + "';";
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=666;Database=check_in;");
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(cmd_string, conn);
                command.ExecuteNonQuery();
                conn.Close();
                b = true;
            }
            catch
            {
                b = false;
            }
            return b;
        }
        private Table GetTable(string name)
        {
            Table table = new Table();
            List<string> column = new List<string>();
            string cmd_string = "select * from " + name;
             using (var connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=666;Database=check_in;"))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = cmd_string;
                    NpgsqlDataReader reader;

                    reader = cmd.ExecuteReader();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        while (reader.Read())
                        {
                            string result = Convert.ToString(reader.GetValue(i));
                            column.Add(result);
                        }
                        table.AddColumn(reader.GetName(i), column);
                            column = new List<string>();
                            reader = cmd.ExecuteReader();
                    }
                }
                 connection.Close();
                }
            return table;
            }       
        private bool CorrectField(string field, string key, int field_number)
        {
            bool b = false;
            using (var connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=666;Database=check_in;"))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select * from client";
                    NpgsqlDataReader reader;

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            if (reader.GetString(3) == key && reader.GetString(field_number) == field) b = true;

                        }
                        catch { }
                    }
                    connection.Close();
                }
            }
            return b;
        }
        }

    }