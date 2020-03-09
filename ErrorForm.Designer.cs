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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.ErrorText = new System.Windows.Forms.Label();
            this.viewError = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.Location = new System.Drawing.Point(19, 34);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(239, 32);
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
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Location = new System.Drawing.Point(69, 214);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(121, 54);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 71);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.viewError);
            this.Controls.Add(this.ErrorText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorForm";
            this.Text = "Corruption";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label viewError;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
    }
}