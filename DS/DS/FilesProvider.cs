using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DS
{
    class FilesProvider
    {//то, что помечено, как оставит, оставить здесь, остальное будет перенесено в контроллер(?)
        private string ScenarioNume;//Имя сценария
        private string ScenarioPapka;//папка со всеми файлами сценария
        private string Scenario;//путь к сценарию
        public List<string> Questions = new List<string>();//вопросы сценария
        public List<string> Referense = new List<string>();//справка
        public List<string> InfoOfQuestions = new List<string>();//информация по каждому из вопросов
        public List<List<string>> CorrectAnswers = new List<List<string>>();//корректные ответы
        public List<string> CorrectAnswersForWrite = new List<string>();//для записи в файл
        public List<List<string>> Graph = new List<List<string>>();//следующие вопросы
        public List<string> GraphForWrite = new List<string>();//граф для записи в файл
        public List<int> type_trans = new List<int>();//типы переходов

        public void DeleteNumbers(string number)
        {
            for (int i = 0; i < Graph.Count(); i++)
            {
                Graph[i].Remove(number);
            }
        }

        public int SearchDSQuestion(string question)
        {
            int number = 0;
            bool serach = false;
            for (int i = 0; i < Graph.Count(); i++)
            {
                if (question == Questions[i])
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

        public void WriteProtocol(string[] ques, string[] ans)
        {
            Random rnd = new Random();
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
        }//оставить
        public bool SearchFile(string answer)
        {
            string Way = "";
            bool SearchFiles = false;
            string[] Files = Directory.GetFiles(@"scenarios");
            string Name = "scenarios\\" + answer + ".txt";
            for (int i = 0; i < Files.Count(); i++)
            {
                if (Name == Files[i])
                {
                    SearchFiles = true;
                }
            }
            if (SearchFiles)
            {
                ScenarioNume = answer;
                Scenario = Name;
                try
                {
                    using (StreamReader sr = new StreamReader(Name, Encoding.Default))
                    {
                        Way = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    SearchFiles = true;
                }

                ScenarioPapka = Way;
            }
            return SearchFiles;
        }//оставить
        public bool ReadReferense()
        {
            string way = "scenarios" + ScenarioPapka + "spravka.txt";
            bool b = false;
            if (ScenarioNume == "1")
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way, Encoding.Default))
                    {
                        while (sr.Peek() >= 0)
                        {
                            Referense.Add(sr.ReadLine());
                        }
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = false;
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way))
                    {
                        while (sr.Peek() >= 0)
                        {
                            Referense.Add(sr.ReadLine());
                        }
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = true;
                }
            }
            return b;
        }//оставить
        public bool ReadQuestions()
        {
            List<List<char>> questions1 = new List<List<char>>();
            string Way = "scenarios" + ScenarioPapka + "DS.txt";
            String StringData = "";//считывание файла сюда первоначально
            bool b = false;
            List<char> OneQuestion = new List<char>();
            if (ScenarioNume == "1")//костыль из-за проблемы с кодировками
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Way, Encoding.Default))
                    {
                        StringData = sr.ReadToEnd();
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = false;
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Way))
                    {
                        StringData = sr.ReadToEnd();
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = false;
                }
            }
            for (int i = 0; i < StringData.Count(); i++)
            {
                if (StringData[i] != '*')
                {
                    OneQuestion.Add(StringData[i]);
                }
                else
                {
                    questions1.Add(OneQuestion);
                    OneQuestion = new List<char>();
                }
            }
            StringData = "";
            for (int i = 0; i < questions1.Count(); i++)
            {
                for (int j = 0; j < questions1[i].Count(); j++)
                {
                    StringData = StringData + questions1[i][j];
                }
                Questions.Add(StringData);
                StringData = "";
            }
            return b;
        }//оставить
        public bool ReadInfoOfQuestions()
        {
            string way = "scenarios" + ScenarioPapka + "transitions.txt";
            String StringData = "";
            string one_number = "";
            bool b = false;

            if (ScenarioNume == "1")
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way, Encoding.Default))
                    {
                        StringData = sr.ReadToEnd();
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = false;
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way))
                    {
                        StringData = sr.ReadToEnd();
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = false;
                }
            }
            for (int i = 0; i < StringData.Count(); i++)
            {
                if (StringData[i] != '*')
                {
                    one_number = one_number + StringData[i];
                }
                else
                {
                    InfoOfQuestions.Add(one_number);
                    one_number = "";
                }
            }
            return b;
        }//оставить
        public bool ReadCorrectAnswers()
        {
            string way = "scenarios" + ScenarioPapka + "correctanswers.txt";
            String StringData = "";
            List<string> answers = new List<string>();
            List<string> StringData2 = new List<string>();
            string one_answer = "";
            string word = "";
            bool b = false;

            if (ScenarioNume == "1")
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way, Encoding.Default))
                    {
                        StringData = sr.ReadLine();
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = false;
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way))
                    {
                        StringData = sr.ReadLine();
                        b = true;
                    }
                }
                catch (Exception e)
                {
                    b = false;
                }
            }
            for (int i = 0; i < StringData.Count(); i++)
            {
                if (StringData[i] != '*')
                {
                    one_answer = one_answer + StringData[i];
                }
                else
                {
                    StringData2.Add(one_answer);
                    one_answer = "";
                }
            }
            for (int i = 0; i < StringData2.Count(); i++)
            {
                for (int j = 0; j < StringData2[i].Count(); j++)
                {
                    if (StringData2[i][j] != ';')
                    {
                        word = word + StringData2[i][j];
                    }
                    else
                    {
                        answers.Add(word);
                        word = "";
                    }
                }
                CorrectAnswers.Add(answers);
                answers = new List<string>();
            }
            return b;
        }//оставить
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
        public void WriteScenario(string Name)
        {
            string way1 = "scenarios\\" + Name + "_correctanswers.txt";
            string way2 = "scenarios\\" + Name + "_DS.txt";
            string way3 = "scenarios\\" + Name + "_spravka.txt";
            string way4 = "scenarios\\" + Name + "_transitions.txt";

            StreamWriter output2 = new StreamWriter(way2);
            for (int i = 0; i < Questions.Count(); i++)
            {
                output2.Write(Questions[i]);
                output2.Write("*");
            }
            output2.Close();

            StreamWriter output1 = new StreamWriter(way1);
            for (int i = 0; i < CorrectAnswersForWrite.Count(); i++)
            {
                output1.Write(CorrectAnswersForWrite[i]);
                output1.Write(";");
                output1.Write("*");
            }
            output1.Close();

            StreamWriter output3 = new StreamWriter(way3);
            for (int i = 0; i < Referense.Count(); i++)
            {
                output3.WriteLine(Referense[i]);
            }
            output3.Close();

            StreamWriter output4 = new StreamWriter(way4);
            for (int i = 0; i < GraphForWrite.Count(); i++)
            {
                output4.Write(";");
                output4.Write(type_trans[i]);
                output4.Write(";");
                output4.Write(GraphForWrite[i]);
                output4.Write(";");
                output4.Write("*");
            }
            output4.Close();
        }//оставить
        public bool CreateNewScenarioFiles(string Name)
        {
            string path = "scenarios\\" + Name + ".txt";
            string text = Name;
            bool correct = false;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                correct = true;

            }
            else
            {
                correct = false;
            }
            if (correct)
            {
                string way1 = "scenarios\\" + Name + "_correctanswers.txt";
                string way2 = "scenarios\\" + Name + "_DS.txt";
                string way3 = "scenarios\\" + Name + "_spravka.txt";
                string way4 = "scenarios\\" + Name + "_transitions.txt";

                File.Create(way1).Close();
                File.Create(way2).Close();
                File.Create(way3).Close();
                File.Create(way4).Close();

                StreamWriter output = new StreamWriter(path);
                output.Write(@"\" + text + "_");
                output.Close();

                correct = true;

            }
            return correct;
        }//оставить
    }
}
