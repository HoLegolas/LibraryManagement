namespace LibraryManagement
{
    partial class ManagerDashboard
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
            this.staffGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aname = new System.Windows.Forms.Label();
            this.apos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // staffGridView
            // 
            this.staffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffGridView.Location = new System.Drawing.Point(12, 171);
            this.staffGridView.Name = "staffGridView";
            this.staffGridView.Size = new System.Drawing.Size(840, 301);
            this.staffGridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(200, 125);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current admin:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(720, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position:";
            // 
            // aname
            // 
            this.aname.AutoSize = true;
            this.aname.Location = new System.Drawing.Point(94, 13);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(35, 13);
            this.aname.TabIndex = 8;
            this.aname.Text = "admin";
            // 
            // apos
            // 
            this.apos.AutoSize = true;
            this.apos.Location = new System.Drawing.Point(94, 40);
            this.apos.Name = "apos";
            this.apos.Size = new System.Drawing.Size(35, 13);
            this.apos.TabIndex = 9;
            this.apos.Text = "admin";
            // 
            // ManagerDashboard
            // 
            this.ClientSize = new System.Drawing.Size(864, 535);
            this.Controls.Add(this.apos);
            this.Controls.Add(this.aname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.staffGridView);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView staffGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aname;
        private System.Windows.Forms.Label apos;
    }
}