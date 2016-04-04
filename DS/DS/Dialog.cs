using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class Dialog
    {
        public List<string> Questions = new List<string>();//вопросы сценария
        public List<string> Referense = new List<string>();//справка
        public List<string> InfoOfQuestions = new List<string>();//информация по каждому из вопросов
        public List<List<string>> CorrectAnswers = new List<List<string>>();//корректные ответы
        public List<List<string>> Graph = new List<List<string>>();//следующие вопросы
        public List<int> type_trans = new List<int>();//типы переходов

        public List<string> CorrectAnswersForWrite = new List<string>();//для записи в файл
        public List<string> GraphForWrite = new List<string>();//граф для записи в файл

        public void IntGraph()
        {
            string r = "";
            string StringData = "";
            List<char> OneQuestion = new List<char>();
            List<string> ListNumber = new List<string>();

            for (int i = 0; i < InfoOfQuestions.Count(); i++)
            {
                r = Convert.ToString(InfoOfQuestions[i][0]);
                type_trans.Add(Convert.ToInt32(r));

                for (int j = 2; j < InfoOfQuestions[i].Count(); j++)
                {
                    if (InfoOfQuestions[i][j] != ';')
                    {
                        OneQuestion.Add(InfoOfQuestions[i][j]);
                    }
                    else
                    {
                        for (int q = 0; q < OneQuestion.Count(); q++)
                        {
                            StringData = StringData + OneQuestion[q];
                        }
                        ListNumber.Add(StringData);
                        StringData = "";
                        OneQuestion = new List<char>();
                    }
                }
                Graph.Add(ListNumber);
                ListNumber = new List<string>();
            }
        }
        public string ReturnOneQuestion(int i)
        {
            return Questions[i];
        }
        public void ClearScenario()
        {
            Questions.Clear();
            CorrectAnswersForWrite.Clear();
            Referense.Clear();
            type_trans.Clear();
            GraphForWrite.Clear();
        }
    }
}
