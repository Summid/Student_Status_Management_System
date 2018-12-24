using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Student_Status_Management_System
{
    class DataOperator
    {
        private static string connString = "Server=" + PublicClass.loginDB + ";Database=db_Student_Status;User ID=sa;Pwd=summid23.";
        //数据库连接字符串

        public static SqlConnection connection = new SqlConnection(connString);
        //数据库连接对象

        public string ExecSQL(string sql)  //执行sql语句并返回结果中的第一行第一列
        {
            SqlCommand command = new SqlCommand(sql,connection);
            if(connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            string result = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return result;
        }

        public int ExecSQLResult(string sql)  //执行sql语句并返回结果中受影响的行数
        {
            SqlCommand command = new SqlCommand(sql,connection);
            if(connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public DataTable GetDataSet(string sql)  //返回查询结果的表，在DataGridView控件里用到
        {
            //SqlCommand command = new SqlCommand(sql, connection);
            //SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand = command;
            SqlDataAdapter sda = new SqlDataAdapter(sql,connection); //执行sql语句

            DataSet ds = new DataSet();  //创建数据集对象
            sda.Fill(ds);  //填充数据集
            return ds.Tables[0];  //返回第一张表
        }
    }
}
