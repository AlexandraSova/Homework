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
    //View в принципе сама управляется со своими действиями, контроллер для правильности иерархии 
    class QuestionByUserController
    {

        static QuestionByUserView view;
        static Model model;

        static int CurrentQuestion = 0;
        [STAThread]
        public static Task<int> Start(Model m)
        {
            model = m;
            //Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
            view = new QuestionByUserView();
            
            EventHandler Settings = new System.EventHandler(Settings_Click);
            EventHandler About = new System.EventHandler(Help_Click);
            view.Prepare(Settings, About);
            view.Show();
            return new Task<int>(() => 0);
        }

        private static void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила заполнения см. в Документации к проекту");
        }

        private static void Settings_Click(object sender, EventArgs e)
        {
            Form f = new Settings();
            f.Show();
        }
        
    }
}
