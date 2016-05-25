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

namespace DS
{

    public partial class QuestionByUserView : Form
    {
        bool NEW = true;
        bool CanSimpleViewed = true;
        int CurrentQuuestion = 0;
        //TODO СДЕЛАТЬ, наконец
        // быть может стоит вынести сохранение в другой класс. УТОЧНИТЬ 
        // и вообще много чего вынести в контроллер, слишком толстое представление
        public QuestionByUserView()
        {
            InitializeComponent();
        }

        private void QuestionTypeForm_Load(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            AnswerLabel.Visible = false;
            CorrectAnswerBox.Visible = false;
            AnswersGrid.Visible = false;
            ImageSelectionLabel.Visible = false;
            ImageDirectoryBox.Visible = false;
            ImageSelectionButton.Visible = false;

            CorrectAnswerBox.Clear();
            ExplanationBox.Clear();
            ImageDirectoryBox.Clear();
            QuestionBox.Clear();
            AnswersGrid.Rows.Clear();
            Update();
        }
        public void Prepare(EventHandler Settings_Click, EventHandler Help_Click)
        {
            this.Settings.Click += Settings_Click;
            this.Help.Click += Help_Click;
        }

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

        private void NextQuestion_Click(object sender, EventArgs e)//КАК?
        {
            if (QuestionBox.Text.Length != 0)
            {
                if (IsAnswerExistBox.SelectedIndex == 0)
                {
                    int Length = AnswersGrid.Rows.Count;
                    string[] Cell1 = new string[Length], Cell2 = new string[Length];
                    for (int z = 0; z < Length - 1; z++)
                    {
                        Cell1[z] = Convert.ToString(AnswersGrid.Rows[z].Cells[0].Value);
                        if (Convert.ToString(AnswersGrid.Rows[z].Cells[1].Value) == "Да")
                        {
                            Cell2[z] = "true";
                        }
                        else
                            Cell2[z] = "false";
                    }
                    SourceBox.Text += Memory.Save(CurrentQuuestion, QuestionNum.Text, QuestionBox.Text, ImageDirectoryBox.Text, ExplanationBox.Text, Cell1, Cell2);
                }
                else
                    SourceBox.Text += Memory.Save(CurrentQuuestion, QuestionNum.Text, QuestionBox.Text, ImageDirectoryBox.Text, ExplanationBox.Text, CorrectAnswerBox.Text);
                CurrentQuuestion++;
                Clean();
            }

        }
        private void NewDialog_Click(object sender, EventArgs e)//сделано
        {
            SourceBox.Clear();
            QuestionBox.Clear();
            AnswersGrid.Rows.Clear();
            NEW = true;
        }

        private void EditDialog_Click(object sender, EventArgs e)//сделано
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "KUR|*.kur";
                openFileDialog1.Title = "Select a kur File";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    System.IO.StreamReader file = new System.IO.StreamReader(path, Encoding.Default);
                    SourceBox.Text = file.ReadToEnd();
                    file.Close();
                    NEW = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }


        private void OK_Click(object sender, EventArgs e)//сделано
        {

            if (SourceBox.Text.Length != 0&& SourceBox.Visible)
                Memory.Save(CurrentQuuestion, SourceBox.Text);
            else
            {
                if (QuestionBox.Text.Length != 0)
                    NextQuestion_Click(sender, e);
            }
            Memory.SaveFile(CurrentQuuestion);
            this.Close();
        }

        private void IsAnswerExistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnswerLabel.Visible = true;
            if (IsAnswerExistBox.SelectedIndex == 0)
            {
                CorrectAnswerBox.Visible = false;
                AnswersGrid.Visible = true;
            }
            else
            {
                CorrectAnswerBox.Visible = true;
                AnswersGrid.Visible = false;
            }
        }

        private void IsImageExistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsImageExistBox.SelectedIndex == 0)
            {
                ImageSelectionLabel.Visible = true;
                ImageDirectoryBox.Visible = true;
                ImageSelectionButton.Visible = true;
            }
            else
            {
                ImageSelectionLabel.Visible = false;
                ImageDirectoryBox.Visible = false;
                ImageSelectionButton.Visible = false;
            }
        }

        private void ImageSelectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "JPG |*.jpg| BMP |*.bmp| GIF|*.gif| PNG |*.png| TIFF|*.tiff| ICO|*.ico| Все файлы | *.*";
                openFileDialog1.Title = "Select an image";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageDirectoryBox.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
    }

}

