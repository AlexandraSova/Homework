using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace DB
{
    class Base
    {
        private string DB_name;
        private List<Table> Tables = new List<Table>();
        private Table GetTable(string Name)
        {
            Table table = null;
            for (int i = 0; i < Tables.Count();i++ )
            {
                if(Name==Tables[i].TableName)
                {
                    table = Tables[i];
                    break;
                }
            }
                return table;
        }

        //Получает путь к папке с базой
        public void ConnectToDataBase()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            folderBrowserDialog.ShowDialog();

            DB_name = (folderBrowserDialog.SelectedPath);
        }

        //сохраняет для работы одну выбранную таблицу
        public void ConncectToTable()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            openFileDialog.ShowDialog();

            Table table = new Table(Path.GetFileName(openFileDialog.FileName));
            table.Path = openFileDialog.FileName;

            using (TextReader reader = new StreamReader(openFileDialog.FileName))
            {
                string schema = reader.ReadLine();

                foreach (string column in schema.Split('|'))
                {
                    table.AddColumn(new Column(column.Split(':')[0], column.Split(':')[1], column.Split(':')[2]));
                }              
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    table.AddRow(new Row(line));
                }
            }

            Tables.Add(table);
        }

        //сохраняет для работы все таблицы в БД
        public void ConnectToAllTables()
        {
            string[] tables = Directory.GetFiles(DB_name);
            for (int i=0;i<tables.Count();i++)
            {
                Table table = new Table(TableName(tables[i]));
                table.Path = tables[i];  

                using (TextReader reader = new StreamReader(tables[i]))
                {
                    string schema = reader.ReadLine();

                    foreach (string column in schema.Split('|'))
                    {
                         table.AddColumn(new Column(column.Split(':')[0], column.Split(':')[1], column.Split(':')[2]));
                    }
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        table.AddRow(new Row(line));
                    }
                }

                Tables.Add(table);
            }
        }

        //создает новую таблицу в выбранной базе
        public void Create(string Name, string schema, List<string> lines)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            folderBrowserDialog.ShowDialog();
            string Way = folderBrowserDialog.SelectedPath + "\\" + Name + ".txt";
            
            using (TextWriter writer = new StreamWriter(Way))
            {
                writer.WriteLine(schema);
                for(int i=0;i<lines.Count();i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        //возвращает все сохраненные для работы таблицы
        public List<Table> GetAllTables()
        {
            return Tables;
        }

        //возвращает все записи из таблицы с заданным именем
        public List<Row> GetAllLines(string table_name)
        {
            Table table = GetTable(table_name + ".txt");
            return table.GetRows();
        }

        //возвращает все записи, удовлетворяющие условию, из таблицы с заданным именем column- имя поля, mark- Знак(>,<,==,!=,<=,>=), value- значение
        public List<Row> Get(string table_name, string column, string mark, string value)
        {
            List<Row> Output = new List<Row>();
            Table table = GetTable(table_name + ".txt");
            List<Column> columns = table.GetColumns();
            List<Row> rows = table.GetRows();
            int column_number = 0;
            for (int i=0;i<columns.Count();i++)
            {
                if(column==columns[i].ColumnName)
                {
                    column_number = i;
                }
            }
            for (int i = 0; i < rows.Count();i++ )
            {
                if (mark == "==")
                {
                    if (rows[i].Elements[column_number] == value)
                    {
                        Output.Add(rows[i]);
                    }
                }

                if (mark == "!=")
                {
                    if (rows[i].Elements[column_number] != value)
                    {
                        Output.Add(rows[i]);
                    }
                }

                if (mark == ">")
                {
                    if (Convert.ToDouble(rows[i].Elements[column_number]) > Convert.ToDouble(value))
                    {
                        Output.Add(rows[i]);
                    }
                }

                if (mark == "<")
                {
                    if (Convert.ToDouble(rows[i].Elements[column_number]) < Convert.ToDouble(value))
                    {
                        Output.Add(rows[i]);
                    }
                }

                if (mark == ">=")
                {
                    if (Convert.ToDouble(rows[i].Elements[column_number]) >= Convert.ToDouble(value))
                    {
                        Output.Add(rows[i]);
                    }
                }

                if (mark == "<=")
                {
                    if (Convert.ToDouble(rows[i].Elements[column_number]) <= Convert.ToDouble(value))
                    {
                        Output.Add(rows[i]);
                    }
                }
            }
                return Output;
        }

        //вставляет в таблицу строки 
        public void Insert(string table_name, List<string> lines)
        {
            Table table = GetTable(table_name + ".txt");
            List<Row> rows = table.GetRows();
            for( int i=0;i<lines.Count();i++)
            {
                Row row = new Row(lines[i]);
                rows.Add(row);
            }
            table.SetRows(rows);
        }

        //вставляет в таблицу массив строк
        public void Insert(string table_name, List<Row> insert_rows)
        {
            Table table = GetTable(table_name + ".txt");
            List<Row> rows = table.GetRows();
            for (int i = 0; i < insert_rows.Count(); i++)
            {
                rows.Add(insert_rows[i]);
            }
            table.SetRows(rows);
        }

        //изменяет записи, удовлетворяющие условию, в таблице с заданным именем (set_column- полe, set_value- значение; where_column- полe условия обновения, where_mark- знак, where_value- значение условия обновления
        public void Update(string table_name, string set_column, string set_value, string where_column, string where_mark, string where_value)
        {
            Table table = GetTable(table_name + ".txt");
            List<Column> columns = table.GetColumns();
            List<Row> update_rows = Get(table_name, where_column, where_mark, where_value);
            Delete(table_name, where_column, where_mark, where_value);
            int column_number = 0;
            for (int i = 0; i < columns.Count(); i++)
            {
                if (set_column == columns[i].ColumnName)
                {
                    column_number = i;
                }
            }

            for (int i = 0; i < update_rows.Count(); i++)
            {
                update_rows[i].Elements[column_number] = set_value;
            }
            Insert(table_name, update_rows);
        }

        //удаляет записи, удовлетворяющие условию
        public void Delete(string table_name, string column, string mark, string value)
        {
            List<Row> rows_for_delete = Get(table_name, column, mark, value);
            Table table = GetTable(table_name + ".txt");
            List<Row> rows = table.GetRows();
            for (int i=0;i<rows_for_delete.Count();i++)
            {
                rows.Remove(rows_for_delete[i]);
            }
            table.SetRows(rows);
        }

        //сохраняет изменения
        public void Save()
        {
            for (int i = 0; i < Tables.Count(); i++)
            {
                using (TextWriter writer = new StreamWriter(Tables[i].Path))
                {
                    string columns = CollectColumns(Tables[i].GetColumns());
                    writer.WriteLine(columns);
                    List<string> rows = CollectRows(Tables[i].GetRows());
                    for (int j=0;j<rows.Count();j++)
                    {
                        writer.WriteLine(rows[j]);
                    }
                }
            }
        }

        
        //вспомогательный метод
        private string CollectColumns(List<Column> columns)
        {
            string Output = "";
            for (int i=0;i<columns.Count()-1;i++)
            {
                string item = columns[i].ColumnName + ":" + columns[i].Constraint + ":" + columns[i].DataType;
                Output = Output + item + "|";
            }
            string item2 = columns.Last().ColumnName + ":" + columns.Last().Constraint + ":" + columns.Last().DataType;
            Output = Output + item2;
            return Output;
        }

        //вспомогательный метод
        private List<string> CollectRows(List<Row> rows)
        {
            List<string> Output = new List<string>();
            for (int i = 0; i < rows.Count();i++ )
            {
                string item = "";
                for(int j=0;j<rows[i].Elements.Count()-1;j++)
                {
                    item = item + rows[i].Elements[j] + "|";
                }
                item = item + rows[i].Elements.Last();
                Output.Add(item);
            }
                return Output;
        }

        //вспомогательный метод
        private string TableName(string table)
        {
            string name = "";
            for (int i=table.Count()-1;i>=0;i--)
            {
                if (table[i] != '\\')
                {
                    name = table[i] + name;
                }
                else
                    break;
            }
            return name;
        }

        public class Table
        {
            public string TableName { get; set; }
            public string Path { get; set; }
            List<Column> columns = new List<Column>();
            List<Row> rows = new List<Row>();

            public Table(string tabelName)
            {
                this.TableName = tabelName;
            }

            public void AddColumn(Column column)
            {
                this.columns.Add(column);
            }

            public void AddRow(Row row)
            {
                this.rows.Add(row);
            }

            public List<Column> GetColumns()
            {
                return columns;
            }

            public List<Row> GetRows()
            {
                return rows;
            }

            public void SetRows(List<Row> rows)
            {
                this.rows = rows;
            }
        }
        public class Column
        {
            public string ColumnName { get; set; }
            public string DataType { get; set; }
            public string Constraint { get; set; }

            public Column(string columnName, string dataType, string constraint)
            {
                this.ColumnName = columnName;
                this.DataType = dataType;
                this.Constraint = constraint;
            }
        }
        public class Row
        {
            public string[] Elements { get; set; }

            public Row(string row)
            {
                this.Elements = row.Split('|');
            }
        }
        
    }
}
