using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class Controller
    {
        FilesProvider Provider = new FilesProvider();//работа с файлами
        Dialog Dialog = new Dialog();
        Client Client = new Client();
        string Name;
        string Pass;
        int last;
        int all;
        int number;

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
            bool b = Provider.SearchClient(Client, Name, PassWord);
            Name = Client.name;
            Pass = Client.password;
            last = Client.last_test;
            all = Client.all_tests;
            number = Client.number_of_tests;
            return b;
        }

        public bool NewClient(string Name, string PassWord)
        {
            bool b = true;
            Client = Provider.NewClient(Name, PassWord);
            if (Client.name == null) b = false;
            return b;
        }

        public void WriteAnswer(bool right)
        {
            if (right) { RightAnswers++; }
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
