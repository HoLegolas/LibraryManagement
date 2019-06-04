namespace LibraryManagement
{
    partial class LibraryManagement
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
            this.loginlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForget = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.readerLogin = new System.Windows.Forms.RadioButton();
            this.adminLogin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.Location = new System.Drawing.Point(400, 50);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(67, 20);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(273, 196);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(330, 22);
            this.txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(273, 228);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(330, 22);
            this.txtpassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(391, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForget
            // 
            this.btnForget.Location = new System.Drawing.Point(286, 391);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(111, 30);
            this.btnForget.TabIndex = 7;
            this.btnForget.Text = "Forgot password ?";
            this.btnForget.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(447, 391);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 30);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // readerLogin
            // 
            this.readerLogin.AutoSize = true;
            this.readerLogin.Checked = true;
            this.readerLogin.Location = new System.Drawing.Point(47, 25);
            this.readerLogin.Name = "readerLogin";
            this.readerLogin.Size = new System.Drawing.Size(86, 21);
            this.readerLogin.TabIndex = 9;
            this.readerLogin.TabStop = true;
            this.readerLogin.Text = "READER";
            this.readerLogin.UseVisualStyleBackColor = true;
            // 
            // adminLogin
            // 
            this.adminLogin.AutoSize = true;
            this.adminLogin.Location = new System.Drawing.Point(47, 50);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(72, 21);
            this.adminLogin.TabIndex = 10;
            this.adminLogin.TabStop = true;
            this.adminLogin.Text = "ADMIN";
            this.adminLogin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sign in as:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(377, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 90);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LibraryManagement
            // 
            this.ClientSize = new System.Drawing.Size(867, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.readerLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginlabel);
            this.Name = "LibraryManagement";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LibraryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton readerLogin;
        private System.Windows.Forms.RadioButton adminLogin;
        private System.Windows.Forms.Label label3;
    }
}

