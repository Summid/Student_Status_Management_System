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
    public partial class Frm_Student : Form
    {
        public Frm_Student()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();  //数据库操作对象

        private void Frm_Student_Load(object sender, EventArgs e)
        {
            LblStID.Text = "学号：" + PublicClass.loginID;

            string Snamesql = "select Sname from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Sname = dataOper.ExecSQL(Snamesql);
            LblSname.Text = "姓名：" + Sname;

            string Sagesql = "select Sage from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Sage = dataOper.ExecSQL(Sagesql);
            LblSage.Text = "年龄：" + Sage;

            string Ssexsql = "select Ssex from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Ssex = dataOper.ExecSQL(Ssexsql);
            LblSsex.Text = "性别：" + Ssex;

            string Sbirthtimesql = "select Sbirthtime from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Sbirthtime = dataOper.ExecSQL(Sbirthtimesql);
            LblSbirthtime.Text = "出生日期：" + Sbirthtime;

            string Saddresssql = "select Saddress from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Saddress = dataOper.ExecSQL(Saddresssql);
            LblSaddress.Text = "家庭住址：" + Saddress;

            string Sclasssql = "select Sclass from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Sclass = dataOper.ExecSQL(Sclasssql);
            LblSclass.Text = "班级：" + Sclass;

            string Stelsql = "select Stel from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Stel = dataOper.ExecSQL(Stelsql);
            LblStel.Text = "联系电话：" + Stel;

            string Snationsql = "select Snation from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Snation = dataOper.ExecSQL(Snationsql);
            LblSnation.Text = "民族：" + Snation;

            string Smajorsql = "select Smajor from dbo.Student where StID=" + int.Parse(PublicClass.loginID);
            string Smajor = dataOper.ExecSQL(Smajorsql);
            LblSmajor.Text = "专业：" + Smajor;
        }

        private void Btmscore_Click(object sender, EventArgs e)  //查询分数
        {
            Frm_Score frm_Score = new Frm_Score();
            frm_Score.Show();
        }

        private void BtmSC_Click(object sender, EventArgs e)  //查询已选课
        {
            Frm_SC frm_SC = new Frm_SC();
            frm_SC.Show();
        }

        private void BtmSclass_Click(object sender, EventArgs e)  //选课
        {
            Frm_Sclass frm_Sclass = new Frm_Sclass();
            frm_Sclass.Show();
        }

        private void BtmSCPwd_Click(object sender, EventArgs e)  //更改密码
        {
            Frm_SCPwd frm_CPwd = new Frm_SCPwd();
            frm_CPwd.Show();
        }

        private void Btmlogout_Click(object sender, EventArgs e)  //退出登录
        {
            this.Visible = false;
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
