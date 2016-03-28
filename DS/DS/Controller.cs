using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class Controller
    {
        private FilesProvider Provider = new FilesProvider();//работа с файлами
        ProbabilityModel Model = new ProbabilityModel();//вероятностная модель
        GraphModel GraphModel = new GraphModel();//Графовая модель

        public int Question;//номер текущего вопроса
        public int NextQuestion;//вопрос, на который перешли
        private string Scenario;//текущий сценарий

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

        public bool CorrectReadFiles()
        {
            bool b;
            if ((Provider.ReadQuestions() == false) || (Provider.ReadReferense() == false)
                || (Provider.ReadInfoOfQuestions() == false) || (Provider.ReadCorrectAnswers() == false))
            {
                b = false;
            }
            else
            {
                b = true;
            }
            N = Provider.Questions.Count();
            return b;
        }//корректность чтения данных сценария

        public bool CorrectAnswer(int n, string answer)//корректность ответа пользователя
        {
            bool CorrectData = false;
            List<string> CorrectAnswer = Provider.CorrectAnswers[n];
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
            List<string> next_questions = Provider.Graph[n];
            string[] Output = new string[3];
            string question = " ";
            Output[0] = question;
            Output[1] = " ";
            Output[2] = " ";
            if (Provider.type_trans[n] == 0)
            {
                Output[1] = "Close";
            }

            else
            {
                string next_one_question = Model.Select(Provider.type_trans[n], next_questions, answer, Provider);
                Random rnd = new Random();
                NextQuestion = Provider.SearchDSQuestion(next_one_question);

                if (NextQuestion != 1)
                {
                    question = Provider.ReturnOneQuestion(NextQuestion);
                    Output[0] = question;
                }
                else
                {
                    Provider.Graph = new List<List<string>>();
                    Provider.IntGraph();
                    ///IntProtocol();
                    question = Provider.ReturnOneQuestion(NextQuestion);
                    Output[0] = question;
                    Output[2] = "Repeat";
                }
            }
            return Output;
        }

        public string Go()
        {
            Provider.IntGraph();
            string question = Provider.ReturnOneQuestion(1);
            Question = 1;
            return question;
        }

        public void Record(string[] q, string[] a)
        {
            Provider.WriteProtocol(q, a);
        }

        public string ReturnOneQuestion(int x)//убратьисправить
        {
            string question = Provider.ReturnOneQuestion(x);
            return question;
        }
    }
}
