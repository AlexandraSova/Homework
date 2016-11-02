using CheckIn.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIn
{
    public partial class CheckInForm : Form, ICheckInView
    {
        public string FirstName
        {
            get { return firstname.Text; }
            set { firstname.Text = value; }
        }
        public string LastName
        {
            get { return lastname.Text; }
            set { lastname.Text = value; }
        }
        public string Mail
        {
            get { return mail.Text; }
            set { mail.Text = value; }
        }
        public string Pass1
        {
            get { return pass1.Text; }
            set { pass1.Text = value; }
        }
        public string Pass2
        {
            get { return pass2.Text; }
            set { pass2.Text = value; }
        }

        public event Action CheckIn;
        public event Action Login;
        public event Action WritePass2;
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        public void ShowPassMessage(string errorMessage)
        {
            CheckPass.Text = errorMessage;
        }
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkin_button_Click(object sender, EventArgs e)
        {
            CheckIn();
        }

        public new void Show()
        {
            Application.Run(Program.Context);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void pass2_TextChanged(object sender, EventArgs e)
        {
            WritePass2();
        }

        public int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
