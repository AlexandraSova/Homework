using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Answer;//ответ пользователя
        private string ReturnAnswer()
        {
            return Answer;
        }
       
        Controller Controller = new Controller();

        EditForm EditScenario;
        CreateForm CreateScenario;

        private int row_number = 0;//номер строки в протоколе

        private void CorrectSearchFile(string answer)//Корректность нахождения пути к файлу файла
        {
            if (Controller.CorrectSearchFile(answer) == false)
            {
                Error.Text = "Ошибка!";
                AnswerText.Text = "";
            }
            else
            {
                Referense.Visible = true;
                AnswerText.Text = "";
                Go();
            }
        }

        private void ReadFiles()//корректность чтения инфы сценария
        {
            Controller.ReadFiles();
        }

        private void IntProtocol()//коррекция
        {
            for (int i = 0; i < Controller.N; i++)
            {
                Protocol.Rows.Add();
                Protocol.AutoSizeRowsMode =
       DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void AskQuestion(string question)
        {
            QuestionText.Text = question;
        }

        public bool CorrectAnswer(int n)
        {
            bool CorrectData = false;
            Answer = AnswerText.Text;
            CorrectData = Controller.CorrectAnswer(n, Answer);
            if (CorrectData == false)
            {
                Error.Text = "Извините, такого варианта ответа нет!";
                AnswerText.Text = "";
            }
            return CorrectData;
        }

        private void Protokol(string question, string answer, int n)
        {
            if (row_number == 0)
            {
                Protocol.Rows[0].Cells["quest"].Value = question;
                Protocol.Rows[0].Cells["ans"].Value = answer;
                row_number++;
            }
            else
            {
                Protocol.Rows[row_number].Cells["quest"].Value = question;
                Protocol.Rows[row_number].Cells["ans"].Value = answer;
                row_number++;
            }
        }

        public void AskQuestions(int n, string answer)
        {
            string[] Input = Controller.AskQuestions(n, answer);
            if (Input[1]=="Close")
            {
                this.Close();
            }
            else
            {
                if(Input[2]=="Repeat")
                {
                    IntProtocol();
                    AskQuestion(Input[0]);
                }
                else
                {
                    AskQuestion(Input[0]);
                }
            }
        }

        private void Go()
        {
            Record.Visible = true;
            Protocol.Visible = true;
            DialogLabel.Text = "Ход диалога";
            Error.Text = "";
            ReferenseLabel.Text = "";
            ReferenseText.Text = "";
            QuestionLabel.Text = "Вопрос";
            ReadFiles();
            IntProtocol();
            string question = Controller.Go();
            AskQuestion(question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionLabel.Text = "Запрос системы, необходимый для начала работы:";
            QuestionText.Text = "Пожалуйста, введите сценарий,\nпо которому будем вести диалог.";
            Error.Text = "";
            ReferenseLabel.Text = "";
            ReferenseText.Text = "";
            Referense.Visible = false;
            Referense.Visible = false;
            DialogLabel.Text = "";
            Protocol.Visible = false;
            Record.Visible = false;
        }

        private void Ok_Click(object sender, EventArgs e)//коррекция
        {
            if (Controller.N==0)//коррекция
            {
                Answer = AnswerText.Text;
                CorrectSearchFile(Answer);
            }
            else
            {
                Error.Text = "";
                bool correct_answer = CorrectAnswer(Controller.Question);
                string question = Controller.ReturnOneQuestion(Controller.Question);//коррекция
                if (correct_answer)
                {
                    ReferenseLabel.Text = "";
                    ReferenseText.Text = "";
                    Answer = ReturnAnswer();
                    Protokol(question, Answer, Controller.Question);
                    AskQuestions(Controller.Question, Answer);
                    AnswerText.Text = "";
                    Controller.Question = Controller.NextQuestion;
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (EditScenario == null || EditScenario.IsDisposed)
            {
                EditScenario = new EditForm();
                EditScenario.Text = "Редактирование сценария";
                EditScenario.Show();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (CreateScenario == null || CreateScenario.IsDisposed)
            {
                CreateScenario = new CreateForm();
                CreateScenario.Text = "Cоздание сценария";
                CreateScenario.Show();
            }
        }

        private void Record_Click(object sender, EventArgs e)
        {
            int N_Rows = Protocol.Rows.Count;
            string[] ques = new string[N_Rows];
            string[] ans = new string[N_Rows];

            for (int i = 0; i < N_Rows; i++)
            {
                ques[i] = Convert.ToString(Protocol.Rows[i].Cells[0].Value);
                ans[i] = Convert.ToString(Protocol.Rows[i].Cells[1].Value);
            }
            Controller.Record(ques, ans);
            MessageBox.Show("Ход диалога успешно задокументирован.");
        }

        private void Referense_Click(object sender, EventArgs e)//написать!
        {

        }
    }
}
