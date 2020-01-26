namespace BookRegistrationFinal
{
    partial class bookRegForm
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
            this.customerNameBx = new System.Windows.Forms.ComboBox();
            this.bookNameBx = new System.Windows.Forms.ComboBox();
            this.dateRegisterDtp = new System.Windows.Forms.DateTimePicker();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.registerBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameBx
            // 
            this.customerNameBx.FormattingEnabled = true;
            this.customerNameBx.Location = new System.Drawing.Point(12, 32);
            this.customerNameBx.Name = "customerNameBx";
            this.customerNameBx.Size = new System.Drawing.Size(247, 24);
            this.customerNameBx.TabIndex = 0;
            this.customerNameBx.Text = "Customer Name";
            // 
            // bookNameBx
            // 
            this.bookNameBx.FormattingEnabled = true;
            this.bookNameBx.Location = new System.Drawing.Point(12, 62);
            this.bookNameBx.Name = "bookNameBx";
            this.bookNameBx.Size = new System.Drawing.Size(247, 24);
            this.bookNameBx.TabIndex = 1;
            this.bookNameBx.Text = "Book Name";
            // 
            // dateRegisterDtp
            // 
            this.dateRegisterDtp.Location = new System.Drawing.Point(12, 92);
            this.dateRegisterDtp.Name = "dateRegisterDtp";
            this.dateRegisterDtp.Size = new System.Drawing.Size(247, 22);
            this.dateRegisterDtp.TabIndex = 2;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(265, 32);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(151, 57);
            this.addCustomerBtn.TabIndex = 3;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(265, 101);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(151, 57);
            this.addBookBtn.TabIndex = 4;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // registerBookBtn
            // 
            this.registerBookBtn.Location = new System.Drawing.Point(12, 120);
            this.registerBookBtn.Name = "registerBookBtn";
            this.registerBookBtn.Size = new System.Drawing.Size(247, 61);
            this.registerBookBtn.TabIndex = 5;
            this.registerBookBtn.Text = "Register Book";
            this.registerBookBtn.UseVisualStyleBackColor = true;
            this.registerBookBtn.Click += new System.EventHandler(this.RegisterBookBtn_Click);
            // 
            // bookRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 254);
            this.Controls.Add(this.registerBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.dateRegisterDtp);
            this.Controls.Add(this.bookNameBx);
            this.Controls.Add(this.customerNameBx);
            this.Name = "bookRegForm";
            this.Text = "Book Registration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox customerNameBx;
        private System.Windows.Forms.ComboBox bookNameBx;
        private System.Windows.Forms.DateTimePicker dateRegisterDtp;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button registerBookBtn;
    }
}

