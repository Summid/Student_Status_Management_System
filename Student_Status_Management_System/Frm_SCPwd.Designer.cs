namespace Student_Status_Management_System
{
    partial class Frm_SCPwd
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
            this.LbloldPwd = new System.Windows.Forms.Label();
            this.LblnewPwd = new System.Windows.Forms.Label();
            this.LblconfirmPwd = new System.Windows.Forms.Label();
            this.TxtoldPwd = new System.Windows.Forms.TextBox();
            this.TxtnewPwd = new System.Windows.Forms.TextBox();
            this.TxtconfirmPwd = new System.Windows.Forms.TextBox();
            this.BtmSCPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbloldPwd
            // 
            this.LbloldPwd.AutoSize = true;
            this.LbloldPwd.Location = new System.Drawing.Point(109, 58);
            this.LbloldPwd.Name = "LbloldPwd";
            this.LbloldPwd.Size = new System.Drawing.Size(53, 12);
            this.LbloldPwd.TabIndex = 0;
            this.LbloldPwd.Text = "原密码：";
            // 
            // LblnewPwd
            // 
            this.LblnewPwd.AutoSize = true;
            this.LblnewPwd.Location = new System.Drawing.Point(109, 106);
            this.LblnewPwd.Name = "LblnewPwd";
            this.LblnewPwd.Size = new System.Drawing.Size(53, 12);
            this.LblnewPwd.TabIndex = 1;
            this.LblnewPwd.Text = "新密码：";
            // 
            // LblconfirmPwd
            // 
            this.LblconfirmPwd.AutoSize = true;
            this.LblconfirmPwd.Location = new System.Drawing.Point(97, 152);
            this.LblconfirmPwd.Name = "LblconfirmPwd";
            this.LblconfirmPwd.Size = new System.Drawing.Size(65, 12);
            this.LblconfirmPwd.TabIndex = 2;
            this.LblconfirmPwd.Text = "确认密码：";
            // 
            // TxtoldPwd
            // 
            this.TxtoldPwd.Location = new System.Drawing.Point(168, 55);
            this.TxtoldPwd.Name = "TxtoldPwd";
            this.TxtoldPwd.PasswordChar = '*';
            this.TxtoldPwd.Size = new System.Drawing.Size(140, 21);
            this.TxtoldPwd.TabIndex = 3;
            // 
            // TxtnewPwd
            // 
            this.TxtnewPwd.Location = new System.Drawing.Point(168, 103);
            this.TxtnewPwd.Name = "TxtnewPwd";
            this.TxtnewPwd.PasswordChar = '*';
            this.TxtnewPwd.Size = new System.Drawing.Size(140, 21);
            this.TxtnewPwd.TabIndex = 4;
            // 
            // TxtconfirmPwd
            // 
            this.TxtconfirmPwd.Location = new System.Drawing.Point(168, 149);
            this.TxtconfirmPwd.Name = "TxtconfirmPwd";
            this.TxtconfirmPwd.PasswordChar = '*';
            this.TxtconfirmPwd.Size = new System.Drawing.Size(140, 21);
            this.TxtconfirmPwd.TabIndex = 5;
            // 
            // BtmSCPwd
            // 
            this.BtmSCPwd.Location = new System.Drawing.Point(168, 198);
            this.BtmSCPwd.Name = "BtmSCPwd";
            this.BtmSCPwd.Size = new System.Drawing.Size(75, 23);
            this.BtmSCPwd.TabIndex = 6;
            this.BtmSCPwd.Text = "确定";
            this.BtmSCPwd.UseVisualStyleBackColor = true;
            this.BtmSCPwd.Click += new System.EventHandler(this.BtmCPwd_Click);
            // 
            // Frm_SCPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 233);
            this.Controls.Add(this.BtmSCPwd);
            this.Controls.Add(this.TxtconfirmPwd);
            this.Controls.Add(this.TxtnewPwd);
            this.Controls.Add(this.TxtoldPwd);
            this.Controls.Add(this.LblconfirmPwd);
            this.Controls.Add(this.LblnewPwd);
            this.Controls.Add(this.LbloldPwd);
            this.Name = "Frm_SCPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Frm_CPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbloldPwd;
        private System.Windows.Forms.Label LblnewPwd;
        private System.Windows.Forms.Label LblconfirmPwd;
        private System.Windows.Forms.TextBox TxtoldPwd;
        private System.Windows.Forms.TextBox TxtnewPwd;
        private System.Windows.Forms.TextBox TxtconfirmPwd;
        private System.Windows.Forms.Button BtmSCPwd;
    }
}