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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private string NameScenario;
        private FilesProvider Provider = new FilesProvider();
        int N_Rows;//количество строк
        int N_Columns;//количество столбцов

        private void EditForm_Load(object sender, EventArgs e)
        {
            Error.Text = "";
        }

        private void ReadData()
        {
            Provider.ReadQuestions();
            Provider.ReadInfoOfQuestions();
            Provider.ReadCorrectAnswers();
            Provider.ReadReferense();
            Provider.IntGraph();
        }
        private void OpenScenario()
        {
            ReadData();
            for (int i = 0; i < Provider.Questions.Count(); i++)
            {
                Scenario.Rows.Add();
                Scenario.AutoSizeRowsMode =
       DataGridViewAutoSizeRowsMode.AllCells;
            }
            Scenario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            for (int i = 0; i < Provider.Questions.Count(); i++)
            {
                string StringData = "";
                string StringData2 = "";
                for (int j = 0; j < Provider.Graph[i].Count(); j++)
                {
                    if (j != (Provider.Graph[i].Count() - 1))
                    {
                        StringData = StringData + Provider.Graph[i][j] + ";";
                    }
                    else
                    {
                        StringData = StringData + Provider.Graph[i][j];
                    }
                }

                for (int q = 0; q < Provider.CorrectAnswers[i].Count(); q++)
                {
                    if (q != (Provider.CorrectAnswers[i].Count() - 1))
                    {
                        StringData2 = StringData2 + Provider.CorrectAnswers[i][q] + ";";
                    }
                    else
                    {
                        StringData2 = StringData2 + Provider.CorrectAnswers[i][q];
                    }
                }

                Scenario.Rows[i].Cells[0].Value = Provider.Questions[i];
                Scenario.Rows[i].Cells[1].Value = Provider.type_trans[i];
                Scenario.Rows[i].Cells[2].Value = StringData;
                Scenario.Rows[i].Cells[3].Value = StringData2;
                Scenario.Rows[i].Cells[4].Value = Provider.Referense[i];
                StringData = "";
                StringData2 = "";
            }
        }
        private void ReadTable()
        {
            for (int i = 0; i < N_Rows; i++)
            {
                Provider.Questions.Add(Convert.ToString(Scenario.Rows[i].Cells[0].Value));
                Provider.type_trans.Add(Convert.ToInt32(Scenario.Rows[i].Cells[1].Value));
                Provider.GraphForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[2].Value));
                Provider.CorrectAnswersForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[3].Value));
                Provider.Referense.Add(Convert.ToString(Scenario.Rows[i].Cells[4].Value));
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            bool correct;
            NameScenario = ScenarioName.Text;
            correct = Provider.SearchFile(NameScenario);
            if (correct)
            {
                OpenScenario();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

            int selRowNum = Scenario.SelectedCells[0].RowIndex;

            try
            {
                Scenario.Rows.Insert(selRowNum + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Строка не выбрана!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int selRowNum = Scenario.SelectedCells[0].RowIndex;
            try
            {
                Scenario.Rows.RemoveAt(selRowNum);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Поле пусто!");
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            N_Rows = Scenario.Rows.Count - 1;
            N_Columns = Scenario.Columns.Count;
            Provider.ClearScenario();
            ReadTable();
            Provider.WriteScenario(this.NameScenario);
            this.Close();
            MessageBox.Show("Сценарий сохранен.");
        }
    }
}
