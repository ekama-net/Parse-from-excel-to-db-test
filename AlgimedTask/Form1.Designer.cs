namespace AlgimedTask
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainButton = new System.Windows.Forms.Button();
            this.upper1 = new System.Windows.Forms.TextBox();
            this.upper2 = new System.Windows.Forms.TextBox();
            this.upper3 = new System.Windows.Forms.TextBox();
            this.side1 = new System.Windows.Forms.TextBox();
            this.side2 = new System.Windows.Forms.TextBox();
            this.side3 = new System.Windows.Forms.TextBox();
            this.changeCellsButton = new System.Windows.Forms.Button();
            this.chooseExcelButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.openExcelButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.saveCellsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(12, 256);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(692, 35);
            this.mainButton.TabIndex = 1;
            this.mainButton.Text = "Save to DataBase";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // upper1
            // 
            this.upper1.BackColor = System.Drawing.Color.YellowGreen;
            this.upper1.Enabled = false;
            this.upper1.Location = new System.Drawing.Point(183, 29);
            this.upper1.Name = "upper1";
            this.upper1.Size = new System.Drawing.Size(165, 31);
            this.upper1.TabIndex = 3;
            this.upper1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upper2
            // 
            this.upper2.BackColor = System.Drawing.Color.YellowGreen;
            this.upper2.Enabled = false;
            this.upper2.Location = new System.Drawing.Point(344, 29);
            this.upper2.Name = "upper2";
            this.upper2.Size = new System.Drawing.Size(165, 31);
            this.upper2.TabIndex = 4;
            this.upper2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upper3
            // 
            this.upper3.BackColor = System.Drawing.Color.YellowGreen;
            this.upper3.Enabled = false;
            this.upper3.Location = new System.Drawing.Point(504, 29);
            this.upper3.Name = "upper3";
            this.upper3.Size = new System.Drawing.Size(165, 31);
            this.upper3.TabIndex = 5;
            this.upper3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // side1
            // 
            this.side1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.side1.Enabled = false;
            this.side1.Location = new System.Drawing.Point(19, 66);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(160, 31);
            this.side1.TabIndex = 6;
            this.side1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // side2
            // 
            this.side2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.side2.Enabled = false;
            this.side2.Location = new System.Drawing.Point(19, 98);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(160, 31);
            this.side2.TabIndex = 7;
            this.side2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // side3
            // 
            this.side3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.side3.Enabled = false;
            this.side3.Location = new System.Drawing.Point(19, 130);
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(160, 31);
            this.side3.TabIndex = 8;
            this.side3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeCellsButton
            // 
            this.changeCellsButton.Location = new System.Drawing.Point(18, 29);
            this.changeCellsButton.Name = "changeCellsButton";
            this.changeCellsButton.Size = new System.Drawing.Size(160, 35);
            this.changeCellsButton.TabIndex = 9;
            this.changeCellsButton.Text = "Change Cells";
            this.changeCellsButton.UseVisualStyleBackColor = true;
            this.changeCellsButton.Click += new System.EventHandler(this.changeCellsButton_Click);
            // 
            // chooseExcelButton
            // 
            this.chooseExcelButton.Location = new System.Drawing.Point(12, 12);
            this.chooseExcelButton.Name = "chooseExcelButton";
            this.chooseExcelButton.Size = new System.Drawing.Size(160, 35);
            this.chooseExcelButton.TabIndex = 10;
            this.chooseExcelButton.Text = "Browse...";
            this.chooseExcelButton.UseVisualStyleBackColor = true;
            this.chooseExcelButton.Click += new System.EventHandler(this.chooseExcelButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTextBox.Enabled = false;
            this.fileTextBox.Location = new System.Drawing.Point(178, 16);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(364, 31);
            this.fileTextBox.TabIndex = 11;
            // 
            // openExcelButton
            // 
            this.openExcelButton.Location = new System.Drawing.Point(548, 12);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(156, 35);
            this.openExcelButton.TabIndex = 13;
            this.openExcelButton.Text = "Open File";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.openExcelButton_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(183, 66);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(499, 110);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // saveCellsButton
            // 
            this.saveCellsButton.Location = new System.Drawing.Point(19, 29);
            this.saveCellsButton.Name = "saveCellsButton";
            this.saveCellsButton.Size = new System.Drawing.Size(160, 35);
            this.saveCellsButton.TabIndex = 12;
            this.saveCellsButton.Text = "Save Changes";
            this.saveCellsButton.UseVisualStyleBackColor = true;
            this.saveCellsButton.Visible = false;
            this.saveCellsButton.Click += new System.EventHandler(this.saveCellsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Controls.Add(this.upper1);
            this.groupBox1.Controls.Add(this.upper2);
            this.groupBox1.Controls.Add(this.saveCellsButton);
            this.groupBox1.Controls.Add(this.upper3);
            this.groupBox1.Controls.Add(this.side1);
            this.groupBox1.Controls.Add(this.side2);
            this.groupBox1.Controls.Add(this.changeCellsButton);
            this.groupBox1.Controls.Add(this.side3);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 185);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix of results";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openExcelButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.chooseExcelButton);
            this.Controls.Add(this.mainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algimed Task";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TextBox upper1;
        private System.Windows.Forms.TextBox upper2;
        private System.Windows.Forms.TextBox upper3;
        private System.Windows.Forms.TextBox side1;
        private System.Windows.Forms.TextBox side2;
        private System.Windows.Forms.TextBox side3;
        private System.Windows.Forms.Button changeCellsButton;
        private System.Windows.Forms.Button chooseExcelButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button openExcelButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button saveCellsButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
