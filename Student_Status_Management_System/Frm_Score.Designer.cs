namespace Student_Status_Management_System
{
    partial class Frm_Score
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
            this.Dgvscore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvscore)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvscore
            // 
            this.Dgvscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvscore.Location = new System.Drawing.Point(12, 12);
            this.Dgvscore.Name = "Dgvscore";
            this.Dgvscore.RowTemplate.Height = 23;
            this.Dgvscore.Size = new System.Drawing.Size(421, 209);
            this.Dgvscore.TabIndex = 0;
           
            // 
            // Frm_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 251);
            this.Controls.Add(this.Dgvscore);
            this.Name = "Frm_Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.Frm_Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvscore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgvscore;
    }
}