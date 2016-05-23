namespace DS
{
    partial class QuestionByUserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AnswersGrid = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTrue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OKButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeOfView = new System.Windows.Forms.ToolStripMenuItem();
            this.SimpleView = new System.Windows.Forms.ToolStripMenuItem();
            this.SourceView = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.IsAnswerExistBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CorrectAnswerBox = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IsImageExistBox = new System.Windows.Forms.ComboBox();
            this.ImageSelectionLabel = new System.Windows.Forms.Label();
            this.ImageDirectoryBox = new System.Windows.Forms.TextBox();
            this.ImageSelectionButton = new System.Windows.Forms.Button();
            this.QuestionBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SourceBox = new System.Windows.Forms.RichTextBox();
            this.ExplanationBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.QuestionNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите  вопрос и ответы";
            // 
            // AnswersGrid
            // 
            this.AnswersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnswersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Answer,
            this.IsTrue});
            this.AnswersGrid.Location = new System.Drawing.Point(341, 189);
            this.AnswersGrid.Name = "AnswersGrid";
            this.AnswersGrid.Size = new System.Drawing.Size(417, 200);
            this.AnswersGrid.TabIndex = 3;
            this.AnswersGrid.Visible = false;
            // 
            // Answer
            // 
            this.Answer.FillWeight = 250F;
            this.Answer.HeaderText = "Ответ";
            this.Answer.Name = "Answer";
            this.Answer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Answer.Width = 270;
            // 
            // IsTrue
            // 
            this.IsTrue.HeaderText = "Правильный";
            this.IsTrue.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.IsTrue.Name = "IsTrue";
            this.IsTrue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsTrue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsTrue.Width = 80;
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OKButton.Location = new System.Drawing.Point(635, 423);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(123, 48);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "Готово";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OK_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NextQuestionButton.Location = new System.Drawing.Point(506, 423);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(123, 48);
            this.NextQuestionButton.TabIndex = 5;
            this.NextQuestionButton.Text = "Следующий вопрос";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDialog,
            this.EditDialog,
            this.Save,
            this.TypeOfView,
            this.Settings,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewDialog
            // 
            this.NewDialog.Name = "NewDialog";
            this.NewDialog.Size = new System.Drawing.Size(57, 20);
            this.NewDialog.Text = "Новый";
            this.NewDialog.Click += new System.EventHandler(this.NewDialog_Click);
            // 
            // EditDialog
            // 
            this.EditDialog.Name = "EditDialog";
            this.EditDialog.Size = new System.Drawing.Size(66, 20);
            this.EditDialog.Text = "Открыть";
            this.EditDialog.Click += new System.EventHandler(this.EditDialog_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 20);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.OK_Click);
            // 
            // TypeOfView
            // 
            this.TypeOfView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimpleView,
            this.SourceView});
            this.TypeOfView.Name = "TypeOfView";
            this.TypeOfView.Size = new System.Drawing.Size(39, 20);
            this.TypeOfView.Text = "Вид";
            // 
            // SimpleView
            // 
            this.SimpleView.Name = "SimpleView";
            this.SimpleView.Size = new System.Drawing.Size(154, 22);
            this.SimpleView.Text = "Простой";
            this.SimpleView.Click += new System.EventHandler(this.SimpleView_Click);
            // 
            // SourceView
            // 
            this.SourceView.Name = "SourceView";
            this.SourceView.Size = new System.Drawing.Size(154, 22);
            this.SourceView.Text = "Расширенный";
            this.SourceView.Click += new System.EventHandler(this.SourceView_Click);
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(79, 20);
            this.Settings.Text = "Настройки";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(65, 20);
            this.Help.Text = "Справка";
            // 
            // IsAnswerExistBox
            // 
            this.IsAnswerExistBox.FormattingEnabled = true;
            this.IsAnswerExistBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.IsAnswerExistBox.Location = new System.Drawing.Point(16, 95);
            this.IsAnswerExistBox.Name = "IsAnswerExistBox";
            this.IsAnswerExistBox.Size = new System.Drawing.Size(238, 21);
            this.IsAnswerExistBox.TabIndex = 7;
            this.IsAnswerExistBox.SelectedIndexChanged += new System.EventHandler(this.IsAnswerExistBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наличие вариантов ответа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(337, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вопрос:";
            // 
            // CorrectAnswerBox
            // 
            this.CorrectAnswerBox.Location = new System.Drawing.Point(341, 186);
            this.CorrectAnswerBox.Name = "CorrectAnswerBox";
            this.CorrectAnswerBox.Size = new System.Drawing.Size(417, 20);
            this.CorrectAnswerBox.TabIndex = 10;
            this.CorrectAnswerBox.Visible = false;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AnswerLabel.Location = new System.Drawing.Point(341, 163);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(174, 20);
            this.AnswerLabel.TabIndex = 11;
            this.AnswerLabel.Text = "Правильный ответ:";
            this.AnswerLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Наличие картинки";
            // 
            // IsImageExistBox
            // 
            this.IsImageExistBox.FormattingEnabled = true;
            this.IsImageExistBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.IsImageExistBox.Location = new System.Drawing.Point(16, 171);
            this.IsImageExistBox.Name = "IsImageExistBox";
            this.IsImageExistBox.Size = new System.Drawing.Size(238, 21);
            this.IsImageExistBox.TabIndex = 12;
            this.IsImageExistBox.SelectedIndexChanged += new System.EventHandler(this.IsImageExistBox_SelectedIndexChanged);
            // 
            // ImageSelectionLabel
            // 
            this.ImageSelectionLabel.AutoSize = true;
            this.ImageSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ImageSelectionLabel.Location = new System.Drawing.Point(12, 218);
            this.ImageSelectionLabel.Name = "ImageSelectionLabel";
            this.ImageSelectionLabel.Size = new System.Drawing.Size(174, 20);
            this.ImageSelectionLabel.TabIndex = 14;
            this.ImageSelectionLabel.Text = "Выберите картинку";
            this.ImageSelectionLabel.Visible = false;
            // 
            // ImageDirectoryBox
            // 
            this.ImageDirectoryBox.Location = new System.Drawing.Point(16, 241);
            this.ImageDirectoryBox.Name = "ImageDirectoryBox";
            this.ImageDirectoryBox.Size = new System.Drawing.Size(211, 20);
            this.ImageDirectoryBox.TabIndex = 15;
            this.ImageDirectoryBox.Visible = false;
            // 
            // ImageSelectionButton
            // 
            this.ImageSelectionButton.Location = new System.Drawing.Point(233, 239);
            this.ImageSelectionButton.Name = "ImageSelectionButton";
            this.ImageSelectionButton.Size = new System.Drawing.Size(44, 23);
            this.ImageSelectionButton.TabIndex = 16;
            this.ImageSelectionButton.Text = "...";
            this.ImageSelectionButton.UseVisualStyleBackColor = true;
            this.ImageSelectionButton.Visible = false;
            this.ImageSelectionButton.Click += new System.EventHandler(this.ImageSelectionButton_Click);
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(341, 83);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(426, 70);
            this.QuestionBox.TabIndex = 17;
            this.QuestionBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(337, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Текущий номер вопроса в тесте:";
            // 
            // SourceBox
            // 
            this.SourceBox.Location = new System.Drawing.Point(12, 27);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(778, 442);
            this.SourceBox.TabIndex = 21;
            this.SourceBox.Text = "";
            this.SourceBox.Visible = false;
            // 
            // ExplanationBox
            // 
            this.ExplanationBox.Location = new System.Drawing.Point(16, 315);
            this.ExplanationBox.Name = "ExplanationBox";
            this.ExplanationBox.Size = new System.Drawing.Size(298, 156);
            this.ExplanationBox.TabIndex = 22;
            this.ExplanationBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Пояснение: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(13, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "(если пользователь дал неверный ответ)\r\n";
            // 
            // QuestionNum
            // 
            this.QuestionNum.Location = new System.Drawing.Point(649, 27);
            this.QuestionNum.Name = "QuestionNum";
            this.QuestionNum.Size = new System.Drawing.Size(32, 20);
            this.QuestionNum.TabIndex = 25;
            // 
            // QuestionByUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 483);
            this.Controls.Add(this.SourceBox);
            this.Controls.Add(this.QuestionNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExplanationBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.ImageSelectionButton);
            this.Controls.Add(this.ImageDirectoryBox);
            this.Controls.Add(this.ImageSelectionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IsImageExistBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CorrectAnswerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IsAnswerExistBox);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AnswersGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuestionByUserView";
            this.Text = "Creator";
            this.Load += new System.EventHandler(this.QuestionTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AnswersGrid;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TypeOfView;
        private System.Windows.Forms.ToolStripMenuItem SimpleView;
        private System.Windows.Forms.ToolStripMenuItem SourceView;
        private System.Windows.Forms.ToolStripMenuItem NewDialog;
        private System.Windows.Forms.ToolStripMenuItem EditDialog;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ComboBox IsAnswerExistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorrectAnswerBox;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewComboBoxColumn IsTrue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox IsImageExistBox;
        private System.Windows.Forms.Label ImageSelectionLabel;
        private System.Windows.Forms.TextBox ImageDirectoryBox;
        private System.Windows.Forms.Button ImageSelectionButton;
        private System.Windows.Forms.RichTextBox QuestionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox SourceBox;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.RichTextBox ExplanationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuestionNum;
    }
}