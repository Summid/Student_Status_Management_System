namespace Student_Status_Management_System
{
    partial class Frm_changescore
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
            this.LblCname = new System.Windows.Forms.Label();
            this.Lblstudentname = new System.Windows.Forms.Label();
            this.Lblscore = new System.Windows.Forms.Label();
            this.CbCname = new System.Windows.Forms.ComboBox();
            this.CbSname = new System.Windows.Forms.ComboBox();
            this.Txtscore = new System.Windows.Forms.TextBox();
            this.Btmchangescore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCname
            // 
            this.LblCname.AutoSize = true;
            this.LblCname.Location = new System.Drawing.Point(40, 54);
            this.LblCname.Name = "LblCname";
            this.LblCname.Size = new System.Drawing.Size(41, 12);
            this.LblCname.TabIndex = 0;
            this.LblCname.Text = "课程名";
            // 
            // Lblstudentname
            // 
            this.Lblstudentname.AutoSize = true;
            this.Lblstudentname.Location = new System.Drawing.Point(199, 54);
            this.Lblstudentname.Name = "Lblstudentname";
            this.Lblstudentname.Size = new System.Drawing.Size(53, 12);
            this.Lblstudentname.TabIndex = 1;
            this.Lblstudentname.Text = "学生姓名";
            // 
            // Lblscore
            // 
            this.Lblscore.AutoSize = true;
            this.Lblscore.Location = new System.Drawing.Point(340, 54);
            this.Lblscore.Name = "Lblscore";
            this.Lblscore.Size = new System.Drawing.Size(29, 12);
            this.Lblscore.TabIndex = 2;
            this.Lblscore.Text = "分数";
            // 
            // CbCname
            // 
            this.CbCname.FormattingEnabled = true;
            this.CbCname.Location = new System.Drawing.Point(42, 69);
            this.CbCname.Name = "CbCname";
            this.CbCname.Size = new System.Drawing.Size(121, 20);
            this.CbCname.TabIndex = 3;
            this.CbCname.SelectedValueChanged += new System.EventHandler(this.CbCname_SelectedValueChanged);
            // 
            // CbSname
            // 
            this.CbSname.FormattingEnabled = true;
            this.CbSname.Location = new System.Drawing.Point(201, 69);
            this.CbSname.Name = "CbSname";
            this.CbSname.Size = new System.Drawing.Size(121, 20);
            this.CbSname.TabIndex = 4;
            // 
            // Txtscore
            // 
            this.Txtscore.Location = new System.Drawing.Point(342, 69);
            this.Txtscore.Name = "Txtscore";
            this.Txtscore.Size = new System.Drawing.Size(100, 21);
            this.Txtscore.TabIndex = 5;
            this.Txtscore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtscore_KeyPress);
            // 
            // Btmchangescore
            // 
            this.Btmchangescore.Location = new System.Drawing.Point(367, 145);
            this.Btmchangescore.Name = "Btmchangescore";
            this.Btmchangescore.Size = new System.Drawing.Size(75, 23);
            this.Btmchangescore.TabIndex = 6;
            this.Btmchangescore.Text = "确定";
            this.Btmchangescore.UseVisualStyleBackColor = true;
            this.Btmchangescore.Click += new System.EventHandler(this.Btmchangescore_Click);
            // 
            // Frm_changescore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 180);
            this.Controls.Add(this.Btmchangescore);
            this.Controls.Add(this.Txtscore);
            this.Controls.Add(this.CbSname);
            this.Controls.Add(this.CbCname);
            this.Controls.Add(this.Lblscore);
            this.Controls.Add(this.Lblstudentname);
            this.Controls.Add(this.LblCname);
            this.Name = "Frm_changescore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩修改";
            this.Load += new System.EventHandler(this.Frm_changescore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCname;
        private System.Windows.Forms.Label Lblstudentname;
        private System.Windows.Forms.Label Lblscore;
        private System.Windows.Forms.ComboBox CbCname;
        private System.Windows.Forms.ComboBox CbSname;
        private System.Windows.Forms.TextBox Txtscore;
        private System.Windows.Forms.Button Btmchangescore;
    }
}