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
    public partial class Frm_changescore : Form
    {
        public Frm_changescore()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();
        private void Frm_changescore_Load(object sender, EventArgs e)
        {
            //设置第一个下拉列表中的课程
            for(int i=0;i<int.Parse(dataOper.ExecSQL("select count(*) from dbo.OC where TID='"+PublicClass.loginID+"'"));i++)
            {
                CbCname.Items.Add(dataOper.GetDataSet("select Cname from dbo.OC where TID='" + PublicClass.loginID + "'").Rows[i][0]);  //Rows[i][0]表示表的第i行第1个
            }
        }

        private void CbCname_SelectedValueChanged(object sender, EventArgs e)  //第一个下拉框选中项变化的时候
        {
            CbSname.Items.Clear();  //先将下拉框里的数据清除掉
            //设置第二个下拉列表中的学生
            for(int i=0;i<int.Parse(dataOper.ExecSQL("select count(*) from dbo.SC where Cname='"+CbCname.Text+"'"));i++)
            {
                CbSname.Items.Add(dataOper.GetDataSet("select StID from dbo.SC where Cname='" + CbCname.Text + "'").Rows[i][0]);
            }
        }

        private void Btmchangescore_Click(object sender, EventArgs e)
        {
            if(int.Parse(Txtscore.Text)>=0&&int.Parse(Txtscore.Text)<=100)  //如果分数在0到100之间
            {
                //修改分数
                dataOper.ExecSQLResult("update dbo.SC set score=" + Txtscore.Text + "where Cname='" + CbCname.Text + "' and StID ='" + CbSname.Text + "'");
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("分数超出范围，请重试");
            }
        }

        private void Txtscore_KeyPress(object sender, KeyPressEventArgs e)  //键盘输入事件，让文本框只能输入数字
        {
            if (char.IsDigit(e.KeyChar))  //如果是数字
                e.Handled = false;   //不处理该数字
            else
                e.Handled = true;  //处理该数字
        }
    }
}
