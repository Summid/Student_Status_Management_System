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
    public partial class Frm_Tclass : Form
    {
        public Frm_Tclass()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();
        private void Frm_Tclass_Load(object sender, EventArgs e)
        {
            DgvTclass.DataSource = dataOper.GetDataSet("select * from dbo.OC where TID='" + PublicClass.loginID + "'");
            //将查询结果输出到datagridview控件
        }
    }
}
