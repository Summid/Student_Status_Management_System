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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();  //创建数据库操作对象

        private void BtmLogin_Click(object sender, EventArgs e)
        {
            if(RbtmStudent.Checked)  //如果选择的是学生登录
            {
                string sql = "select count(*) from dbo.Student where StID='" +
                    TxtID.Text + "' and Spassword = '" + TxtPwd.Text + "'";
                string result = dataOper.ExecSQL(sql);
                if(result=="1")
                {
                    PublicClass.loginID = TxtID.Text;
                    Frm_Student frm_Student = new Frm_Student();
                    frm_Student.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("请输入正确的账号和密码");
                }
            }
            if(RbtmTeacher.Checked)  //如果选择的是教师登录
            {
                string sql = "select count(*) from dbo.Teacher where TID= '" +
                    TxtID.Text + "' and Tpassword = '" + TxtPwd.Text + "'";
                string result = dataOper.ExecSQL(sql);
                if (result == "1")
                {
                    PublicClass.loginID = TxtID.Text;
                    Frm_Teacher frm_Teacher = new Frm_Teacher();
                    frm_Teacher.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("请输入正确的账号和密码");
                }
            }
            if(!RbtmStudent.Checked&&!RbtmTeacher.Checked)
            {
                MessageBox.Show("请选择登录用户类别");
            }
        }
    }
}
