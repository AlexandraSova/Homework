using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    public class Controller
    {
        FilesProvider Provider = new FilesProvider();//работа с файлами
        Client Client = new Client();
        Dialog Dialog = new Dialog();
        ProbabilityModel ProbabilityModel;//вероятностная модель выбора следующего вопроса
        int RightAnswers = 0;

        public void ReadDialog()
        {
            Provider.ReadDialog(Dialog);
            ProbabilityModel = new ProbabilityModel(Dialog.Question.Count());
        }

        public Model.Message ReturnQuestion()
        {
            int n = ProbabilityModel.Select();
            Model.Message Output = Dialog.ReturnOneQuestion(n);
            return Output;
        }

        public bool CheckClient(string Name, string PassWord)
        {
            Client = Provider.SearchClient(Name, PassWord);
            if (Client.name == null) return false;
            else return true;
        }

        public bool NewClient(string Name, string PassWord)
        {
            Client = Provider.NewClient(Name, PassWord);
            if (Client.name == null) return false;
            else return true;
        }

        public void WriteAnswer(bool right)
        {
            if (right) { RightAnswers++; }
        }

        public List<string> ReturnRightAnswer(Model.Message Question)
        {
            List<string> answer = new List<string>();
            if (Question.HasAnswers==null)
            {
                for (int i = 0; i < Question.answers.Count(); i++)
                {
                    if (Question.answers[i].IsTrue == true)
                    {
                        int number = i;
                        answer.Add(Question.answers[number].Text);
                    }
                }
            }
            else
            {
                if (Question.answer == null) answer.Add("не определен");
                else answer.Add(Question.answer);
            }
            
            return answer;
        }

        public string RightAnswerToString(List<string> RightAnswer)
        {
            string RightAnswer1 = "";
            for (int i = 0; i < RightAnswer.Count() - 1; i++)
            {
                RightAnswer1 = RightAnswer1 + ", ";
            }
            return RightAnswer1 = RightAnswer1 + RightAnswer.Last();
        }

        public int ClientLastTest()
        {
            return Client.last_test;
        }

        public int ClientThisTest()
        {
            return (RightAnswers / Dialog.Question.Count()) * 100;
        }

        public int ClienAllTests()
        {
            return (ClientThisTest() + Client.all_tests) / 2;
        }

        public int ClientNumberOfTests()
        {
            return Client.number_of_tests;
        }

        public void SaveChanges()
        {
            Client.all_tests = (ClientThisTest() + Client.all_tests) / 2;
            Client.last_test = (RightAnswers / Dialog.Question.Count()) * 100;
            Client.number_of_tests++;
            Provider.SaveChanges(Client);
        }
    }
}
