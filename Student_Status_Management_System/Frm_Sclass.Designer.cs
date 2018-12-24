namespace Student_Status_Management_System
{
    partial class Frm_Sclass
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
            this.DgvSclass = new System.Windows.Forms.DataGridView();
            this.LblASclass = new System.Windows.Forms.Label();
            this.LblSclass = new System.Windows.Forms.Label();
            this.ClbSclass = new System.Windows.Forms.CheckedListBox();
            this.BtmSclass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSclass)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSclass
            // 
            this.DgvSclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSclass.Location = new System.Drawing.Point(23, 29);
            this.DgvSclass.Name = "DgvSclass";
            this.DgvSclass.RowTemplate.Height = 23;
            this.DgvSclass.Size = new System.Drawing.Size(421, 223);
            this.DgvSclass.TabIndex = 0;
            // 
            // LblASclass
            // 
            this.LblASclass.AutoSize = true;
            this.LblASclass.Location = new System.Drawing.Point(21, 9);
            this.LblASclass.Name = "LblASclass";
            this.LblASclass.Size = new System.Drawing.Size(53, 12);
            this.LblASclass.TabIndex = 1;
            this.LblASclass.Text = "可选课程";
            // 
            // LblSclass
            // 
            this.LblSclass.AutoSize = true;
            this.LblSclass.Location = new System.Drawing.Point(487, 9);
            this.LblSclass.Name = "LblSclass";
            this.LblSclass.Size = new System.Drawing.Size(53, 12);
            this.LblSclass.TabIndex = 2;
            this.LblSclass.Text = "在此选课";
            // 
            // ClbSclass
            // 
            this.ClbSclass.CheckOnClick = true;
            this.ClbSclass.FormattingEnabled = true;
            this.ClbSclass.Location = new System.Drawing.Point(489, 29);
            this.ClbSclass.Name = "ClbSclass";
            this.ClbSclass.Size = new System.Drawing.Size(136, 228);
            this.ClbSclass.TabIndex = 3;
            // 
            // BtmSclass
            // 
            this.BtmSclass.Location = new System.Drawing.Point(489, 285);
            this.BtmSclass.Name = "BtmSclass";
            this.BtmSclass.Size = new System.Drawing.Size(75, 23);
            this.BtmSclass.TabIndex = 4;
            this.BtmSclass.Text = "确认选课";
            this.BtmSclass.UseVisualStyleBackColor = true;
            this.BtmSclass.Click += new System.EventHandler(this.BtmSclass_Click);
            // 
            // Frm_Sclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 368);
            this.Controls.Add(this.BtmSclass);
            this.Controls.Add(this.ClbSclass);
            this.Controls.Add(this.LblSclass);
            this.Controls.Add(this.LblASclass);
            this.Controls.Add(this.DgvSclass);
            this.Name = "Frm_Sclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课";
            this.Load += new System.EventHandler(this.Frm_Sclass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSclass;
        private System.Windows.Forms.Label LblASclass;
        private System.Windows.Forms.Label LblSclass;
        private System.Windows.Forms.CheckedListBox ClbSclass;
        private System.Windows.Forms.Button BtmSclass;
    }
}