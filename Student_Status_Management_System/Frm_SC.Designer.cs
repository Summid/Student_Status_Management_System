namespace Student_Status_Management_System
{
    partial class Frm_SC
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
            this.DgvSC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSC)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSC
            // 
            this.DgvSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSC.Location = new System.Drawing.Point(25, 21);
            this.DgvSC.Name = "DgvSC";
            this.DgvSC.RowTemplate.Height = 23;
            this.DgvSC.Size = new System.Drawing.Size(372, 190);
            this.DgvSC.TabIndex = 0;
            // 
            // Frm_SC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 232);
            this.Controls.Add(this.DgvSC);
            this.Name = "Frm_SC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询选课";
            this.Load += new System.EventHandler(this.Frm_SC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSC;
    }
}