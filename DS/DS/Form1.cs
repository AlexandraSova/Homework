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
        private string Answer;//ответ пользователя
        private string RightAnswer;
        private string SearchRightAnswer()
        {
            string answer = "не определен";
            if (Question.answer == null)
            {
                for (int i = 0; i < Question.answers.Count(); i++)
                {
                    if (Question.answers[i].IsTrue == true)
                    {
                        int number = i;
                        answer = Question.answers[number].Text;
                        break;
                    }
                }
            }
            else
            {
                answer = Question.answer;
            }
            return answer;
        }
        private bool End;

        Controller Controller = new Controller();

        private void QuestionInForm(string question_number, string question, bool has_image, string image)
        {
            QuestionText.Text = question;
            QuestionLabel.Text = question_number;
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
                QuestionInForm(Question.QuestionNum, Question.Question, Question.HasImage, Question.Image);
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
            End = false;
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
                Answer = AnswerText.Text;
                bool right = false;
                RightAnswer = SearchRightAnswer();
                if (Answer == RightAnswer) right = true;
                Controller.WriteAnswer(right);
                Error.Text = "";
                if (right)
                {
                    Error.Text = "Правильный ответ!";
                }
                else
                {

                    Error.Text = "Неправильный ответ! (правильный: " + RightAnswer + ")";
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
    }
}
