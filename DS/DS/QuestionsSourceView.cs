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
using System.Threading;
namespace DS
{
    
    public partial class QuestionsSourceView : Form
    {
        public QuestionsSourceView()
        {
            InitializeComponent();
        }
        int answer = 0;
        public static EventWaitHandle END = new AutoResetEvent(false);

        public void Prepare(EventHandler ByHands_Click, EventHandler FromSite_Click, EventHandler BaseEditor_Click, EventHandler Settings_Click, EventHandler About_Click)
        {
            this.ByHands.Click += ByHands_Click;
            this.FromSite.Click += FromSite_Click;
            this.BaseEditor.Click += BaseEditor_Click;
            this.Settings.Click += Settings_Click;
            this.About.Click += About_Click;
        }
        /*
        public async Task<int> SetQuestion(string CurQuestion, string[] Answers) //стартовать асинхронно, чтобы возвращать ответ?
        {
            await Waiter();
            Protokol.Text += "ДС: " + Question.Text + '\n' + "Пользователь: " + Answer.Text + '\n';
            b = false;
            return AvaliableAnswers.SelectedIndex;
        }
        
        private void AvaliableAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Answer.Text = AvaliableAnswers.SelectedItem.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            b = true;
        }
        async Task<int> Waiter()
        {
            while (!b)
            {
                await Task.Delay(100);
            }

            return 0;
        }
        */
    }
}
