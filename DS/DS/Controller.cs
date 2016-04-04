using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class Controller
    {
        protected FilesProvider Provider = new FilesProvider();//работа с файлами
        protected ProbabilityModel Model = new ProbabilityModel();//вероятностная модель
        protected GraphModel GraphModel = new GraphModel();//Графовая модель
        protected Dialog Dialog = new Dialog();

        public int Question;//номер текущего вопроса
        public int NextQuestion;//вопрос, на который перешли
        protected string Scenario;//текущий сценарий

        public int N;

        public bool CorrectSearchFile(string answer)//Корректность нахождения пути к файлу
        {
            bool b;
            if (Provider.SearchFile(answer) == false)
            {
                b = false;
            }
            else
            {
                b = true;
                Scenario = answer;
            }
            return b;
        }

        public void ReadFiles()
        {
            Dialog.Questions = Provider.ReadQuestions();
            Dialog.Referense = Provider.ReadReferense();
            Dialog.InfoOfQuestions = Provider.ReadInfoOfQuestions();
            Dialog.CorrectAnswers = Provider.ReadCorrectAnswers();
            Dialog.IntGraph();
            N = Dialog.Questions.Count();
        }//корректность чтения данных сценария

        public bool CorrectAnswer(int n, string answer)//корректность ответа пользователя
        {
            bool CorrectData = false;
            List<string> CorrectAnswer = Dialog.CorrectAnswers[n];
            for (int i = 0; i < CorrectAnswer.Count(); i++)
            {
                if (CorrectAnswer[i] != "%")
                {
                    if (CorrectAnswer[i] == answer)
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
            return CorrectData;
        }

        public string[] AskQuestions(int n, string answer)
        {
            List<string> next_questions = Dialog.Graph[n];
            string[] Output = new string[3];
            string question = " ";
            Output[0] = question;
            Output[1] = " ";
            Output[2] = " ";
            if (Dialog.type_trans[n] == 0)
            {
                Output[1] = "Close";
            }

            else
            {
                string next_one_question = Model.Select(Dialog.type_trans[n], next_questions, answer, Dialog.Graph);
                Random rnd = new Random();
                NextQuestion = SearchDSQuestion(next_one_question);

                if (NextQuestion != 1)
                {
                    question = Dialog.ReturnOneQuestion(NextQuestion);
                    Output[0] = question;
                }
                else
                {
                    Dialog.Graph = new List<List<string>>();
                    Dialog.IntGraph();
                    ///IntProtocol();
                    question = Dialog.ReturnOneQuestion(NextQuestion);
                    Output[0] = question;
                    Output[2] = "Repeat";
                }
            }
            return Output;
        }

        public string Go()
        {
            string question = Dialog.ReturnOneQuestion(1);
            Question = 1;
            return question;
        }

        public void Record(string[] q, string[] a)
        {
            Provider.WriteProtocol(q, a);
        }

        public string ReturnOneQuestion(int x)//убратьисправить
        {
            string question = Dialog.ReturnOneQuestion(x);
            return question;
        }

        private int SearchDSQuestion(string question)
        {
            int number = 0;
            bool serach = false;
            for (int i = 0; i < Dialog.Graph.Count(); i++)
            {
                if (question == Dialog.Questions[i])
                {
                    number = i;
                    serach = true;
                }
            }
            if (serach == false)
            {

            }
            return number;
        }
    }
}
