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
    public partial class Frm_LoginDB : Form
    {
        public Frm_LoginDB()
        {
            InitializeComponent();
        }

        private void BtmLoginDB_Click(object sender, EventArgs e)
        {
            PublicClass.loginDB = TxtLoginDB.Text;
            Frm_Login frm_Login = new Frm_Login(); //实例化登录窗体
            frm_Login.Show();  //显示登录窗体
            this.Visible = false;  //隐藏该窗体
        }
    }
}
