using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Status_Management_System
{
    public partial class Frm_Tscore : Form
    {
        public Frm_Tscore()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();
        private void Frm_Tscore_Load(object sender, EventArgs e)
        {
            string CID = "select CID from dbo.OC where TID='" + PublicClass.loginID + "'";
            string sql = "select * from dbo.SC where  CID in " + "(" + CID+")";
            DgvTscore.DataSource = dataOper.GetDataSet(sql);
        }
    }
}
