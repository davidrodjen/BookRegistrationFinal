namespace BookRegistrationFinal
{
    partial class addBookForm
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
            this.addBookIsbnTxt = new System.Windows.Forms.TextBox();
            this.addBookPriceTxt = new System.Windows.Forms.TextBox();
            this.addBookTitleTxt = new System.Windows.Forms.TextBox();
            this.addBookFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBookIsbnTxt
            // 
            this.addBookIsbnTxt.Location = new System.Drawing.Point(67, 37);
            this.addBookIsbnTxt.Name = "addBookIsbnTxt";
            this.addBookIsbnTxt.Size = new System.Drawing.Size(165, 22);
            this.addBookIsbnTxt.TabIndex = 0;
            // 
            // addBookPriceTxt
            // 
            this.addBookPriceTxt.Location = new System.Drawing.Point(67, 75);
            this.addBookPriceTxt.Name = "addBookPriceTxt";
            this.addBookPriceTxt.Size = new System.Drawing.Size(165, 22);
            this.addBookPriceTxt.TabIndex = 1;
            // 
            // addBookTitleTxt
            // 
            this.addBookTitleTxt.Location = new System.Drawing.Point(67, 112);
            this.addBookTitleTxt.Name = "addBookTitleTxt";
            this.addBookTitleTxt.Size = new System.Drawing.Size(165, 22);
            this.addBookTitleTxt.TabIndex = 2;
            // 
            // addBookFormBtn
            // 
            this.addBookFormBtn.Location = new System.Drawing.Point(238, 37);
            this.addBookFormBtn.Name = "addBookFormBtn";
            this.addBookFormBtn.Size = new System.Drawing.Size(106, 97);
            this.addBookFormBtn.TabIndex = 3;
            this.addBookFormBtn.Text = "Add Book";
            this.addBookFormBtn.UseVisualStyleBackColor = true;
            this.addBookFormBtn.Click += new System.EventHandler(this.AddBookFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // addBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBookFormBtn);
            this.Controls.Add(this.addBookTitleTxt);
            this.Controls.Add(this.addBookPriceTxt);
            this.Controls.Add(this.addBookIsbnTxt);
            this.Name = "addBookForm";
            this.Text = "Add Book Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addBookIsbnTxt;
        private System.Windows.Forms.TextBox addBookPriceTxt;
        private System.Windows.Forms.TextBox addBookTitleTxt;
        private System.Windows.Forms.Button addBookFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}