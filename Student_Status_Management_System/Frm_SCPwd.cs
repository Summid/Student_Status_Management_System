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
    public partial class Frm_SCPwd : Form
    {
        public Frm_SCPwd()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();

        private void Frm_CPwd_Load(object sender, EventArgs e)
        {
            TxtoldPwd.Focus();
        }

        private void BtmCPwd_Click(object sender, EventArgs e)
        {
            if(TxtoldPwd.Text.Trim()!=""&&TxtnewPwd.Text.Trim()!=""&&TxtconfirmPwd.Text.Trim()!="") //如果三个文本框不为空
            {
                //如果原密码正确
                if(TxtoldPwd.Text.Trim()==dataOper.ExecSQL("select Spassword from dbo.Student where StID="+int.Parse(PublicClass.loginID)))
                {
                    //如果新密码和重复密码相等
                    if(TxtnewPwd.Text.Trim()==TxtconfirmPwd.Text.Trim())
                    {
                        dataOper.ExecSQLResult("update dbo.Student set Spassword='" + TxtconfirmPwd.Text.Trim() + "' where StID=" + int.Parse(PublicClass.loginID));
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
