namespace DS
{
    partial class HelloForm
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
            this.registation = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Ok1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registation
            // 
            this.registation.Location = new System.Drawing.Point(78, 120);
            this.registation.Name = "registation";
            this.registation.Size = new System.Drawing.Size(182, 68);
            this.registation.TabIndex = 0;
            this.registation.Text = "Регистрация";
            this.registation.UseVisualStyleBackColor = true;
            this.registation.Click += new System.EventHandler(this.registation_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(78, 37);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(182, 68);
            this.login.TabIndex = 2;
            this.login.Text = "Вход";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(15, 183);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(121, 34);
            this.Ok.TabIndex = 10;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(12, 104);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(88, 13);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Введите пароль";
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(15, 133);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(174, 20);
            this.PassText.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Введите имя";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(15, 59);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(174, 20);
            this.NameText.TabIndex = 6;
            // 
            // Ok1
            // 
            this.Ok1.Location = new System.Drawing.Point(15, 183);
            this.Ok1.Name = "Ok1";
            this.Ok1.Size = new System.Drawing.Size(121, 34);
            this.Ok1.TabIndex = 11;
            this.Ok1.Text = "OK";
            this.Ok1.UseVisualStyleBackColor = true;
            this.Ok1.Click += new System.EventHandler(this.Ok1_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 226);
            this.Controls.Add(this.Ok1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.login);
            this.Controls.Add(this.registation);
            this.Name = "HelloForm";
            this.Text = "HelloForm";
            this.Load += new System.EventHandler(this.HelloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registation;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button Ok1;
    }
}