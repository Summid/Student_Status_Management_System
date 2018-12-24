namespace Student_Status_Management_System
{
    partial class Frm_Student
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
            this.LblStID = new System.Windows.Forms.Label();
            this.LblSname = new System.Windows.Forms.Label();
            this.LblSage = new System.Windows.Forms.Label();
            this.LblSsex = new System.Windows.Forms.Label();
            this.LblSbirthtime = new System.Windows.Forms.Label();
            this.LblSaddress = new System.Windows.Forms.Label();
            this.LblSclass = new System.Windows.Forms.Label();
            this.LblStel = new System.Windows.Forms.Label();
            this.LblSnation = new System.Windows.Forms.Label();
            this.LblSmajor = new System.Windows.Forms.Label();
            this.Btmscore = new System.Windows.Forms.Button();
            this.BtmSC = new System.Windows.Forms.Button();
            this.BtmSclass = new System.Windows.Forms.Button();
            this.BtmSCPwd = new System.Windows.Forms.Button();
            this.Btmlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStID
            // 
            this.LblStID.AutoSize = true;
            this.LblStID.Location = new System.Drawing.Point(88, 76);
            this.LblStID.Name = "LblStID";
            this.LblStID.Size = new System.Drawing.Size(41, 12);
            this.LblStID.TabIndex = 0;
            this.LblStID.Text = "学号：";
            // 
            // LblSname
            // 
            this.LblSname.AutoSize = true;
            this.LblSname.Location = new System.Drawing.Point(323, 76);
            this.LblSname.Name = "LblSname";
            this.LblSname.Size = new System.Drawing.Size(41, 12);
            this.LblSname.TabIndex = 1;
            this.LblSname.Text = "姓名：";
            // 
            // LblSage
            // 
            this.LblSage.AutoSize = true;
            this.LblSage.Location = new System.Drawing.Point(88, 125);
            this.LblSage.Name = "LblSage";
            this.LblSage.Size = new System.Drawing.Size(41, 12);
            this.LblSage.TabIndex = 2;
            this.LblSage.Text = "年龄：";
            // 
            // LblSsex
            // 
            this.LblSsex.AutoSize = true;
            this.LblSsex.Location = new System.Drawing.Point(325, 125);
            this.LblSsex.Name = "LblSsex";
            this.LblSsex.Size = new System.Drawing.Size(41, 12);
            this.LblSsex.TabIndex = 3;
            this.LblSsex.Text = "性别：";
            // 
            // LblSbirthtime
            // 
            this.LblSbirthtime.AutoSize = true;
            this.LblSbirthtime.Location = new System.Drawing.Point(88, 178);
            this.LblSbirthtime.Name = "LblSbirthtime";
            this.LblSbirthtime.Size = new System.Drawing.Size(65, 12);
            this.LblSbirthtime.TabIndex = 4;
            this.LblSbirthtime.Text = "出生日期：";
            // 
            // LblSaddress
            // 
            this.LblSaddress.AutoSize = true;
            this.LblSaddress.Location = new System.Drawing.Point(325, 178);
            this.LblSaddress.Name = "LblSaddress";
            this.LblSaddress.Size = new System.Drawing.Size(65, 12);
            this.LblSaddress.TabIndex = 5;
            this.LblSaddress.Text = "家庭住址：";
            // 
            // LblSclass
            // 
            this.LblSclass.AutoSize = true;
            this.LblSclass.Location = new System.Drawing.Point(88, 236);
            this.LblSclass.Name = "LblSclass";
            this.LblSclass.Size = new System.Drawing.Size(41, 12);
            this.LblSclass.TabIndex = 6;
            this.LblSclass.Text = "班级：";
            // 
            // LblStel
            // 
            this.LblStel.AutoSize = true;
            this.LblStel.Location = new System.Drawing.Point(323, 236);
            this.LblStel.Name = "LblStel";
            this.LblStel.Size = new System.Drawing.Size(65, 12);
            this.LblStel.TabIndex = 7;
            this.LblStel.Text = "联系电话：";
            // 
            // LblSnation
            // 
            this.LblSnation.AutoSize = true;
            this.LblSnation.Location = new System.Drawing.Point(88, 288);
            this.LblSnation.Name = "LblSnation";
            this.LblSnation.Size = new System.Drawing.Size(41, 12);
            this.LblSnation.TabIndex = 8;
            this.LblSnation.Text = "民族：";
            // 
            // LblSmajor
            // 
            this.LblSmajor.AutoSize = true;
            this.LblSmajor.Location = new System.Drawing.Point(323, 288);
            this.LblSmajor.Name = "LblSmajor";
            this.LblSmajor.Size = new System.Drawing.Size(41, 12);
            this.LblSmajor.TabIndex = 9;
            this.LblSmajor.Text = "专业：";
            // 
            // Btmscore
            // 
            this.Btmscore.Location = new System.Drawing.Point(54, 29);
            this.Btmscore.Name = "Btmscore";
            this.Btmscore.Size = new System.Drawing.Size(75, 23);
            this.Btmscore.TabIndex = 10;
            this.Btmscore.Text = "成绩查询";
            this.Btmscore.UseVisualStyleBackColor = true;
            this.Btmscore.Click += new System.EventHandler(this.Btmscore_Click);
            // 
            // BtmSC
            // 
            this.BtmSC.Location = new System.Drawing.Point(188, 29);
            this.BtmSC.Name = "BtmSC";
            this.BtmSC.Size = new System.Drawing.Size(75, 23);
            this.BtmSC.TabIndex = 11;
            this.BtmSC.Text = "选课查询";
            this.BtmSC.UseVisualStyleBackColor = true;
            this.BtmSC.Click += new System.EventHandler(this.BtmSC_Click);
            // 
            // BtmSclass
            // 
            this.BtmSclass.Location = new System.Drawing.Point(325, 29);
            this.BtmSclass.Name = "BtmSclass";
            this.BtmSclass.Size = new System.Drawing.Size(75, 23);
            this.BtmSclass.TabIndex = 12;
            this.BtmSclass.Text = "选课";
            this.BtmSclass.UseVisualStyleBackColor = true;
            this.BtmSclass.Click += new System.EventHandler(this.BtmSclass_Click);
            // 
            // BtmSCPwd
            // 
            this.BtmSCPwd.Location = new System.Drawing.Point(464, 29);
            this.BtmSCPwd.Name = "BtmSCPwd";
            this.BtmSCPwd.Size = new System.Drawing.Size(75, 23);
            this.BtmSCPwd.TabIndex = 13;
            this.BtmSCPwd.Text = "修改密码";
            this.BtmSCPwd.UseVisualStyleBackColor = true;
            this.BtmSCPwd.Click += new System.EventHandler(this.BtmSCPwd_Click);
            // 
            // Btmlogout
            // 
            this.Btmlogout.Location = new System.Drawing.Point(502, 306);
            this.Btmlogout.Name = "Btmlogout";
            this.Btmlogout.Size = new System.Drawing.Size(75, 23);
            this.Btmlogout.TabIndex = 14;
            this.Btmlogout.Text = "退出登录";
            this.Btmlogout.UseVisualStyleBackColor = true;
            this.Btmlogout.Click += new System.EventHandler(this.Btmlogout_Click);
            // 
            // Frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 341);
            this.Controls.Add(this.Btmlogout);
            this.Controls.Add(this.BtmSCPwd);
            this.Controls.Add(this.BtmSclass);
            this.Controls.Add(this.BtmSC);
            this.Controls.Add(this.Btmscore);
            this.Controls.Add(this.LblSmajor);
            this.Controls.Add(this.LblSnation);
            this.Controls.Add(this.LblStel);
            this.Controls.Add(this.LblSclass);
            this.Controls.Add(this.LblSaddress);
            this.Controls.Add(this.LblSbirthtime);
            this.Controls.Add(this.LblSsex);
            this.Controls.Add(this.LblSage);
            this.Controls.Add(this.LblSname);
            this.Controls.Add(this.LblStID);
            this.Name = "Frm_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生个人信息";
            this.Load += new System.EventHandler(this.Frm_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStID;
        private System.Windows.Forms.Label LblSname;
        private System.Windows.Forms.Label LblSage;
        private System.Windows.Forms.Label LblSsex;
        private System.Windows.Forms.Label LblSbirthtime;
        private System.Windows.Forms.Label LblSaddress;
        private System.Windows.Forms.Label LblSclass;
        private System.Windows.Forms.Label LblStel;
        private System.Windows.Forms.Label LblSnation;
        private System.Windows.Forms.Label LblSmajor;
        private System.Windows.Forms.Button Btmscore;
        private System.Windows.Forms.Button BtmSC;
        private System.Windows.Forms.Button BtmSclass;
        private System.Windows.Forms.Button BtmSCPwd;
        private System.Windows.Forms.Button Btmlogout;
    }
}