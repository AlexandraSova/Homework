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
        FilesProvider Provider = new FilesProvider();
        ReferenseForm Referense;
        
        private void CreateForm_Load(object sender, EventArgs e)
        {
            Error.Text = "";
        }

        private void ReadTable()
        {
            for (int i = 0; i < N_Rows; i++)
            {
                Provider.Questions.Add(Convert.ToString(Scenario.Rows[i].Cells[0].Value));
                Provider.type_trans.Add(Convert.ToInt32(Scenario.Rows[i].Cells[2].Value));
                Provider.GraphForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[3].Value));
                Provider.CorrectAnswersForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[4].Value));
                Provider.Referense.Add(Convert.ToString(Scenario.Rows[i].Cells[5].Value));
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            bool correct;
            NameScenario = ScenarioName.Text;
            correct = Provider.CreateNewScenarioFiles(NameScenario);
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
            Provider.ClearScenario();
            ReadTable();
            Provider.WriteScenario(NameScenario);
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
