using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        int N_Rows;
        int N_Columns;
        string NameScenario;
        ControllerForCreateForm Controller = new ControllerForCreateForm();
        ReferenseForm Referense;
        
        private void CreateForm_Load(object sender, EventArgs e)
        {
            Error.Text = "";
        }

        private void ReadTable()
        {
            List<string> Questions = new List<string>();
            List<int> type_trans = new List<int>();
            List<string> GraphForWrite=new List<string>();
            List<string> CorrectAnswersForWrite=new List<string>();
            List<string> Referense = new List<string>();

            for (int i = 0; i < N_Rows; i++)
            {
                Questions.Add(Convert.ToString(Scenario.Rows[i].Cells[0].Value));
                type_trans.Add(Convert.ToInt32(Scenario.Rows[i].Cells[1].Value));
                GraphForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[2].Value));
                CorrectAnswersForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[3].Value));
                Referense.Add(Convert.ToString(Scenario.Rows[i].Cells[4].Value));
            }
            Controller.WriteScenario(NameScenario, Questions, Referense, CorrectAnswersForWrite, GraphForWrite, type_trans);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            bool correct;
            NameScenario = ScenarioName.Text;
            correct = Controller.CreateNewScenario(NameScenario);
            if (correct)
            {
                Error.Text = "Название принято";
            }
            else
            {
                Error.Text = "Файл с таким именем\n уже существует!";
                ScenarioName.Text = "";
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            N_Rows = Scenario.Rows.Count - 1;
            N_Columns = Scenario.Columns.Count;
            ReadTable();
            this.Close();
            MessageBox.Show("Сценарий сохранен.");
        }

        private void Reference_Click(object sender, EventArgs e)
        {
            if (Referense == null || Referense.IsDisposed)
            {
                Referense = new ReferenseForm();
                Referense.Text = "Редактирование сценария";
                Referense.Show();
            }
        }
    }
}
