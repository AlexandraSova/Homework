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
        public void ReadDialog(Dialog Dialog)
        {
            Model.Message model = new Model.Message("", "", true, "", true, "", "");
            model = model.GetFirst();
            Dialog.QuestionNum.Add(model.QuestionNum);
            Dialog.Question.Add(model.Question);
            Dialog.HasImage.Add(model.HasImage);
            Dialog.Image.Add(model.Image);
            Dialog.HasExplain.Add(model.HasExplain);
            Dialog.Explain.Add(model.Explain);
            Dialog.answers.Add(model.answers);
            Dialog.answer.Add(model.answer);

            int i = 1;
            while (true)
            {
                try
                {
                    model = model.GetNext(i);
                    Dialog.QuestionNum.Add(model.QuestionNum);
                    Dialog.Question.Add(model.Question);
                    Dialog.HasImage.Add(model.HasImage);
                    Dialog.Image.Add(model.Image);
                    Dialog.HasExplain.Add(model.HasExplain);
                    Dialog.Explain.Add(model.Explain);
                    Dialog.answers.Add(model.answers);
                    Dialog.answer.Add(model.answer);
                    i++;
                }
                catch
                {
                    break;
                }
            }
        }

        public bool SearchClient(Client Client, string Name, string Password)
        {
            string way = "clients\\clients.txt";
            string[] DataOfClient;
            bool b = false;
            using (StreamReader sr = new StreamReader(@way))
            {
                while (!sr.EndOfStream)
                {
                    string NextClient = sr.ReadLine();
                    DataOfClient = NextClient.Split('|');
                    if (Name == DataOfClient[0] && Password == DataOfClient[1])
                    {
                        Client.name = DataOfClient[0];
                        Client.password = DataOfClient[1];
                        Client.all_tests = Convert.ToInt32(DataOfClient[2]);
                        Client.last_test = Convert.ToInt32(DataOfClient[3]);
                        Client.number_of_tests = Convert.ToInt32(DataOfClient[4]);
                        b = true;
                        break;
                    }
                }
            }
            
            return b;
        }

        public Client NewClient(string Name, string Password)
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
                        Client.number_of_tests = 0;
                        b = false;
                        break;
                    }
                }
            }

            if (b)
            {
                string Data = Name + "|" + Password + "|0|0|0";
                using (StreamWriter sr = new StreamWriter(@way, true))
                {
                    sr.WriteLine(Data);
                }
                Client.name = Name;
                Client.password = Password;
                Client.all_tests = 0;
                Client.last_test = 0;
                Client.number_of_tests = 0;
            }
            return Client;
        }

        public void SaveChanges(Client Client)
        {
            string way = "clients\\clients.txt";
            string StringClient=Client.name+"|"+Client.password+"|"+Client.all_tests+"|"+Client.last_test+"|"+Client.number_of_tests;
            List<string> Clients = new List<string>();
            using (StreamReader sr = new StreamReader(@way))
            {
                while (!sr.EndOfStream)
                {
                    Clients.Add(sr.ReadLine());                    
                }
            }
            for (int i=0;i<Clients.Count();i++)
            {
                string[] DataOfClient = Clients[i].Split('|');
                if(Client.name==DataOfClient[0] && Client.password==DataOfClient[1])
                {
                    Clients.RemoveAt(i);
                    Clients.Add(StringClient);
                }
            }
            using (StreamWriter sw = new StreamWriter(@way))
            {
                for(int i=0;i<Clients.Count();i++)
                {
                    sw.WriteLine(Clients[i]);
                }
            }
        }
    }
}
