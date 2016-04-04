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
        private ControllerForEditForm Controller = new ControllerForEditForm();
        private int N_Rows;//количество строк
        private int N_Columns;//количество столбцов
        private Dialog Dialog;

        private void EditForm_Load(object sender, EventArgs e)
        {
            Error.Text = "";
        }

        private void ReadData()
        {
            Controller.ReadFiles();
        }

        private void OpenScenario()
        {
            ReadData();
            Dialog = Controller.GetDialog;
            for (int i = 0; i < Dialog.Questions.Count(); i++)
            {
                Scenario.Rows.Add();
                Scenario.AutoSizeRowsMode =
       DataGridViewAutoSizeRowsMode.AllCells;
            }
            Scenario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            for (int i = 0; i < Dialog.Questions.Count(); i++)
            {
                string StringData = "";
                string StringData2 = "";
                for (int j = 0; j < Dialog.Graph[i].Count(); j++)
                {
                    if (j != (Dialog.Graph[i].Count() - 1))
                    {
                        StringData = StringData + Dialog.Graph[i][j] + ";";
                    }
                    else
                    {
                        StringData = StringData + Dialog.Graph[i][j];
                    }
                }

                for (int q = 0; q < Dialog.CorrectAnswers[i].Count(); q++)
                {
                    if (q != (Dialog.CorrectAnswers[i].Count() - 1))
                    {
                        StringData2 = StringData2 + Dialog.CorrectAnswers[i][q] + ";";
                    }
                    else
                    {
                        StringData2 = StringData2 + Dialog.CorrectAnswers[i][q];
                    }
                }

                Scenario.Rows[i].Cells[0].Value = Dialog.Questions[i];
                Scenario.Rows[i].Cells[1].Value = Dialog.type_trans[i];
                Scenario.Rows[i].Cells[2].Value = StringData;
                Scenario.Rows[i].Cells[3].Value = StringData2;
                Scenario.Rows[i].Cells[4].Value = Dialog.Referense[i];
                StringData = "";
                StringData2 = "";
            }
        }
        private void ReadTable()
        {
            for (int i = 0; i < N_Rows; i++)
            {
                Dialog.Questions.Add(Convert.ToString(Scenario.Rows[i].Cells[0].Value));
                Dialog.type_trans.Add(Convert.ToInt32(Scenario.Rows[i].Cells[1].Value));
                Dialog.GraphForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[2].Value));
                Dialog.CorrectAnswersForWrite.Add(Convert.ToString(Scenario.Rows[i].Cells[3].Value));
                Dialog.Referense.Add(Convert.ToString(Scenario.Rows[i].Cells[4].Value));
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            bool correct;
            NameScenario = ScenarioName.Text;
            correct = Controller.CorrectSearchFile(NameScenario);
            if (correct)
            {
                OpenScenario();
            }
            else
            {
                MessageBox.Show("Ошибка!");
                ScenarioName.Text = "";
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
            Controller.ClearScenario();
            ReadTable();
            Controller.WriteScenario(NameScenario, Dialog.Questions, Dialog.Referense, Dialog.CorrectAnswersForWrite, Dialog.GraphForWrite, Dialog.type_trans);
            this.Close();
            MessageBox.Show("Сценарий сохранен.");
        }
    }
}
