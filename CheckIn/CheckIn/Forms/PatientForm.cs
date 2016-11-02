using CheckIn.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIn
{
    public partial class PatientForm : Form, IPatientView
    {
        private Table TableInfo;
        private List<string> DiagnosisInfo;

        public event Action ShowPatients;
        public event Action Add;
        public event Action Change;
        public event Action Delete;
        public Table table_info
        {
            set
            {
                TableInfo = value;
            }
        }
        public List<string> diagnosis_info
        {
            set { DiagnosisInfo = value; }
        }

        public string fio
        {
            get { return Convert.ToString(Patient_table.SelectedRows[0].Cells[0].Value); }
        }
        public string address
        {
            get { return Convert.ToString(Patient_table.SelectedRows[0].Cells[1].Value); }
        }
        public string tel
        {
            get { return Convert.ToString(Patient_table.SelectedRows[0].Cells[2].Value); }
        }
        public string policy
        {
            get { return Convert.ToString(Patient_table.SelectedRows[0].Cells[3].Value); }
        }
        public string passport
        {
            get
            {
                return Convert.ToString(Patient_table.SelectedRows[0].Cells[4].Value);
            }
        }
        public string diagnosis
        {
            get { return Convert.ToString(Patient_table.SelectedRows[0].Cells[5].Value); }
        }
        public string selected_diagnosis
        {
            get { return diagnosis_combo.SelectedItem.ToString(); }
        }
        public bool selected_row
        {
            get
            {
                if (Patient_table.SelectedRows.Count == 0)
                    return false;
                else return true;
            }
        }
        public PatientForm()
        {
            InitializeComponent();
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            ShowTable(TableInfo);
            diagnosis_combo.Items.AddRange(DiagnosisInfo.ToArray());
            diagnosis_combo.SelectedItem = DiagnosisInfo.ToArray()[0];
        }

        public new void Show()
        {
            Program.Context.MainForm = this;//сделать эту форму главной
            Program.Context.MainForm.Show(); //открыть главную форму
        }
        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void ShowTable(Table table)
        {
            Patient_table.Columns.Clear();
            for (int i = 0; i < table.ColumnCount(); i++)
            {
                Patient_table.Columns.Add(new DataGridViewTextBoxColumn());
                Table.Column column = table.GetColumn(i);
                Patient_table.Columns[i].HeaderText = column.Name;
            }

            for (int j = 0; j < table.RowCount(); j++)
            {
                Patient_table.Rows.Add(1);
                Table.Row row = table.GetRow(j);
                for (int q = 0; q < row.Count(); q++)
                {
                    Patient_table.Rows[j].Cells[q].Value = row.value[q];
                }
            }
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error);
        }
        private void ok_Click(object sender, EventArgs e)
        {
            ShowPatients();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
