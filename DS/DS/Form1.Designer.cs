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
            this.Go = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.Referense = new System.Windows.Forms.Button();
            this.ReferenseText = new System.Windows.Forms.Label();
            this.ReferenseLabel = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(55, 164);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(223, 79);
            this.Go.TabIndex = 24;
            this.Go.Text = "Пройти тест";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click_1);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(15, 295);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(117, 38);
            this.Ok.TabIndex = 23;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click_1);
            // 
            // Referense
            // 
            this.Referense.Location = new System.Drawing.Point(138, 295);
            this.Referense.Name = "Referense";
            this.Referense.Size = new System.Drawing.Size(120, 38);
            this.Referense.TabIndex = 22;
            this.Referense.Text = "Подсказка";
            this.Referense.UseVisualStyleBackColor = true;
            this.Referense.Click += new System.EventHandler(this.Referense_Click_1);
            // 
            // ReferenseText
            // 
            this.ReferenseText.AutoSize = true;
            this.ReferenseText.Location = new System.Drawing.Point(12, 406);
            this.ReferenseText.Name = "ReferenseText";
            this.ReferenseText.Size = new System.Drawing.Size(82, 13);
            this.ReferenseText.TabIndex = 21;
            this.ReferenseText.Text = "Текст справки";
            // 
            // ReferenseLabel
            // 
            this.ReferenseLabel.AutoSize = true;
            this.ReferenseLabel.Location = new System.Drawing.Point(12, 383);
            this.ReferenseLabel.Name = "ReferenseLabel";
            this.ReferenseLabel.Size = new System.Drawing.Size(50, 13);
            this.ReferenseLabel.TabIndex = 20;
            this.ReferenseLabel.Text = "Справка";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Maroon;
            this.Error.Location = new System.Drawing.Point(12, 355);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(47, 13);
            this.Error.TabIndex = 19;
            this.Error.Text = "Ошибка";
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(15, 256);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(243, 20);
            this.AnswerText.TabIndex = 18;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(12, 230);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(37, 13);
            this.AnswerLabel.TabIndex = 17;
            this.AnswerLabel.Text = "Ответ";
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Location = new System.Drawing.Point(12, 34);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(82, 13);
            this.QuestionText.TabIndex = 16;
            this.QuestionText.Text = "Текст вопроса";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(12, 9);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(44, 13);
            this.QuestionLabel.TabIndex = 15;
            this.QuestionLabel.Text = "Вопрос";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(296, 164);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(223, 79);
            this.Create.TabIndex = 25;
            this.Create.Text = "Создать тест";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 449);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Referense);
            this.Controls.Add(this.ReferenseText);
            this.Controls.Add(this.ReferenseLabel);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "Form1";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Referense;
        private System.Windows.Forms.Label ReferenseText;
        private System.Windows.Forms.Label ReferenseLabel;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button Create;


    }
}

