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
            this.numPicker = new System.Windows.Forms.NumericUpDown();
            this.labelText = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // numPicker
            // 
            this.numPicker.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPicker.Location = new System.Drawing.Point(262, 93);
            this.numPicker.Name = "numPicker";
            this.numPicker.ReadOnly = true;
            this.numPicker.Size = new System.Drawing.Size(120, 32);
            this.numPicker.TabIndex = 0;
            this.numPicker.ValueChanged += new System.EventHandler(this.numPicker_ValueChanged);
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(79, 92);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(138, 33);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Insert Time : ";
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(171, 179);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(130, 70);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Simulate";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(498, 339);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.numPicker);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numPicker;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button submitButton;
    }
}

