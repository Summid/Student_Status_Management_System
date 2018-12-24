namespace Student_Status_Management_System
{
    partial class Frm_Login
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
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblPwd = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.RbtmTeacher = new System.Windows.Forms.RadioButton();
            this.RbtmStudent = new System.Windows.Forms.RadioButton();
            this.BtmLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(114, 65);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(53, 12);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "登录账号";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(173, 62);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(160, 21);
            this.TxtID.TabIndex = 1;
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(114, 108);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(53, 12);
            this.LblPwd.TabIndex = 2;
            this.LblPwd.Text = "登录密码";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(173, 105);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(160, 21);
            this.TxtPwd.TabIndex = 3;
            // 
            // RbtmTeacher
            // 
            this.RbtmTeacher.AutoSize = true;
            this.RbtmTeacher.Location = new System.Drawing.Point(173, 155);
            this.RbtmTeacher.Name = "RbtmTeacher";
            this.RbtmTeacher.Size = new System.Drawing.Size(47, 16);
            this.RbtmTeacher.TabIndex = 4;
            this.RbtmTeacher.TabStop = true;
            this.RbtmTeacher.Text = "教师";
            this.RbtmTeacher.UseVisualStyleBackColor = true;
            // 
            // RbtmStudent
            // 
            this.RbtmStudent.AutoSize = true;
            this.RbtmStudent.Location = new System.Drawing.Point(249, 155);
            this.RbtmStudent.Name = "RbtmStudent";
            this.RbtmStudent.Size = new System.Drawing.Size(47, 16);
            this.RbtmStudent.TabIndex = 5;
            this.RbtmStudent.TabStop = true;
            this.RbtmStudent.Text = "学生";
            this.RbtmStudent.UseVisualStyleBackColor = true;
            // 
            // BtmLogin
            // 
            this.BtmLogin.Location = new System.Drawing.Point(173, 208);
            this.BtmLogin.Name = "BtmLogin";
            this.BtmLogin.Size = new System.Drawing.Size(75, 23);
            this.BtmLogin.TabIndex = 6;
            this.BtmLogin.Text = "登录";
            this.BtmLogin.UseVisualStyleBackColor = true;
            this.BtmLogin.Click += new System.EventHandler(this.BtmLogin_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 266);
            this.Controls.Add(this.BtmLogin);
            this.Controls.Add(this.RbtmStudent);
            this.Controls.Add(this.RbtmTeacher);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblID);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.RadioButton RbtmTeacher;
        private System.Windows.Forms.RadioButton RbtmStudent;
        private System.Windows.Forms.Button BtmLogin;
    }
}