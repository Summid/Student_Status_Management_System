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
    public partial class Frm_TCPwd : Form
    {
        public Frm_TCPwd()
        {
            InitializeComponent();
        }

        private void Frm_TCPwd_Load(object sender, EventArgs e)
        {
            TxtToldPwd.Focus();
        }
        DataOperator dataOper = new DataOperator();
        private void BtmTPwd_Click(object sender, EventArgs e)
        {
            if (TxtToldPwd.Text.Trim() != "" && TxtTnewPwd.Text.Trim() != "" && TxtTconfirmPwd.Text.Trim() != "") //如果三个文本框不为空
            {
                //如果原密码正确
                if (TxtToldPwd.Text.Trim() == dataOper.ExecSQL("select Tpassword from dbo.Teacher where TID='" + PublicClass.loginID+"'"))
                {
                    //如果新密码和重复密码相等
                    if (TxtTnewPwd.Text.Trim() == TxtTconfirmPwd.Text.Trim())
                    {
                        dataOper.ExecSQLResult("update dbo.Teacher set Tpassword='" + TxtTconfirmPwd.Text.Trim() + "' where TID='" + PublicClass.loginID+"'");
                        //修改密码
                        MessageBox.Show("修改成功");
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("新密码与确认密码不同，请重试");
                    }
                }
                else
                {
                    MessageBox.Show("原密码不正确，请重试");
                }
            }
            else
            {
                MessageBox.Show("文本框不能为空");
            }
        }
    }
}
