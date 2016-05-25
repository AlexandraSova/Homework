namespace DS
{
    partial class QuestionFromSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionFromSite));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeOfView = new System.Windows.Forms.ToolStripMenuItem();
            this.SimpleView = new System.Windows.Forms.ToolStripMenuItem();
            this.SourceView = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.One = new System.Windows.Forms.Button();
            this.QuestionGrid = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionList = new System.Windows.Forms.TreeView();
            this.All = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите предмет и типы вопросов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDialog,
            this.Save,
            this.TypeOfView,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewDialog
            // 
            this.NewDialog.Name = "NewDialog";
            this.NewDialog.Size = new System.Drawing.Size(57, 20);
            this.NewDialog.Text = "Новый";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 20);
            this.Save.Text = "Сохранить";
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
            // 
            // SourceView
            // 
            this.SourceView.Name = "SourceView";
            this.SourceView.Size = new System.Drawing.Size(154, 22);
            this.SourceView.Text = "Расширенный";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(65, 20);
            this.Help.Text = "Справка";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // SubjectBox
            // 
            this.SubjectBox.FormattingEnabled = true;
            this.SubjectBox.Items.AddRange(new object[] {
            "Информатика"});
            this.SubjectBox.Location = new System.Drawing.Point(16, 95);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(238, 21);
            this.SubjectBox.TabIndex = 7;
            this.SubjectBox.SelectedIndexChanged += new System.EventHandler(this.SubjectBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите предмет";
            // 
            // One
            // 
            this.One.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("One.BackgroundImage")));
            this.One.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.One.Location = new System.Drawing.Point(466, 264);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(44, 44);
            this.One.TabIndex = 11;
            this.One.UseVisualStyleBackColor = true;
            // 
            // QuestionGrid
            // 
            this.QuestionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Num});
            this.QuestionGrid.Location = new System.Drawing.Point(516, 122);
            this.QuestionGrid.Name = "QuestionGrid";
            this.QuestionGrid.Size = new System.Drawing.Size(343, 386);
            this.QuestionGrid.TabIndex = 10;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // Num
            // 
            this.Num.HeaderText = "Количество";
            this.Num.Name = "Num";
            // 
            // QuestionList
            // 
            this.QuestionList.Location = new System.Drawing.Point(16, 122);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(444, 386);
            this.QuestionList.TabIndex = 9;
            // 
            // All
            // 
            this.All.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("All.BackgroundImage")));
            this.All.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.All.Location = new System.Drawing.Point(466, 325);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(44, 44);
            this.All.TabIndex = 12;
            this.All.UseVisualStyleBackColor = true;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DownloadButton.Location = new System.Drawing.Point(630, 39);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(215, 58);
            this.DownloadButton.TabIndex = 13;
            this.DownloadButton.Text = "Скачать базу";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // QuestionFromSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 520);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.All);
            this.Controls.Add(this.One);
            this.Controls.Add(this.QuestionGrid);
            this.Controls.Add(this.QuestionList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuestionFromSite";
            this.Text = "Creator";
            this.Load += new System.EventHandler(this.QuestionTypeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TypeOfView;
        private System.Windows.Forms.ToolStripMenuItem SimpleView;
        private System.Windows.Forms.ToolStripMenuItem SourceView;
        private System.Windows.Forms.ToolStripMenuItem NewDialog;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ComboBox SubjectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.DataGridView QuestionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.TreeView QuestionList;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button DownloadButton;
    }
}