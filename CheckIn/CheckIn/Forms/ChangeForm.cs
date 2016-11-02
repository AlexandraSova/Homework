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

namespace CheckIn.Patient
{
    public partial class ChangeForm : Form, IChangeView
    {
        public string fio
        {
            get { return fio_textBox.Text; }
            set { fio_textBox.Text = value; }
        }
        public string address
        {
            get{return  address_textBox.Text;}
            set { address_textBox.Text = value; }
        }
        public string tel
        {
            get { return tel_textBox.Text; }
            set { tel_textBox.Text = value; }
        }
        public string policy
        {
            get { return policy_textBox.Text; }
            set { policy_textBox.Text = value; }
        }
        public string passport
        {
            get { return passport_textBox.Text; }
            set { passport_textBox.Text = value; }
        }
        public string diagnosis
        {
            get
            {
                return diagnosis_comboBox.SelectedItem.ToString();

            }
            set
            {
                diagnosis_comboBox.SelectedItem = value;
            }
        }

        public List<string> diagnosis_info
        {
            set
            {
                diagnosis_comboBox.Items.AddRange(value.ToArray());
                diagnosis_comboBox.SelectedItem = value.ToArray()[0];
            }
        }
        public event Action Ok;
        public ChangeForm()
        {
            InitializeComponent();
        }
        private void ChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Ok();
        }
    }
}
