namespace DS
{
    partial class EditForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Go = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.ScenarioName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Scenario = new System.Windows.Forms.DataGridView();
            this.ask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_next = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Scenario)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(275, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "*Сначала строку нужно выделить.";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(278, 284);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(201, 44);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Удалить стороку";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Новая строка будет добавлена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "*Сначала строку нужно выделить.";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(43, 284);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(201, 44);
            this.Add.TabIndex = 22;
            this.Add.Text = "Добавить строку";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(537, 284);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(201, 44);
            this.Go.TabIndex = 21;
            this.Go.Text = "Сохранить сценарий";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(363, 9);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(98, 30);
            this.ok.TabIndex = 20;
            this.ok.Text = "ок";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error.ForeColor = System.Drawing.Color.Maroon;
            this.Error.Location = new System.Drawing.Point(467, 9);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(51, 16);
            this.Error.TabIndex = 19;
            this.Error.Text = "label2";
            // 
            // ScenarioName
            // 
            this.ScenarioName.Location = new System.Drawing.Point(205, 9);
            this.ScenarioName.Name = "ScenarioName";
            this.ScenarioName.Size = new System.Drawing.Size(152, 20);
            this.ScenarioName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название сценария";
            // 
            // Scenario
            // 
            this.Scenario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Scenario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ask,
            this.type,
            this.n_next,
            this.ans,
            this.sprav});
            this.Scenario.Location = new System.Drawing.Point(45, 52);
            this.Scenario.Name = "Scenario";
            this.Scenario.Size = new System.Drawing.Size(693, 218);
            this.Scenario.TabIndex = 16;
            // 
            // ask
            // 
            this.ask.HeaderText = "Вопрос";
            this.ask.Name = "ask";
            this.ask.Width = 130;
            // 
            // type
            // 
            this.type.HeaderText = "Тип перехода";
            this.type.Name = "type";
            this.type.Width = 130;
            // 
            // n_next
            // 
            this.n_next.HeaderText = "Следующие вопросы";
            this.n_next.Name = "n_next";
            this.n_next.Width = 130;
            // 
            // ans
            // 
            this.ans.HeaderText = "Допустимые ответы";
            this.ans.Name = "ans";
            this.ans.Width = 130;
            // 
            // sprav
            // 
            this.sprav.HeaderText = "Справка";
            this.sprav.Name = "sprav";
            this.sprav.Width = 130;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.ScenarioName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scenario);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scenario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.TextBox ScenarioName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Scenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ask;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_next;
        private System.Windows.Forms.DataGridViewTextBoxColumn ans;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprav;

    }
}