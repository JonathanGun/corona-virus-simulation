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
            ((System.ComponentModel.ISupportInitialize)(this.numPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // numPicker
            // 
            this.numPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPicker.Location = new System.Drawing.Point(415, 98);
            this.numPicker.Name = "numPicker";
            this.numPicker.Size = new System.Drawing.Size(120, 52);
            this.numPicker.TabIndex = 0;
            this.numPicker.ValueChanged += new System.EventHandler(this.numPicker_ValueChanged);
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(53, 98);
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
            this.submitButton.Location = new System.Drawing.Point(136, 402);
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
            this.petaBrowsebtn.Location = new System.Drawing.Point(415, 188);
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
            this.popBtnBrowse.Location = new System.Drawing.Point(415, 299);
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
            this.Reset.Location = new System.Drawing.Point(379, 402);
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
            this.labelBrowse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowse1.Location = new System.Drawing.Point(53, 188);
            this.labelBrowse1.Name = "labelBrowse1";
            this.labelBrowse1.Size = new System.Drawing.Size(175, 32);
            this.labelBrowse1.TabIndex = 6;
            this.labelBrowse1.Text = "Peta Config";
            // 
            // labelBrowse2
            // 
            this.labelBrowse2.AutoSize = true;
            this.labelBrowse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowse2.Location = new System.Drawing.Point(53, 299);
            this.labelBrowse2.Name = "labelBrowse2";
            this.labelBrowse2.Size = new System.Drawing.Size(259, 32);
            this.labelBrowse2.TabIndex = 7;
            this.labelBrowse2.Text = "Population Config";
            // 
            // signPeta
            // 
            this.signPeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signPeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signPeta.Location = new System.Drawing.Point(61, 222);
            this.signPeta.Name = "signPeta";
            this.signPeta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signPeta.Size = new System.Drawing.Size(474, 32);
            this.signPeta.TabIndex = 8;
            this.signPeta.Text = "-";
            this.signPeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // popLabel
            // 
            this.popLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popLabel.Location = new System.Drawing.Point(66, 337);
            this.popLabel.Name = "popLabel";
            this.popLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popLabel.Size = new System.Drawing.Size(469, 28);
            this.popLabel.TabIndex = 9;
            this.popLabel.Text = "-";
            this.popLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.popLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 11);
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
            this.mainPanel.Location = new System.Drawing.Point(595, 96);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(488, 389);
            this.mainPanel.TabIndex = 11;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CorruptForm
            // 
            this.ClientSize = new System.Drawing.Size(1106, 509);
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
    }
}

