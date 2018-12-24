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
    public partial class Frm_Score : Form
    {
        public Frm_Score()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();

        private void Frm_Score_Load(object sender, EventArgs e)
        {
            Dgvscore.DataSource = dataOper.GetDataSet("select score,Cname from dbo.SC where score is not NULL and StID=" + int.Parse(PublicClass.loginID));
            //在DataGridView控件里显示成绩表
        }

        
    }
}
