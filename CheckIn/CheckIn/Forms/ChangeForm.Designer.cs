namespace CheckIn.Patient
{
    partial class ChangeForm
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
            this.ok_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.diagnosis_comboBox = new System.Windows.Forms.ComboBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.policy_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passport_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(183, 260);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Ок";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // fio_textBox
            // 
            this.fio_textBox.Location = new System.Drawing.Point(15, 25);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(243, 20);
            this.fio_textBox.TabIndex = 2;
            // 
            // diagnosis_comboBox
            // 
            this.diagnosis_comboBox.FormattingEnabled = true;
            this.diagnosis_comboBox.Location = new System.Drawing.Point(15, 220);
            this.diagnosis_comboBox.Name = "diagnosis_comboBox";
            this.diagnosis_comboBox.Size = new System.Drawing.Size(243, 21);
            this.diagnosis_comboBox.TabIndex = 3;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(15, 64);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(243, 20);
            this.address_textBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес";
            // 
            // tel_textBox
            // 
            this.tel_textBox.Location = new System.Drawing.Point(15, 103);
            this.tel_textBox.Name = "tel_textBox";
            this.tel_textBox.Size = new System.Drawing.Size(243, 20);
            this.tel_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // policy_textBox
            // 
            this.policy_textBox.Location = new System.Drawing.Point(15, 142);
            this.policy_textBox.Name = "policy_textBox";
            this.policy_textBox.Size = new System.Drawing.Size(243, 20);
            this.policy_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Полис";
            // 
            // passport_textBox
            // 
            this.passport_textBox.Location = new System.Drawing.Point(15, 181);
            this.passport_textBox.Name = "passport_textBox";
            this.passport_textBox.Size = new System.Drawing.Size(243, 20);
            this.passport_textBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Паспорт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Диагноз";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 303);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passport_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.policy_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tel_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diagnosis_comboBox);
            this.Controls.Add(this.fio_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok_button);
            this.Name = "ChangeForm";
            this.Text = "Внести изменения";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.ComboBox diagnosis_comboBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tel_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox policy_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passport_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}