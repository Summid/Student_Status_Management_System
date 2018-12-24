namespace Student_Status_Management_System
{
    partial class Frm_LoginDB
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LblLoginDB = new System.Windows.Forms.Label();
            this.TxtLoginDB = new System.Windows.Forms.TextBox();
            this.BtmLoginDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblLoginDB
            // 
            this.LblLoginDB.AutoSize = true;
            this.LblLoginDB.Location = new System.Drawing.Point(97, 66);
            this.LblLoginDB.Name = "LblLoginDB";
            this.LblLoginDB.Size = new System.Drawing.Size(113, 12);
            this.LblLoginDB.TabIndex = 0;
            this.LblLoginDB.Text = "请输入服务器IP地址";
            // 
            // TxtLoginDB
            // 
            this.TxtLoginDB.Location = new System.Drawing.Point(99, 91);
            this.TxtLoginDB.Name = "TxtLoginDB";
            this.TxtLoginDB.Size = new System.Drawing.Size(167, 21);
            this.TxtLoginDB.TabIndex = 1;
            // 
            // BtmLoginDB
            // 
            this.BtmLoginDB.Location = new System.Drawing.Point(99, 142);
            this.BtmLoginDB.Name = "BtmLoginDB";
            this.BtmLoginDB.Size = new System.Drawing.Size(75, 23);
            this.BtmLoginDB.TabIndex = 2;
            this.BtmLoginDB.Text = "确定";
            this.BtmLoginDB.UseVisualStyleBackColor = true;
            this.BtmLoginDB.Click += new System.EventHandler(this.BtmLoginDB_Click);
            // 
            // Frm_LoginDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 200);
            this.Controls.Add(this.BtmLoginDB);
            this.Controls.Add(this.TxtLoginDB);
            this.Controls.Add(this.LblLoginDB);
            this.Name = "Frm_LoginDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录服务器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLoginDB;
        private System.Windows.Forms.TextBox TxtLoginDB;
        private System.Windows.Forms.Button BtmLoginDB;
    }
}

