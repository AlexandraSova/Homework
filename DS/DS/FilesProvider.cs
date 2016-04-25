using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DS
{
    class FilesProvider
    {
        private string ScenarioNume;//Имя сценария
        private string ScenarioPapka;//папка со всеми файлами сценария
        private string Scenario;//путь к сценарию

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
        }
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
        }
        private List<string> ReadReferense()
        {
            string way = "scenarios" + ScenarioPapka + "spravka.txt";
            List<string> Referense = new List<string>();
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
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка!");
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
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            return Referense;
        }
        private List<string> ReadQuestions()
        {
            List<List<char>> questions1 = new List<List<char>>();
            string Way = "scenarios" + ScenarioPapka + "DS.txt";
            String StringData = "";//считывание файла сюда первоначально
            List<string> Questions = new List<string>();
            List<char> OneQuestion = new List<char>();
            if (ScenarioNume == "1")//костыль из-за проблемы с кодировками
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Way, Encoding.Default))
                    {
                        StringData = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Way))
                    {
                        StringData = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка!");
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
            return Questions;
        }
        private List<string> ReadInfoOfQuestions()
        {
            string way = "scenarios" + ScenarioPapka + "transitions.txt";
            String StringData = "";
            string one_number = "";
            List<string> InfoOfQuestions = new List<string>();

            if (ScenarioNume == "1")
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way, Encoding.Default))
                    {
                        StringData = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way))
                    {
                        StringData = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка");
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
            return InfoOfQuestions;
        }
        private List<List<string>> ReadCorrectAnswers()
        {
            string way = "scenarios" + ScenarioPapka + "correctanswers.txt";
            String StringData = "";
            List<string> answers = new List<string>();
            List<string> StringData2 = new List<string>();
            string one_answer = "";
            string word = "";
            List<List<string>> CorrectAnswers = new List<List<string>>();

            if (ScenarioNume == "1")
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way, Encoding.Default))
                    {
                        StringData = sr.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@way))
                    {
                        StringData = sr.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка!");
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
            return CorrectAnswers;
        }

        public void ReadDialog(Dialog Dialog)
        {
            Dialog.Questions = ReadQuestions();
            Dialog.Referense = ReadReferense();
            Dialog.InfoOfQuestions = ReadInfoOfQuestions();
            Dialog.CorrectAnswers = ReadCorrectAnswers();
            Dialog.IntGraph();
        }

        public void WriteDialog(string Name, List<string> Questions, List<string> Referense, List<string> CorrectAnswersForWrite, List<string> GraphForWrite, List<int> type_trans)
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
        }
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
        }

        public Client SearchClient(string Name, string Password)
        {
            string way = "clients\\clients.txt";
            string[] DataOfClient;
            Client Client = new Client();
            bool b = false;
            using (StreamReader sr = new StreamReader(@way, Encoding.Default))
                    {
                       while(!sr.EndOfStream)
                       {
                           string NextClient = sr.ReadLine();
                           DataOfClient = NextClient.Split('|');
                           if (Name==DataOfClient[0]&&Password==DataOfClient[1])
                           {
                               Client.name = DataOfClient[0];
                               Client.password = DataOfClient[1];
                               Client.all_tests = Convert.ToInt32(DataOfClient[2]);
                               Client.last_test = Convert.ToInt32(DataOfClient[3]);
                               b = true;
                               break;
                           }
                       }
                    }
            if (b==false)
            {
                Client.name = null;
                Client.password = null;
                Client.all_tests = 0;
                Client.last_test = 0;
            }
            return Client;     
        }

        public Client NewClient(string Name,string Password)
        {
            string way = "clients\\clients.txt";
            string[] DataOfClient;
            Client Client = new Client();
            bool b = true;

            using (StreamReader sr = new StreamReader(@way, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string NextClient = sr.ReadLine();
                    DataOfClient = NextClient.Split('|');
                    if (Name == DataOfClient[0] && Password == DataOfClient[1])
                    {
                        Client.name = null;
                        Client.password = null;
                        Client.all_tests = 0;
                        Client.last_test = 0;
                        b = false;
                        break;
                    }
                }
            }

            if (b)
            {
                string Data = Name + "|" + Password + "|0|0";
                using (StreamWriter sr = new StreamWriter(@way, true))
                {
                    sr.WriteLine(Data);
                }
                Client.name = Name;
                Client.password = Password;
                Client.all_tests = 0;
                Client.last_test = 0;
            }
            return Client;
        }
    }
}
