namespace Student_Status_Management_System
{
    partial class Frm_Tscore
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
            this.DgvTscore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTscore)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTscore
            // 
            this.DgvTscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTscore.Location = new System.Drawing.Point(32, 39);
            this.DgvTscore.Name = "DgvTscore";
            this.DgvTscore.RowTemplate.Height = 23;
            this.DgvTscore.Size = new System.Drawing.Size(420, 220);
            this.DgvTscore.TabIndex = 0;
            // 
            // Frm_Tscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 285);
            this.Controls.Add(this.DgvTscore);
            this.Name = "Frm_Tscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.Frm_Tscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTscore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTscore;
    }
}