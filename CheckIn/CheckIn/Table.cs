using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn
{
    public class Table
    {
        public class Column
        {
            public string Name;
            public List<string> Value;

           public Column(string name, List<string> value)
            {
                Name = name;
                Value = value;
            }
            public Column()
           {
               Name = "";
               Value = new List<string>();
           }

            public int Count()
            {
                return Value.Count();
            }
        }

        public class Row
        {
            public List<string> value;

            public Row()
            {
                value = new List<string>();
            }
            public Row(List<string> value)
            {
                this.value = value;
            }

            public int Count()
            {
                return value.Count();
            }
        }

        private List<Column> columns;
        private List<Row> rows;
        public Table()
        {
            columns = new List<Column>();
            rows = new List<Row>();
        }
        public void AddColumn(string name, List<string> value)
        {
            Column column = new Column(name, value);
            AddColumn(column);
        }

        private void AddColumnInRows(Column column)
        {
            for (int i=0;i<column.Count();i++)
            {
                rows[i].value.Add(column.Value[i]);
            }
        }

        public void AddColumn(Column column)
        {
            columns.Add(column);
                if (rows.Count() == 0)
                {
                    for (int j = 0; j < column.Count(); j++)
                    {
                        rows.Add(new Row());
                    }
                }
                AddColumnInRows(column);
        }

        public void AddRow(Row row)
        {
            rows.Add(row);
            if (columns.Count()==0)
            {
                for (int i = 0; i < row.Count(); i++)
                {
                    columns.Add(new Column());
                }
            }
            AddRowInColumns(row);
        }

        private void AddRowInColumns(Row row)
        {
            for (int i=0;i<row.Count();i++)
            {
                columns[i].Value.Add(row.value[i]);
            }
        }
        public Column GetColumn(int number)
        {
            return columns[number];
        }

        public Row GetRow(int number)
        {
            return rows[number];
        }

        public int ColumnCount()
        {
            return columns.Count();
        }

        public int RowCount()
        {
            return rows.Count();
        }
    }
}
