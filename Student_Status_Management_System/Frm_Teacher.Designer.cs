namespace Student_Status_Management_System
{
    partial class Frm_Teacher
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
            this.LblTID = new System.Windows.Forms.Label();
            this.LblTname = new System.Windows.Forms.Label();
            this.LblTsex = new System.Windows.Forms.Label();
            this.Btmclass = new System.Windows.Forms.Button();
            this.BtmTscore = new System.Windows.Forms.Button();
            this.Btmchangescore = new System.Windows.Forms.Button();
            this.BtmTPwd = new System.Windows.Forms.Button();
            this.BtmTlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTID
            // 
            this.LblTID.AutoSize = true;
            this.LblTID.Location = new System.Drawing.Point(75, 87);
            this.LblTID.Name = "LblTID";
            this.LblTID.Size = new System.Drawing.Size(65, 12);
            this.LblTID.TabIndex = 0;
            this.LblTID.Text = "教师编号：";
            // 
            // LblTname
            // 
            this.LblTname.AutoSize = true;
            this.LblTname.Location = new System.Drawing.Point(278, 87);
            this.LblTname.Name = "LblTname";
            this.LblTname.Size = new System.Drawing.Size(41, 12);
            this.LblTname.TabIndex = 1;
            this.LblTname.Text = "姓名：";
            // 
            // LblTsex
            // 
            this.LblTsex.AutoSize = true;
            this.LblTsex.Location = new System.Drawing.Point(75, 155);
            this.LblTsex.Name = "LblTsex";
            this.LblTsex.Size = new System.Drawing.Size(41, 12);
            this.LblTsex.TabIndex = 2;
            this.LblTsex.Text = "性别：";
            // 
            // Btmclass
            // 
            this.Btmclass.Location = new System.Drawing.Point(41, 32);
            this.Btmclass.Name = "Btmclass";
            this.Btmclass.Size = new System.Drawing.Size(75, 23);
            this.Btmclass.TabIndex = 3;
            this.Btmclass.Text = "任课查询";
            this.Btmclass.UseVisualStyleBackColor = true;
            this.Btmclass.Click += new System.EventHandler(this.Btmclass_Click);
            // 
            // BtmTscore
            // 
            this.BtmTscore.Location = new System.Drawing.Point(165, 32);
            this.BtmTscore.Name = "BtmTscore";
            this.BtmTscore.Size = new System.Drawing.Size(75, 23);
            this.BtmTscore.TabIndex = 4;
            this.BtmTscore.Text = "成绩查询";
            this.BtmTscore.UseVisualStyleBackColor = true;
            this.BtmTscore.Click += new System.EventHandler(this.BtmTscore_Click);
            // 
            // Btmchangescore
            // 
            this.Btmchangescore.Location = new System.Drawing.Point(297, 32);
            this.Btmchangescore.Name = "Btmchangescore";
            this.Btmchangescore.Size = new System.Drawing.Size(75, 23);
            this.Btmchangescore.TabIndex = 5;
            this.Btmchangescore.Text = "成绩修改";
            this.Btmchangescore.UseVisualStyleBackColor = true;
            this.Btmchangescore.Click += new System.EventHandler(this.Btmchangescore_Click);
            // 
            // BtmTPwd
            // 
            this.BtmTPwd.Location = new System.Drawing.Point(431, 32);
            this.BtmTPwd.Name = "BtmTPwd";
            this.BtmTPwd.Size = new System.Drawing.Size(75, 23);
            this.BtmTPwd.TabIndex = 6;
            this.BtmTPwd.Text = "修改密码";
            this.BtmTPwd.UseVisualStyleBackColor = true;
            this.BtmTPwd.Click += new System.EventHandler(this.BtmTPwd_Click);
            // 
            // BtmTlogout
            // 
            this.BtmTlogout.Location = new System.Drawing.Point(431, 229);
            this.BtmTlogout.Name = "BtmTlogout";
            this.BtmTlogout.Size = new System.Drawing.Size(75, 23);
            this.BtmTlogout.TabIndex = 7;
            this.BtmTlogout.Text = "退出登录";
            this.BtmTlogout.UseVisualStyleBackColor = true;
            this.BtmTlogout.Click += new System.EventHandler(this.BtmTlogout_Click);
            // 
            // Frm_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 264);
            this.Controls.Add(this.BtmTlogout);
            this.Controls.Add(this.BtmTPwd);
            this.Controls.Add(this.Btmchangescore);
            this.Controls.Add(this.BtmTscore);
            this.Controls.Add(this.Btmclass);
            this.Controls.Add(this.LblTsex);
            this.Controls.Add(this.LblTname);
            this.Controls.Add(this.LblTID);
            this.Name = "Frm_Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师个人信息";
            this.Load += new System.EventHandler(this.Frm_Teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTID;
        private System.Windows.Forms.Label LblTname;
        private System.Windows.Forms.Label LblTsex;
        private System.Windows.Forms.Button Btmclass;
        private System.Windows.Forms.Button BtmTscore;
        private System.Windows.Forms.Button Btmchangescore;
        private System.Windows.Forms.Button BtmTPwd;
        private System.Windows.Forms.Button BtmTlogout;
    }
}