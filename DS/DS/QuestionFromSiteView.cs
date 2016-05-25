using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace DS
{

    public partial class QuestionFromSite : Form
    {
        public QuestionFromSite()
        {
            InitializeComponent();
        }
        private void QuestionTypeForm_Load(object sender, EventArgs e)
        {

        }
        public void Prepare(EventHandler ByHands_Click, EventHandler FromSite_Click, EventHandler BaseEditor_Click, EventHandler Settings_Click, EventHandler About_Click)
        {
            /*
            this.ByHands.Click += ByHands_Click;
            this.One.Click += FromSite_Click;
            this.All.Click += BaseEditor_Click;
            this.Settings.Click += Settings_Click;
            this.About.Click += About_Click;
        */
        }
        /*
        private void SimpleView_Click(object sender, EventArgs e)//сделано
        {
            if (NEW)
            {
                SourceBox.Visible = false;
            }
            else
            {
                if (CanSimpleViewed)
                {
                    SourceBox.Visible = false;
                }
                else
                    MessageBox.Show("Данный сценарий не может быть представлен в простом виде");
            }
        }

        private void SourceView_Click(object sender, EventArgs e)//сделано
        {
            SourceBox.Visible = true;
        }
        */

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила заполнения см. в Документации к проекту");
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {

        }

        private void SubjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

}

