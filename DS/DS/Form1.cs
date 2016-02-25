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
        private FilesProvider Provider = new FilesProvider();//работа с файлами
        ProbabilityModel Model = new ProbabilityModel();//вероятностная модель

        EditForm EditScenario;
        CreateForm CreateScenario;

        public int Question;//номер текущего вопроса
        public int NextQuestion;//вопрос, на который перешли
        private string Scenario;//текущий сценарий

        private int ChoiseOrProcessForOk;//переключалка для двух функций кнопки ок, надо придумать что-то получше
        private int row_number = 0;//номер строки в протоколе

        private void Choise(string answer)//Корректность чтения файла
        {
            if (Provider.SearchFile(answer) == false)
            {
                Error.Text = "Ошибка!";
                AnswerText.Text = "";
            }
            else
            {
                Referense.Visible = true;
                AnswerText.Text = "";
                ChoiseOrProcessForOk = 2;
                Scenario = answer;
                Go();
            }
        }

        private void CorrectReadQuestions()
        {
            if (Provider.ReadQuestions() == false)
            {
                Error.Text = "Не могу прочитать файл с вопросами!";
            }
        }

        private void CorrectReadReferense()
        {
            if (Provider.ReadReferense() == false)
            {
                Error.Text = "Не могу прочитать файл со справкой!";
            }
        }

        private void CorrectReadInfoOfQuestions()
        {
            if (Provider.ReadInfoOfQuestions() == false)
            {
                Error.Text = "Не могу прочитать файл!";
            }
        }

        private void CorrectReadCorrectAnswers()
        {
            if (Provider.ReadCorrectAnswers() == false)
            {
                Error.Text = "Не могу прочитать файл!";
            }
        }

        private void IntProtocol()
        {
            for (int i = 0; i < Provider.Questions.Count(); i++)
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
            List<string> CorrectAnswer = Provider.CorrectAnswers[n];
            for (int i = 0; i < CorrectAnswer.Count(); i++)
            {
                if (CorrectAnswer[i] != "%")
                {
                    if (CorrectAnswer[i] == Answer)
                    {
                        CorrectData = true;
                        break;
                    }
                }
                else
                {
                    CorrectData = true;
                }
            }
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
            List<string> next_questions = Provider.Graph[n];

            if (Provider.type_trans[n] == 0)
            {
                this.Close();
            }
            else
            {
                string next_one_question = Model.Select(Provider.type_trans[n], next_questions, answer, Provider);
                Random rnd = new Random();
                string question = "";
                bool x = false;
                NextQuestion = Provider.SearchDSQuestion(next_one_question);
                if (next_one_question == "Стоимость")
                {
                    question = "Стоимость проекта составит " + rnd.Next(1000, 10000) + "р, " + "коэффициент качества " + rnd.Next(0, 100) + "%.";
                    x = true;
                }

                if (NextQuestion != 1)
                {
                    if (x == false)
                    {
                        question = Provider.ReturnOneQuestion(NextQuestion);
                        AskQuestion(question);
                    }
                    else
                    {
                        AskQuestion(question);
                    }
                }
                else
                {
                    Provider.Graph = new List<List<string>>();
                    Provider.IntGraph();
                    IntProtocol();
                    question = Provider.ReturnOneQuestion(NextQuestion);
                    AskQuestion(question);
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
            CorrectReadQuestions();
            CorrectReadReferense();
            CorrectReadInfoOfQuestions();
            CorrectReadCorrectAnswers();
            Provider.IntGraph();
            IntProtocol();
            string question = Provider.ReturnOneQuestion(1);
            Question = 1;
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
            ChoiseOrProcessForOk = 1;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (ChoiseOrProcessForOk == 1)
            {
                Answer = AnswerText.Text;
                Choise(Answer);
            }
            else
            {
                Error.Text = "";
                bool correct_answer = CorrectAnswer(Question);
                string question = Provider.ReturnOneQuestion(Question);
                if (correct_answer)
                {
                    ReferenseLabel.Text = "";
                    ReferenseText.Text = "";
                    Answer = ReturnAnswer();
                    Protokol(question, Answer, Question);
                    AskQuestions(Question, Answer);
                    AnswerText.Text = "";
                    Question = NextQuestion;
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
            Random rnd = new Random();
            string[] ques = new string[N_Rows];
            string[] ans = new string[N_Rows];
            for (int i = 0; i < N_Rows; i++)
            {
                ques[i] = Convert.ToString(Protocol.Rows[i].Cells[0].Value);
                ans[i] = Convert.ToString(Protocol.Rows[i].Cells[1].Value);
            }
            string path = "scenarios\\" + Scenario + "_protokol.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                path = "scenarios\\" + Scenario + "_protokol" + rnd.Next(0, 10000) + ".txt";
                File.Create(path).Close();
            }

            StreamWriter output = new StreamWriter(path);
            for (int i = 0; i < ques.Count(); i++)
            {
                output.Write("Вопрос: " + ques[i] + " ");
                output.WriteLine("Ответ: " + ans[i]);
            }
            output.Close();
            MessageBox.Show("Ход диалога успешно задокументирован.");

        }
    }
}
