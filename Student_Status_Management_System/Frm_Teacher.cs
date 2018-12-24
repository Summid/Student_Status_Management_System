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
    public partial class Frm_Teacher : Form
    {
        public Frm_Teacher()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();
        private void Frm_Teacher_Load(object sender, EventArgs e)
        {
            LblTID.Text = "教师编号：" + PublicClass.loginID;

            LblTname.Text = "姓名：" + dataOper.ExecSQL("select Tname from dbo.Teacher where TID='" + PublicClass.loginID+"'");

            LblTsex.Text = "性别：" + dataOper.ExecSQL("select Tsex from dbo.Teacher where TID='" + PublicClass.loginID+"'");
        }

        private void Btmclass_Click(object sender, EventArgs e)  //任课查询
        {
            Frm_Tclass frm_Tclass = new Frm_Tclass();
            frm_Tclass.Show();
        }

        private void BtmTscore_Click(object sender, EventArgs e)  //成绩查询
        {
            Frm_Tscore frm_Tscore = new Frm_Tscore();
            frm_Tscore.Show();
        }

        private void Btmchangescore_Click(object sender, EventArgs e)  //修改成绩
        {
            Frm_changescore frm_Changescore = new Frm_changescore();
            frm_Changescore.Show();
        }

        private void BtmTPwd_Click(object sender, EventArgs e)  //修改密码
        {
            Frm_TCPwd frm_TCPwd = new Frm_TCPwd();
            frm_TCPwd.Show();
        }

        private void BtmTlogout_Click(object sender, EventArgs e)  //退出登录
        {
            this.Visible = false;
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
