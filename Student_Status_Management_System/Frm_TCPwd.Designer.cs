namespace Student_Status_Management_System
{
    partial class Frm_TCPwd
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
            this.LblToldPwd = new System.Windows.Forms.Label();
            this.LblTnewPwd = new System.Windows.Forms.Label();
            this.LblTconfirmPwd = new System.Windows.Forms.Label();
            this.TxtToldPwd = new System.Windows.Forms.TextBox();
            this.TxtTnewPwd = new System.Windows.Forms.TextBox();
            this.TxtTconfirmPwd = new System.Windows.Forms.TextBox();
            this.BtmTPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblToldPwd
            // 
            this.LblToldPwd.AutoSize = true;
            this.LblToldPwd.Location = new System.Drawing.Point(117, 75);
            this.LblToldPwd.Name = "LblToldPwd";
            this.LblToldPwd.Size = new System.Drawing.Size(53, 12);
            this.LblToldPwd.TabIndex = 0;
            this.LblToldPwd.Text = "原密码：";
            // 
            // LblTnewPwd
            // 
            this.LblTnewPwd.AutoSize = true;
            this.LblTnewPwd.Location = new System.Drawing.Point(117, 124);
            this.LblTnewPwd.Name = "LblTnewPwd";
            this.LblTnewPwd.Size = new System.Drawing.Size(53, 12);
            this.LblTnewPwd.TabIndex = 1;
            this.LblTnewPwd.Text = "新密码：";
            // 
            // LblTconfirmPwd
            // 
            this.LblTconfirmPwd.AutoSize = true;
            this.LblTconfirmPwd.Location = new System.Drawing.Point(105, 179);
            this.LblTconfirmPwd.Name = "LblTconfirmPwd";
            this.LblTconfirmPwd.Size = new System.Drawing.Size(65, 12);
            this.LblTconfirmPwd.TabIndex = 2;
            this.LblTconfirmPwd.Text = "确认密码：";
            // 
            // TxtToldPwd
            // 
            this.TxtToldPwd.Location = new System.Drawing.Point(176, 72);
            this.TxtToldPwd.Name = "TxtToldPwd";
            this.TxtToldPwd.PasswordChar = '*';
            this.TxtToldPwd.Size = new System.Drawing.Size(156, 21);
            this.TxtToldPwd.TabIndex = 3;
            // 
            // TxtTnewPwd
            // 
            this.TxtTnewPwd.Location = new System.Drawing.Point(176, 124);
            this.TxtTnewPwd.Name = "TxtTnewPwd";
            this.TxtTnewPwd.PasswordChar = '*';
            this.TxtTnewPwd.Size = new System.Drawing.Size(156, 21);
            this.TxtTnewPwd.TabIndex = 4;
            // 
            // TxtTconfirmPwd
            // 
            this.TxtTconfirmPwd.Location = new System.Drawing.Point(176, 176);
            this.TxtTconfirmPwd.Name = "TxtTconfirmPwd";
            this.TxtTconfirmPwd.PasswordChar = '*';
            this.TxtTconfirmPwd.Size = new System.Drawing.Size(156, 21);
            this.TxtTconfirmPwd.TabIndex = 5;
            // 
            // BtmTPwd
            // 
            this.BtmTPwd.Location = new System.Drawing.Point(176, 223);
            this.BtmTPwd.Name = "BtmTPwd";
            this.BtmTPwd.Size = new System.Drawing.Size(75, 23);
            this.BtmTPwd.TabIndex = 6;
            this.BtmTPwd.Text = "确定";
            this.BtmTPwd.UseVisualStyleBackColor = true;
            this.BtmTPwd.Click += new System.EventHandler(this.BtmTPwd_Click);
            // 
            // Frm_TCPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 258);
            this.Controls.Add(this.BtmTPwd);
            this.Controls.Add(this.TxtTconfirmPwd);
            this.Controls.Add(this.TxtTnewPwd);
            this.Controls.Add(this.TxtToldPwd);
            this.Controls.Add(this.LblTconfirmPwd);
            this.Controls.Add(this.LblTnewPwd);
            this.Controls.Add(this.LblToldPwd);
            this.Name = "Frm_TCPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Frm_TCPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblToldPwd;
        private System.Windows.Forms.Label LblTnewPwd;
        private System.Windows.Forms.Label LblTconfirmPwd;
        private System.Windows.Forms.TextBox TxtToldPwd;
        private System.Windows.Forms.TextBox TxtTnewPwd;
        private System.Windows.Forms.TextBox TxtTconfirmPwd;
        private System.Windows.Forms.Button BtmTPwd;
    }
}