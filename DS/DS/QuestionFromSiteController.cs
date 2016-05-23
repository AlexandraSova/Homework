using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Threading;
namespace DS
{

    class QuestionFromSiteController
    {

        static View view;
        static Model model;
        int[][] History; //возможно понадобится
        static int CurrentQuestion = 0;
        [STAThread]
        public void Start()
        {
            model = new Model();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            view = new View();
            EventHandler CreateDialog = new System.EventHandler(CreateDialog_Click);
            EventHandler OpenDialog = new System.EventHandler(OpenDialog_Click);
            EventHandler Settings = new System.EventHandler(Settings_Click);
            EventHandler About = new System.EventHandler(About_Click);
         //   view.Prepare(CreateDialog, OpenDialog, Settings, About);
         //   Application.Run(view);
        }


        static async void Run(Model.Message m)
        {
            CurrentQuestion++;
           // int num = await view.SetQuestion(m.question, m.GetAllAnswers()); // получить номер ответа
           // int skip = m.answers[num].next - CurrentQuestion - 1; // вычислить сколько нужно пропустить

            //действие

         //   while (!model.EOF()) // пока не конец диалога
            {
               // m = model.GetNext(skip); // получить следующее сообщение (пропустить 'skip' сообщений)
               // num = await view.SetQuestion(m.question, m.GetAllAnswers());
                //skip = m.answers[num].next - CurrentQuestion - 1;

                //действие

            }
            MessageBox.Show("Диалог окончен!");
        }

        internal static void CreateDialog_Click(object sender, EventArgs e)
        {
       //     Creator f = new Creator();
         //   f.Show();
        }

        private static void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Курсовая работа \n ст. 09 - 411 \n Губайдуллина Альберта\n Модель: Теория игр ", "О программе");
        }

        private static void Settings_Click(object sender, EventArgs e)
        {
            Form f = new Settings();
            f.Show();
        }

        private static void OpenDialog_Click(object sender, EventArgs e)
        {
            //    Model.Message m = model.GetFirst(); // получить первый вопрос
     //       Run(m);
        }
    }
}
