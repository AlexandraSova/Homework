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

        Model.Message Question;//вопрос
        private bool End;
        Controller Controller = new Controller();
        HelloForm HelloForm;

        private void QuestionInForm(Model.Message Question)
        {
            string QuestionAll = Question.Question + "\n\n";
            if (Question.HasAnswers)
            {
                string Answers = "Варианты ответов:\n";
                for (int i = 0; i < Question.answers.Count(); i++)
                {
                    Answers = Answers + Question.answers[i].Text + "\n";
                }
                QuestionAll = QuestionAll + Answers + "\n\nВведите ответы без пробелов через точку запятой.";
            }
            QuestionLabel.Text = Question.QuestionNum;
            QuestionText.Text = QuestionAll;

            //ждет адекватного представления изображения
            /* if (has_image)
             {
                 Graphics g = Graphics.FromHwnd(this.Handle);
                 g.DrawImage(Image.FromFile(@image), new Point(20, 0));
             }*/
        }

        private void AskQuestions()
        {
            try
            {
                Question = Controller.ReturnQuestion();
                QuestionInForm(Question);
            }
            catch
            {
                EndOfTest();
                AnswerLabel.Visible = false;
                AnswerText.Visible = false;
            }
        }

        private void EndOfTest()
        {
            QuestionLabel.Text = "Поздравляю! Вы закончили тест!";
            string NumberOfTests = "Всего вы прошли " + Controller.ClientNumberOfTests() + " тестов.";
            string ThisTest = "Этот тест вы прошли с результатом " + Controller.ClientThisTest() + "%";
            string LastTest = "А предыдущий - с результатом " + Controller.ClientLastTest() + "%";
            string AllTests = "Общая статистика по всем тестам " + Controller.ClienAllTests() + "%";

            QuestionText.Text = NumberOfTests + "\n" + ThisTest + "\n" + LastTest + "\n" + AllTests;
            End = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionLabel.Text = "";
            QuestionText.Text = "";
            AnswerLabel.Visible = false;
            AnswerText.Visible = false;
            Error.Text = "";
            ReferenseLabel.Text = "";
            ReferenseText.Text = "";
            Referense.Visible = false;
            Ok.Visible = false;
            if (HelloForm == null || HelloForm.IsDisposed)
            {
                HelloForm = new HelloForm(this, Controller);
                HelloForm.Show();
            }
            End = false;
            this.AcceptButton = Ok;
        }

        private void Go_Click_1(object sender, EventArgs e)
        {
            Controller.ReadDialog();
            AnswerLabel.Visible = true;
            AnswerText.Visible = true;
            Referense.Visible = true;
            Ok.Visible = true;
            AskQuestions();
            Go.Visible = false;
            Create.Visible = false;
        }

        private void Ok_Click_1(object sender, EventArgs e)
        {
            if (!End)
            {
                string Answer = AnswerText.Text;
                bool right = false;
                List<string> RightAnswer = Controller.ReturnRightAnswer(Question);
                string[] Answer1 = Answer.Split(';');

                for (int i = 0; i < RightAnswer.Count();i++)
                {
                    if (Answer1[i] == RightAnswer[i]) right = true;
                    else right = false;
                }
                   
                Controller.WriteAnswer(right);
                Error.Text = "";
                string StringRightAnswer = Controller.RightAnswerToString(RightAnswer);
                if (right)
                {
                    Error.Text = "Правильный ответ!";
                }
                else
                {
                    Error.Text = "Неправильный ответ! (правильный: " + StringRightAnswer + ")";
                }
                AskQuestions();
                ReferenseLabel.Text = "";
                ReferenseText.Text = "";
                AnswerText.Text = "";
            }
            else
            {
                Controller.SaveChanges();
                this.Close();
            }
        }

        private void Referense_Click_1(object sender, EventArgs e)
        {

            ReferenseLabel.Text = "Справка:";
            if (Question.HasExplain)
            {
                ReferenseText.Text = Question.Explain;
            }
            else
            {
                ReferenseText.Text = "Для данного вопроса нет подсказок.";
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            QuestionsSourceController C = new QuestionsSourceController();
        }
    }
}
