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
    public partial class Frm_Sclass : Form
    {
        public Frm_Sclass()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();

        private void Frm_Sclass_Load(object sender, EventArgs e)
        {
            string sql = "select CID from dbo.SC where StID=" + int.Parse(PublicClass.loginID);
            string Sql = "select * from dbo.Course where CID not in " + "(" + sql + ")";
            //因为是嵌套循环，这里不能直接写在参数列表里（第二个Sql的S是大写）
            DgvSclass.DataSource = dataOper.GetDataSet(Sql);
            //显示可以选择的课程的信息

            for(int i=0;i<dataOper.GetDataSet(Sql).Rows.Count;i++) //列出可选课程的复选框
            {
                ClbSclass.Items.Add(dataOper.GetDataSet(Sql).Rows[i][0]);  //Row[i][0]表示第i行，从左往右第一列
            }
        }

        private void BtmSclass_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClbSclass.Items.Count; i++)  //循环获得所有被选中的值，并更改选课表
            {
                if (ClbSclass.GetItemChecked(i))  //如果改行被选中
                {
                    string CID = ClbSclass.GetItemText(ClbSclass.Items[i]);
                    string Cname = dataOper.ExecSQL("select Cname from dbo.Course where CID='" + CID+"'");
                    string sql = "insert into dbo.SC (StID,CID,Cname) values('" + int.Parse(PublicClass.loginID) + "','" + CID + "','" + Cname + "')";
                    dataOper.ExecSQLResult(sql);
                }
            }
            MessageBox.Show("选课成功");
        }
    }
}
