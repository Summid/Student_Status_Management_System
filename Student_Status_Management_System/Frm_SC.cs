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
    public partial class Frm_SC : Form
    {
        public Frm_SC()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();

        private void Frm_SC_Load(object sender, EventArgs e)
        {
            DgvSC.DataSource = dataOper.GetDataSet("select CID,Cname from dbo.SC where StID=" + int.Parse(PublicClass.loginID));
            //在datagridview控件里显示选课表
        }
    }
}
