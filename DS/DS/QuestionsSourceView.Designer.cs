namespace DS
{
    partial class QuestionsSourceView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Settings = new System.Windows.Forms.ToolStripLabel();
            this.About = new System.Windows.Forms.ToolStripLabel();
            this.ByHands = new System.Windows.Forms.Button();
            this.FromSite = new System.Windows.Forms.Button();
            this.BaseEditor = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings,
            this.About});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(67, 22);
            this.Settings.Text = "Настройки";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(82, 22);
            this.About.Text = "О программе";
            // 
            // ByHands
            // 
            this.ByHands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ByHands.Location = new System.Drawing.Point(12, 55);
            this.ByHands.Name = "ByHands";
            this.ByHands.Size = new System.Drawing.Size(181, 88);
            this.ByHands.TabIndex = 9;
            this.ByHands.Text = "Создать базу вручную";
            this.ByHands.UseVisualStyleBackColor = true;
            // 
            // FromSite
            // 
            this.FromSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FromSite.Location = new System.Drawing.Point(199, 55);
            this.FromSite.Name = "FromSite";
            this.FromSite.Size = new System.Drawing.Size(181, 88);
            this.FromSite.TabIndex = 10;
            this.FromSite.Text = "Скачать базу с сайта";
            this.FromSite.UseVisualStyleBackColor = true;
            // 
            // BaseEditor
            // 
            this.BaseEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BaseEditor.Location = new System.Drawing.Point(386, 55);
            this.BaseEditor.Name = "BaseEditor";
            this.BaseEditor.Size = new System.Drawing.Size(181, 88);
            this.BaseEditor.TabIndex = 11;
            this.BaseEditor.Text = "Редактор баз";
            this.BaseEditor.UseVisualStyleBackColor = true;
            // 
            // QuestionsSourceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 160);
            this.Controls.Add(this.BaseEditor);
            this.Controls.Add(this.FromSite);
            this.Controls.Add(this.ByHands);
            this.Controls.Add(this.toolStrip1);
            this.Name = "QuestionsSourceView";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel About;
        private System.Windows.Forms.ToolStripLabel Settings;
        private System.Windows.Forms.Button ByHands;
        private System.Windows.Forms.Button FromSite;
        private System.Windows.Forms.Button BaseEditor;
    }
}

