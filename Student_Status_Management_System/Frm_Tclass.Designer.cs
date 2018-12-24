namespace Student_Status_Management_System
{
    partial class Frm_Tclass
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
            this.DgvTclass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTclass)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTclass
            // 
            this.DgvTclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTclass.Location = new System.Drawing.Point(46, 32);
            this.DgvTclass.Name = "DgvTclass";
            this.DgvTclass.RowTemplate.Height = 23;
            this.DgvTclass.Size = new System.Drawing.Size(393, 229);
            this.DgvTclass.TabIndex = 0;
            // 
            // Frm_Tclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 286);
            this.Controls.Add(this.DgvTclass);
            this.Name = "Frm_Tclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任课查询";
            this.Load += new System.EventHandler(this.Frm_Tclass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTclass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTclass;
    }
}