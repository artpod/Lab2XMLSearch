namespace Lab3
{
    partial class PlaylistReader
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
            this.searchResultsViewer = new System.Windows.Forms.RichTextBox();
            this.searchCriteriaGroup = new System.Windows.Forms.GroupBox();
            this.yearCheckBox = new System.Windows.Forms.CheckBox();
            this.linqToXmlBtn = new System.Windows.Forms.RadioButton();
            this.saxBtn = new System.Windows.Forms.RadioButton();
            this.domBtn = new System.Windows.Forms.RadioButton();
            this.disciplineDropList = new System.Windows.Forms.ComboBox();
            this.averageDropList = new System.Windows.Forms.ComboBox();
            this.yearDropList = new System.Windows.Forms.ComboBox();
            this.disciplineCheckBox = new System.Windows.Forms.CheckBox();
            this.averageCheckBox = new System.Windows.Forms.CheckBox();
            this.facultyCheckBox = new System.Windows.Forms.CheckBox();
            this.facultyDropList = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.forgeHtmlBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCriteriaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchResultsViewer
            // 
            this.searchResultsViewer.Location = new System.Drawing.Point(12, 29);
            this.searchResultsViewer.Name = "searchResultsViewer";
            this.searchResultsViewer.Size = new System.Drawing.Size(602, 595);
            this.searchResultsViewer.TabIndex = 0;
            this.searchResultsViewer.Text = "";
            // 
            // searchCriteriaGroup
            // 
            this.searchCriteriaGroup.Controls.Add(this.yearCheckBox);
            this.searchCriteriaGroup.Controls.Add(this.linqToXmlBtn);
            this.searchCriteriaGroup.Controls.Add(this.saxBtn);
            this.searchCriteriaGroup.Controls.Add(this.domBtn);
            this.searchCriteriaGroup.Controls.Add(this.disciplineDropList);
            this.searchCriteriaGroup.Controls.Add(this.averageDropList);
            this.searchCriteriaGroup.Controls.Add(this.yearDropList);
            this.searchCriteriaGroup.Controls.Add(this.disciplineCheckBox);
            this.searchCriteriaGroup.Controls.Add(this.averageCheckBox);
            this.searchCriteriaGroup.Controls.Add(this.facultyCheckBox);
            this.searchCriteriaGroup.Controls.Add(this.facultyDropList);
            this.searchCriteriaGroup.Location = new System.Drawing.Point(639, 27);
            this.searchCriteriaGroup.Name = "searchCriteriaGroup";
            this.searchCriteriaGroup.Size = new System.Drawing.Size(400, 300);
            this.searchCriteriaGroup.TabIndex = 1;
            this.searchCriteriaGroup.TabStop = false;
            this.searchCriteriaGroup.Text = "Критерії";
            // 
            // yearCheckBox
            // 
            this.yearCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearCheckBox.Location = new System.Drawing.Point(12, 101);
            this.yearCheckBox.Name = "yearCheckBox";
            this.yearCheckBox.Size = new System.Drawing.Size(155, 42);
            this.yearCheckBox.TabIndex = 0;
            this.yearCheckBox.Text = "Рік початку";
            this.yearCheckBox.CheckedChanged += new System.EventHandler(this.yearCheckBox_CheckedChanged_1);
            // 
            // linqToXmlBtn
            // 
            this.linqToXmlBtn.AutoSize = true;
            this.linqToXmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linqToXmlBtn.Location = new System.Drawing.Point(174, 222);
            this.linqToXmlBtn.Name = "linqToXmlBtn";
            this.linqToXmlBtn.Size = new System.Drawing.Size(147, 29);
            this.linqToXmlBtn.TabIndex = 10;
            this.linqToXmlBtn.Text = "LINQ to XML";
            this.linqToXmlBtn.UseVisualStyleBackColor = true;
            // 
            // saxBtn
            // 
            this.saxBtn.AutoSize = true;
            this.saxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saxBtn.Location = new System.Drawing.Point(6, 222);
            this.saxBtn.Name = "saxBtn";
            this.saxBtn.Size = new System.Drawing.Size(75, 29);
            this.saxBtn.TabIndex = 9;
            this.saxBtn.Text = "SAX";
            this.saxBtn.UseVisualStyleBackColor = true;
            // 
            // domBtn
            // 
            this.domBtn.AutoSize = true;
            this.domBtn.Checked = true;
            this.domBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.domBtn.Location = new System.Drawing.Point(87, 222);
            this.domBtn.Name = "domBtn";
            this.domBtn.Size = new System.Drawing.Size(80, 29);
            this.domBtn.TabIndex = 8;
            this.domBtn.TabStop = true;
            this.domBtn.Text = "DOM";
            this.domBtn.UseVisualStyleBackColor = true;
            // 
            // disciplineDropList
            // 
            this.disciplineDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineDropList.Enabled = false;
            this.disciplineDropList.FormattingEnabled = true;
            this.disciplineDropList.Location = new System.Drawing.Point(174, 167);
            this.disciplineDropList.Name = "disciplineDropList";
            this.disciplineDropList.Size = new System.Drawing.Size(186, 24);
            this.disciplineDropList.Sorted = true;
            this.disciplineDropList.TabIndex = 7;
            // 
            // averageDropList
            // 
            this.averageDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.averageDropList.Enabled = false;
            this.averageDropList.FormattingEnabled = true;
            this.averageDropList.Location = new System.Drawing.Point(174, 60);
            this.averageDropList.Name = "averageDropList";
            this.averageDropList.Size = new System.Drawing.Size(186, 24);
            this.averageDropList.Sorted = true;
            this.averageDropList.TabIndex = 3;
            // 
            // yearDropList
            // 
            this.yearDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearDropList.Enabled = false;
            this.yearDropList.FormattingEnabled = true;
            this.yearDropList.Location = new System.Drawing.Point(174, 111);
            this.yearDropList.Name = "yearDropList";
            this.yearDropList.Size = new System.Drawing.Size(186, 24);
            this.yearDropList.Sorted = true;
            this.yearDropList.TabIndex = 5;
            // 
            // disciplineCheckBox
            // 
            this.disciplineCheckBox.AutoSize = true;
            this.disciplineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disciplineCheckBox.Location = new System.Drawing.Point(12, 149);
            this.disciplineCheckBox.Name = "disciplineCheckBox";
            this.disciplineCheckBox.Size = new System.Drawing.Size(128, 54);
            this.disciplineCheckBox.TabIndex = 6;
            this.disciplineCheckBox.Text = "Кількість\r\nдисциплін";
            this.disciplineCheckBox.UseVisualStyleBackColor = true;
            this.disciplineCheckBox.CheckedChanged += new System.EventHandler(this.disciplineCheckBox_CheckedChanged);
            // 
            // averageCheckBox
            // 
            this.averageCheckBox.AutoSize = true;
            this.averageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.averageCheckBox.Location = new System.Drawing.Point(12, 56);
            this.averageCheckBox.Name = "averageCheckBox";
            this.averageCheckBox.Size = new System.Drawing.Size(156, 29);
            this.averageCheckBox.TabIndex = 2;
            this.averageCheckBox.Text = "Середній бал";
            this.averageCheckBox.UseVisualStyleBackColor = true;
            this.averageCheckBox.CheckedChanged += new System.EventHandler(this.averageCheckBox_CheckedChanged);
            // 
            // facultyCheckBox
            // 
            this.facultyCheckBox.AutoSize = true;
            this.facultyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.facultyCheckBox.Location = new System.Drawing.Point(12, 21);
            this.facultyCheckBox.Name = "facultyCheckBox";
            this.facultyCheckBox.Size = new System.Drawing.Size(139, 29);
            this.facultyCheckBox.TabIndex = 4;
            this.facultyCheckBox.Text = "Факультет";
            this.facultyCheckBox.UseVisualStyleBackColor = true;
            this.facultyCheckBox.CheckedChanged += new System.EventHandler(this.facultyCheckBox_CheckedChanged);
            // 
            // facultyDropList
            // 
            this.facultyDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyDropList.Enabled = false;
            this.facultyDropList.FormattingEnabled = true;
            this.facultyDropList.Location = new System.Drawing.Point(174, 26);
            this.facultyDropList.Name = "facultyDropList";
            this.facultyDropList.Size = new System.Drawing.Size(186, 24);
            this.facultyDropList.Sorted = true;
            this.facultyDropList.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1049, 145);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(199, 60);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Знайти";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // forgeHtmlBtn
            // 
            this.forgeHtmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgeHtmlBtn.Location = new System.Drawing.Point(1049, 58);
            this.forgeHtmlBtn.Name = "forgeHtmlBtn";
            this.forgeHtmlBtn.Size = new System.Drawing.Size(199, 58);
            this.forgeHtmlBtn.TabIndex = 3;
            this.forgeHtmlBtn.Text = "Завантажити HTML-інформацію";
            this.forgeHtmlBtn.UseVisualStyleBackColor = true;
            this.forgeHtmlBtn.Click += new System.EventHandler(this.forgeHtmlBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат";
            // 
            // PlaylistReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgeHtmlBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchCriteriaGroup);
            this.Controls.Add(this.searchResultsViewer);
            this.Name = "PlaylistReader";
            this.Text = "XML ";
            this.Load += new System.EventHandler(this.PlaylistReader_Load);
            this.searchCriteriaGroup.ResumeLayout(false);
            this.searchCriteriaGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox searchResultsViewer;
        private System.Windows.Forms.GroupBox searchCriteriaGroup;
        private System.Windows.Forms.ComboBox facultyDropList;
        private System.Windows.Forms.RadioButton linqToXmlBtn;
        private System.Windows.Forms.RadioButton saxBtn;
        private System.Windows.Forms.RadioButton domBtn;
        private System.Windows.Forms.ComboBox disciplineDropList;
        private System.Windows.Forms.CheckBox disciplineCheckBox;
        private System.Windows.Forms.ComboBox yearDropList;
        private System.Windows.Forms.CheckBox facultyCheckBox;
        private System.Windows.Forms.ComboBox averageDropList;
        private System.Windows.Forms.CheckBox averageCheckBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button forgeHtmlBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox yearCheckBox;
    }
}

