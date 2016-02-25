namespace DS
{
    partial class CreateForm
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
            this.Reference = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.ScenarioName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.Scenario = new System.Windows.Forms.DataGridView();
            this.ask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_next = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Scenario)).BeginInit();
            this.SuspendLayout();
            // 
            // Reference
            // 
            this.Reference.Location = new System.Drawing.Point(29, 280);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(201, 44);
            this.Reference.TabIndex = 13;
            this.Reference.Text = "Справка по вводу";
            this.Reference.UseVisualStyleBackColor = true;
            this.Reference.Click += new System.EventHandler(this.Reference_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(354, 11);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(98, 30);
            this.ok.TabIndex = 12;
            this.ok.Text = "ок";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error.ForeColor = System.Drawing.Color.Maroon;
            this.Error.Location = new System.Drawing.Point(458, 11);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(51, 16);
            this.Error.TabIndex = 11;
            this.Error.Text = "label2";
            // 
            // ScenarioName
            // 
            this.ScenarioName.Location = new System.Drawing.Point(196, 11);
            this.ScenarioName.Name = "ScenarioName";
            this.ScenarioName.Size = new System.Drawing.Size(152, 20);
            this.ScenarioName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название сценария";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(522, 280);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(201, 44);
            this.Go.TabIndex = 8;
            this.Go.Text = "Сохранить";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
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
            this.Scenario.Location = new System.Drawing.Point(29, 56);
            this.Scenario.Name = "Scenario";
            this.Scenario.Size = new System.Drawing.Size(694, 218);
            this.Scenario.TabIndex = 7;
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
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 334);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.ScenarioName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Scenario);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scenario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reference;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.TextBox ScenarioName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.DataGridView Scenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ask;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_next;
        private System.Windows.Forms.DataGridViewTextBoxColumn ans;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprav;
    }
}