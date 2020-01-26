namespace BookRegistrationFinal
{
    partial class addCustomerForm
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
            this.addCustDOBDTP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.addCustTitle = new System.Windows.Forms.TextBox();
            this.custFirstNameTxt = new System.Windows.Forms.TextBox();
            this.custLastNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCustDOBDTP
            // 
            this.addCustDOBDTP.Location = new System.Drawing.Point(15, 105);
            this.addCustDOBDTP.Name = "addCustDOBDTP";
            this.addCustDOBDTP.Size = new System.Drawing.Size(230, 22);
            this.addCustDOBDTP.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddCustomerFormBtn);
            // 
            // addCustTitle
            // 
            this.addCustTitle.Location = new System.Drawing.Point(124, 77);
            this.addCustTitle.Name = "addCustTitle";
            this.addCustTitle.Size = new System.Drawing.Size(121, 22);
            this.addCustTitle.TabIndex = 5;
            // 
            // custFirstNameTxt
            // 
            this.custFirstNameTxt.Location = new System.Drawing.Point(124, 21);
            this.custFirstNameTxt.Name = "custFirstNameTxt";
            this.custFirstNameTxt.Size = new System.Drawing.Size(121, 22);
            this.custFirstNameTxt.TabIndex = 6;
            // 
            // custLastNameTxt
            // 
            this.custLastNameTxt.Location = new System.Drawing.Point(124, 49);
            this.custLastNameTxt.Name = "custLastNameTxt";
            this.custLastNameTxt.Size = new System.Drawing.Size(121, 22);
            this.custLastNameTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Title: Mr/Ms/X";
            // 
            // addCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 218);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custLastNameTxt);
            this.Controls.Add(this.custFirstNameTxt);
            this.Controls.Add(this.addCustTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addCustDOBDTP);
            this.Name = "addCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker addCustDOBDTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addCustTitle;
        private System.Windows.Forms.TextBox custFirstNameTxt;
        private System.Windows.Forms.TextBox custLastNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}