namespace Corruption
{
    partial class CorruptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorruptForm));
            this.numPicker = new System.Windows.Forms.NumericUpDown();
            this.labelText = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.petaBrowsebtn = new System.Windows.Forms.Button();
            this.popBtnBrowse = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.labelBrowse1 = new System.Windows.Forms.Label();
            this.labelBrowse2 = new System.Windows.Forms.Label();
            this.signPeta = new System.Windows.Forms.Label();
            this.popLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // numPicker
            // 
            this.numPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPicker.Location = new System.Drawing.Point(366, 99);
            this.numPicker.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPicker.Name = "numPicker";
            this.numPicker.Size = new System.Drawing.Size(120, 52);
            this.numPicker.TabIndex = 0;
            this.numPicker.ValueChanged += new System.EventHandler(this.numPicker_ValueChanged);
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(44, 102);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(222, 48);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Insert Time : ";
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Lime;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(82, 408);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(130, 70);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Simulate";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // petaBrowsebtn
            // 
            this.petaBrowsebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.petaBrowsebtn.Location = new System.Drawing.Point(366, 189);
            this.petaBrowsebtn.Name = "petaBrowsebtn";
            this.petaBrowsebtn.Size = new System.Drawing.Size(120, 35);
            this.petaBrowsebtn.TabIndex = 3;
            this.petaBrowsebtn.Text = "Browse File";
            this.petaBrowsebtn.UseVisualStyleBackColor = true;
            this.petaBrowsebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // popBtnBrowse
            // 
            this.popBtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.popBtnBrowse.Location = new System.Drawing.Point(366, 300);
            this.popBtnBrowse.Name = "popBtnBrowse";
            this.popBtnBrowse.Size = new System.Drawing.Size(120, 35);
            this.popBtnBrowse.TabIndex = 4;
            this.popBtnBrowse.Text = "Browse File";
            this.popBtnBrowse.UseVisualStyleBackColor = true;
            this.popBtnBrowse.Click += new System.EventHandler(this.popBtnBrowse_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Crimson;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(302, 408);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(130, 70);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelBrowse1
            // 
            this.labelBrowse1.AutoSize = true;
            this.labelBrowse1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowse1.ForeColor = System.Drawing.Color.White;
            this.labelBrowse1.Location = new System.Drawing.Point(44, 192);
            this.labelBrowse1.Name = "labelBrowse1";
            this.labelBrowse1.Size = new System.Drawing.Size(156, 32);
            this.labelBrowse1.TabIndex = 6;
            this.labelBrowse1.Text = "Peta Config";
            this.labelBrowse1.Click += new System.EventHandler(this.labelBrowse1_Click);
            // 
            // labelBrowse2
            // 
            this.labelBrowse2.AutoSize = true;
            this.labelBrowse2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowse2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBrowse2.Location = new System.Drawing.Point(44, 303);
            this.labelBrowse2.Name = "labelBrowse2";
            this.labelBrowse2.Size = new System.Drawing.Size(236, 32);
            this.labelBrowse2.TabIndex = 7;
            this.labelBrowse2.Text = "Population Config";
            this.labelBrowse2.Click += new System.EventHandler(this.labelBrowse2_Click);
            // 
            // signPeta
            // 
            this.signPeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signPeta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signPeta.ForeColor = System.Drawing.Color.White;
            this.signPeta.Location = new System.Drawing.Point(47, 224);
            this.signPeta.Name = "signPeta";
            this.signPeta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signPeta.Size = new System.Drawing.Size(439, 32);
            this.signPeta.TabIndex = 8;
            this.signPeta.Text = "-";
            this.signPeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signPeta.Click += new System.EventHandler(this.signPeta_Click);
            // 
            // popLabel
            // 
            this.popLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popLabel.ForeColor = System.Drawing.Color.White;
            this.popLabel.Location = new System.Drawing.Point(42, 335);
            this.popLabel.Name = "popLabel";
            this.popLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popLabel.Size = new System.Drawing.Size(444, 28);
            this.popLabel.TabIndex = 9;
            this.popLabel.Text = "-";
            this.popLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.popLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 69);
            this.label1.TabIndex = 10;
            this.label1.Text = " Corona Virus Simulation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Location = new System.Drawing.Point(497, 93);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(488, 389);
            this.mainPanel.TabIndex = 11;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "© 2020 Corruption All Right Reserved";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(-2, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1209, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "_________________________________________________________________________________" +
    "_______________________________________________\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 104);
            this.label4.TabIndex = 15;
            this.label4.Text = "                       Created By :\r\n      Jovan Karuna Cahyadi / 13518024\r\n    J" +
    "onathan Yudi Gunawan / 13518084\r\n                 William / 13518138";
            // 
            // pathBox
            // 
            this.pathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox.Location = new System.Drawing.Point(1004, 93);
            this.pathBox.Multiline = true;
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(171, 389);
            this.pathBox.TabIndex = 16;
            // 
            // CorruptForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1196, 625);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.popLabel);
            this.Controls.Add(this.petaBrowsebtn);
            this.Controls.Add(this.signPeta);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numPicker);
            this.Controls.Add(this.popBtnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelBrowse2);
            this.Controls.Add(this.labelBrowse1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CorruptForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Corruption";
            this.Load += new System.EventHandler(this.CorruptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numPicker;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button petaBrowsebtn;
        private System.Windows.Forms.Button popBtnBrowse;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label labelBrowse1;
        private System.Windows.Forms.Label labelBrowse2;
        private System.Windows.Forms.Label signPeta;
        private System.Windows.Forms.Label popLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pathBox;
    }
}

