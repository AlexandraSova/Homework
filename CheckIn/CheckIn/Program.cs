using CheckIn.CheckIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIn
{
    static class Program
    {
        public static ApplicationContext Context { get; set; }
        public static ApplicationController controller = new ApplicationController();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CheckInForm MainForm = new CheckInForm();
            Context = new ApplicationContext(MainForm);
            
            controller.Run<CheckInPresenter>(new CheckInPresenter(MainForm));
        }
    }
}
