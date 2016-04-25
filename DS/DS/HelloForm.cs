using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        Controller Controller = new Controller();
        Form1 Test;

        private void HelloForm_Load(object sender, EventArgs e)
        {
            View(false);
            Ok1.Visible = false;
        }

        private void registation_Click(object sender, EventArgs e)
        {
            View(true);
            Ok1.Visible = true;
        }

        private void login_Click(object sender, EventArgs e)
        {
            View(true);
            Ok1.Visible = false;
        }

        private void View (bool b)
        {
            NameLabel.Visible = b;
            NameText.Visible = b;
            PassLabel.Visible = b;
            PassText.Visible = b;
            Ok.Visible = b;
            registation.Visible = !b;
            login.Visible = !b;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if(Controller.CheckClient(NameText.Text, PassText.Text))
            {
                if (Test == null || Test.IsDisposed)
                {
                    Test = new Form1();
                    Test.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль!");
                NameText.Text = "";
                PassText.Text = "";
            }
        }

        private void Ok1_Click(object sender, EventArgs e)
        {
            if (Controller.NewClient(NameText.Text, PassText.Text))
            {
                if (Test == null || Test.IsDisposed)
                {
                    Test = new Form1();
                    Test.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
                NameText.Text = "";
                PassText.Text = "";
            }
        }
    }
}
