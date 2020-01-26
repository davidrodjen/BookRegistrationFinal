namespace BookRegistrationFinal
{
    partial class Confirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirmConfirmBtn = new System.Windows.Forms.Button();
            this.confirmCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you would like to register?";
            // 
            // confirmConfirmBtn
            // 
            this.confirmConfirmBtn.Location = new System.Drawing.Point(86, 123);
            this.confirmConfirmBtn.Name = "confirmConfirmBtn";
            this.confirmConfirmBtn.Size = new System.Drawing.Size(157, 79);
            this.confirmConfirmBtn.TabIndex = 1;
            this.confirmConfirmBtn.Text = "Confirm";
            this.confirmConfirmBtn.UseVisualStyleBackColor = true;
            this.confirmConfirmBtn.Click += new System.EventHandler(this.confirmConfirmBtn_Click);
            // 
            // confirmCancelBtn
            // 
            this.confirmCancelBtn.Location = new System.Drawing.Point(280, 123);
            this.confirmCancelBtn.Name = "confirmCancelBtn";
            this.confirmCancelBtn.Size = new System.Drawing.Size(154, 79);
            this.confirmCancelBtn.TabIndex = 2;
            this.confirmCancelBtn.Text = "Cancel";
            this.confirmCancelBtn.UseVisualStyleBackColor = true;
            this.confirmCancelBtn.Click += new System.EventHandler(this.confirmCancelBtn_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 280);
            this.Controls.Add(this.confirmCancelBtn);
            this.Controls.Add(this.confirmConfirmBtn);
            this.Controls.Add(this.label1);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmConfirmBtn;
        private System.Windows.Forms.Button confirmCancelBtn;
    }
}