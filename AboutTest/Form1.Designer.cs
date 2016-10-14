namespace AboutTest
{
    partial class Form1
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.helpProvider1.SetHelpKeyword(this.button1, "");
            this.helpProvider1.SetHelpString(this.button1, "This button, when clicked, does absolutely nothing.");
            this.button1.Location = new System.Drawing.Point(218, 218);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.checkBox1, "");
            this.helpProvider1.SetHelpString(this.checkBox1, "This check box when clicked does nothing, as assigned by the software developer.");
            this.checkBox1.Location = new System.Drawing.Point(91, 83);
            this.checkBox1.Name = "checkBox1";
            this.helpProvider1.SetShowHelp(this.checkBox1, true);
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comboBox1, "");
            this.helpProvider1.SetHelpString(this.comboBox1, "This combobox holds no data, is not bound and is not currently functional.");
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.helpProvider1.SetShowHelp(this.comboBox1, true);
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.helpProvider1.SetHelpString(this.linkLabel1, "This link label is set specifically with a link  that goes nowhere.");
            this.linkLabel1.Location = new System.Drawing.Point(153, 146);
            this.linkLabel1.Name = "linkLabel1";
            this.helpProvider1.SetShowHelp(this.linkLabel1, true);
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.helpProvider1.SetHelpString(this.linkLabel2, "This will bring up the About box.");
            this.linkLabel2.Location = new System.Drawing.Point(245, 6);
            this.linkLabel2.Name = "linkLabel2";
            this.helpProvider1.SetShowHelp(this.linkLabel2, true);
            this.linkLabel2.Size = new System.Drawing.Size(35, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 262);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "");
            this.helpProvider1.SetHelpString(this, "This winforms application is for testing of the HelpProvider and AboutBox.");
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Help Provider and About Box Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

