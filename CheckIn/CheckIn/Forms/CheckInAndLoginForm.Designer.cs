namespace CheckIn
{
    partial class CheckInForm
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
            System.Windows.Forms.Label mail_label;
            this.checkin_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.pass1_label = new System.Windows.Forms.Label();
            this.pass2_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.CheckPass = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            mail_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Location = new System.Drawing.Point(9, 104);
            mail_label.Name = "mail_label";
            mail_label.Size = new System.Drawing.Size(38, 13);
            mail_label.TabIndex = 2;
            mail_label.Text = "E-mail:";
            // 
            // checkin_button
            // 
            this.checkin_button.Location = new System.Drawing.Point(14, 299);
            this.checkin_button.Name = "checkin_button";
            this.checkin_button.Size = new System.Drawing.Size(123, 23);
            this.checkin_button.TabIndex = 0;
            this.checkin_button.Text = "Зарегистрироваться";
            this.checkin_button.UseVisualStyleBackColor = true;
            this.checkin_button.Click += new System.EventHandler(this.checkin_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(9, 12);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(32, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Имя:";
            // 
            // pass1_label
            // 
            this.pass1_label.AutoSize = true;
            this.pass1_label.Location = new System.Drawing.Point(9, 152);
            this.pass1_label.Name = "pass1_label";
            this.pass1_label.Size = new System.Drawing.Size(48, 13);
            this.pass1_label.TabIndex = 3;
            this.pass1_label.Text = "Пароль:";
            // 
            // pass2_label
            // 
            this.pass2_label.AutoSize = true;
            this.pass2_label.Location = new System.Drawing.Point(9, 211);
            this.pass2_label.Name = "pass2_label";
            this.pass2_label.Size = new System.Drawing.Size(103, 13);
            this.pass2_label.TabIndex = 4;
            this.pass2_label.Text = "Повторите пароль:";
            this.pass2_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(9, 57);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(56, 13);
            this.lastname_label.TabIndex = 5;
            this.lastname_label.Text = "Фамилия";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(12, 28);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(244, 20);
            this.firstname.TabIndex = 6;
            this.firstname.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(12, 73);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(244, 20);
            this.lastname.TabIndex = 7;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(12, 120);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(244, 20);
            this.mail.TabIndex = 8;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(12, 179);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.Size = new System.Drawing.Size(244, 20);
            this.pass1.TabIndex = 9;
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(12, 237);
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.Size = new System.Drawing.Size(244, 20);
            this.pass2.TabIndex = 10;
            this.pass2.TextChanged += new System.EventHandler(this.pass2_TextChanged);
            this.pass2.VisibleChanged += new System.EventHandler(this.pass2_VisibleChanged);
            // 
            // CheckPass
            // 
            this.CheckPass.AutoSize = true;
            this.CheckPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPass.ForeColor = System.Drawing.Color.Brown;
            this.CheckPass.Location = new System.Drawing.Point(12, 270);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.Size = new System.Drawing.Size(0, 12);
            this.CheckPass.TabIndex = 11;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(143, 299);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(113, 23);
            this.login_button.TabIndex = 12;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 334);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.CheckPass);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.pass2_label);
            this.Controls.Add(this.pass1_label);
            this.Controls.Add(mail_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.checkin_button);
            this.Name = "CheckInForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkin_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label pass1_label;
        private System.Windows.Forms.Label pass2_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label CheckPass;
        private System.Windows.Forms.Button login_button;
    }
}

