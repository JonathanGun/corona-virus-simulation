namespace Corruption
{
    partial class ErrorForm
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
            this.ErrorText = new System.Windows.Forms.Label();
            this.viewError = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.Location = new System.Drawing.Point(30, 34);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(221, 34);
            this.ErrorText.TabIndex = 0;
            this.ErrorText.Text = "Error Happened!";
            // 
            // viewError
            // 
            this.viewError.AutoSize = true;
            this.viewError.Location = new System.Drawing.Point(111, 108);
            this.viewError.Name = "viewError";
            this.viewError.Size = new System.Drawing.Size(0, 17);
            this.viewError.TabIndex = 1;
            this.viewError.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(69, 214);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(121, 54);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 317);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.viewError);
            this.Controls.Add(this.ErrorText);
            this.Name = "ErrorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label viewError;
        private System.Windows.Forms.Button closeBtn;
    }
}