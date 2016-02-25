namespace DS
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.Label();
            this.ReferenseLabel = new System.Windows.Forms.Label();
            this.ReferenseText = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Button();
            this.Protocol = new System.Windows.Forms.DataGridView();
            this.quest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DialogLabel = new System.Windows.Forms.Label();
            this.Referense = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Protocol)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(12, 9);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(44, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Вопрос";
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Location = new System.Drawing.Point(12, 34);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(82, 13);
            this.QuestionText.TabIndex = 1;
            this.QuestionText.Text = "Текст вопроса";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(12, 88);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(37, 13);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "Ответ";
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(15, 104);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(243, 20);
            this.AnswerText.TabIndex = 3;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Maroon;
            this.Error.Location = new System.Drawing.Point(12, 186);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(47, 13);
            this.Error.TabIndex = 4;
            this.Error.Text = "Ошибка";
            // 
            // ReferenseLabel
            // 
            this.ReferenseLabel.AutoSize = true;
            this.ReferenseLabel.Location = new System.Drawing.Point(12, 213);
            this.ReferenseLabel.Name = "ReferenseLabel";
            this.ReferenseLabel.Size = new System.Drawing.Size(50, 13);
            this.ReferenseLabel.TabIndex = 5;
            this.ReferenseLabel.Text = "Справка";
            // 
            // ReferenseText
            // 
            this.ReferenseText.AutoSize = true;
            this.ReferenseText.Location = new System.Drawing.Point(10, 229);
            this.ReferenseText.Name = "ReferenseText";
            this.ReferenseText.Size = new System.Drawing.Size(82, 13);
            this.ReferenseText.TabIndex = 6;
            this.ReferenseText.Text = "Текст справки";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 245);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(120, 38);
            this.Create.TabIndex = 7;
            this.Create.Text = "Создать сценарий";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(138, 245);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(120, 38);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Редактировать сценарий";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(264, 245);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(120, 38);
            this.Record.TabIndex = 9;
            this.Record.Text = "Задокументировать ход диалога";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Protocol
            // 
            this.Protocol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Protocol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quest,
            this.ans});
            this.Protocol.Location = new System.Drawing.Point(12, 319);
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Size = new System.Drawing.Size(565, 120);
            this.Protocol.TabIndex = 10;
            // 
            // quest
            // 
            this.quest.HeaderText = "Вопрос";
            this.quest.Name = "quest";
            this.quest.ReadOnly = true;
            this.quest.Width = 400;
            // 
            // ans
            // 
            this.ans.HeaderText = "Ваш ответ";
            this.ans.Name = "ans";
            this.ans.ReadOnly = true;
            this.ans.Width = 120;
            // 
            // DialogLabel
            // 
            this.DialogLabel.AutoSize = true;
            this.DialogLabel.Location = new System.Drawing.Point(12, 303);
            this.DialogLabel.Name = "DialogLabel";
            this.DialogLabel.Size = new System.Drawing.Size(70, 13);
            this.DialogLabel.TabIndex = 11;
            this.DialogLabel.Text = "Ход диалога";
            // 
            // Referense
            // 
            this.Referense.Location = new System.Drawing.Point(138, 130);
            this.Referense.Name = "Referense";
            this.Referense.Size = new System.Drawing.Size(120, 38);
            this.Referense.TabIndex = 12;
            this.Referense.Text = "Справка";
            this.Referense.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(15, 130);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(117, 38);
            this.Ok.TabIndex = 13;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 449);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Referense);
            this.Controls.Add(this.DialogLabel);
            this.Controls.Add(this.Protocol);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.ReferenseText);
            this.Controls.Add(this.ReferenseLabel);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "Form1";
            this.Text = "Диалоговая система";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Protocol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label ReferenseLabel;
        private System.Windows.Forms.Label ReferenseText;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.DataGridView Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ans;
        private System.Windows.Forms.Label DialogLabel;
        private System.Windows.Forms.Button Referense;
        private System.Windows.Forms.Button Ok;

    }
}

