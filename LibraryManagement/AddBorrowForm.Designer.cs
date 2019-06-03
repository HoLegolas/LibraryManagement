﻿namespace LibraryManagement
{
    partial class AddBorrowForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBorrowid = new System.Windows.Forms.TextBox();
            this.txtReaderid = new System.Windows.Forms.TextBox();
            this.txtBookid = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đọc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // txtBorrowid
            // 
            this.txtBorrowid.Location = new System.Drawing.Point(112, 10);
            this.txtBorrowid.Name = "txtBorrowid";
            this.txtBorrowid.Size = new System.Drawing.Size(129, 20);
            this.txtBorrowid.TabIndex = 4;
            // 
            // txtReaderid
            // 
            this.txtReaderid.Location = new System.Drawing.Point(112, 48);
            this.txtReaderid.Name = "txtReaderid";
            this.txtReaderid.Size = new System.Drawing.Size(129, 20);
            this.txtReaderid.TabIndex = 5;
            // 
            // txtBookid
            // 
            this.txtBookid.Location = new System.Drawing.Point(112, 86);
            this.txtBookid.Name = "txtBookid";
            this.txtBookid.Size = new System.Drawing.Size(129, 20);
            this.txtBookid.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(237, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày trả";
            // 
            // borrowDate
            // 
            this.borrowDate.Enabled = false;
            this.borrowDate.Location = new System.Drawing.Point(112, 123);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(200, 20);
            this.borrowDate.TabIndex = 11;
            // 
            // returnDate
            // 
            this.returnDate.Enabled = false;
            this.returnDate.Location = new System.Drawing.Point(112, 155);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 20);
            this.returnDate.TabIndex = 12;
            // 
            // AddBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 299);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBookid);
            this.Controls.Add(this.txtReaderid);
            this.Controls.Add(this.txtBorrowid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBorrowForm";
            this.Text = "AddBorrowForm";
            this.Load += new System.EventHandler(this.AddBorrowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBorrowid;
        private System.Windows.Forms.TextBox txtReaderid;
        private System.Windows.Forms.TextBox txtBookid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker borrowDate;
        private System.Windows.Forms.DateTimePicker returnDate;
    }
}