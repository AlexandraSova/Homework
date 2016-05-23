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

  /*  class QuestionsSourceController
    {
        static QuestionByUserController ByHandsController;
        static QuestionFromSiteController FromSiteController;

        static QuestionsSourceView view;
        static Model model;

        int[][] History; //возможно понадобится
        static int CurrentQuestion = 0;
        [STAThread]
        public static void Main()
        {
            model = new Model();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            view = new QuestionsSourceView();

            EventHandler ByHands = new System.EventHandler(ByHands_Click);
            EventHandler FromSite = new System.EventHandler(FromSite_Click);
            EventHandler BaseEditor = new System.EventHandler(BaseEditor_Click);
            EventHandler Settings = new System.EventHandler(Settings_Click);
            EventHandler About = new System.EventHandler(About_Click);
            view.Prepare(ByHands, FromSite, BaseEditor, Settings, About);
            Application.Run(view);
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

        private static async void OpenDialog_Click(object sender, EventArgs e)
        {
           // Model.Message m = model.GetFirst(); // получить первый вопрос
            //Run(m);
        }
        private static async void ByHands_Click(object sender, EventArgs e)
        {
            if (ByHandsController == null)
                ByHandsController = new QuestionByUserController();
            await QuestionByUserController.Start(model);
            //await QuestionByUserController.Start();
            //Form f = new QuestionByUserView();
            //f.Show();
        }
        private static async void FromSite_Click(object sender, EventArgs e)
        {

            if (FromSiteController == null)
                FromSiteController = new QuestionFromSiteController();
          //  await FromSiteController.Start(model);
            //await QuestionByUserController.Start();
            //Form f = new QuestionByUserView();
            //f.Show();
        }
        private static async void BaseEditor_Click(object sender, EventArgs e)
        {
            if (ByHandsController == null)
                ByHandsController = new QuestionByUserController();
          //  await ByHandsController.Start(model);
            //Form f = new QuestionByUserView();
            //f.Show();
        }
    }*/
}
