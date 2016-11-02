namespace CheckIn
{
    partial class PatientForm
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
            this.Patient_table = new System.Windows.Forms.DataGridView();
            this.diagnosis_label = new System.Windows.Forms.Label();
            this.diagnosis_combo = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Patient_table)).BeginInit();
            this.SuspendLayout();
            // 
            // Patient_table
            // 
            this.Patient_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patient_table.Location = new System.Drawing.Point(12, 12);
            this.Patient_table.Name = "Patient_table";
            this.Patient_table.Size = new System.Drawing.Size(640, 261);
            this.Patient_table.TabIndex = 0;
            // 
            // diagnosis_label
            // 
            this.diagnosis_label.AutoSize = true;
            this.diagnosis_label.Location = new System.Drawing.Point(12, 331);
            this.diagnosis_label.Name = "diagnosis_label";
            this.diagnosis_label.Size = new System.Drawing.Size(182, 13);
            this.diagnosis_label.TabIndex = 1;
            this.diagnosis_label.Text = "Показать пациентов с диагнозом ";
            // 
            // diagnosis_combo
            // 
            this.diagnosis_combo.FormattingEnabled = true;
            this.diagnosis_combo.Location = new System.Drawing.Point(226, 329);
            this.diagnosis_combo.Name = "diagnosis_combo";
            this.diagnosis_combo.Size = new System.Drawing.Size(212, 21);
            this.diagnosis_combo.TabIndex = 2;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(444, 327);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(208, 21);
            this.ok.TabIndex = 3;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 288);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(208, 23);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(226, 288);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(212, 23);
            this.change_button.TabIndex = 5;
            this.change_button.Text = "Изменить";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(444, 288);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(208, 23);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.diagnosis_combo);
            this.Controls.Add(this.diagnosis_label);
            this.Controls.Add(this.Patient_table);
            this.Name = "PatientForm";
            this.Text = "Пациенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientForm_FormClosing);
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Patient_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Patient_table;
        private System.Windows.Forms.Label diagnosis_label;
        private System.Windows.Forms.ComboBox diagnosis_combo;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button delete_button;
    }
}