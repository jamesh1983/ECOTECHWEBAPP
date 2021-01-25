using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.Configuration;

namespace ECOTECHWEBAPP
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string sqlQuery = "SELECT * FROM plan";
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = (String)dr[1].ToString().Trim();
            }
            conn.Close();
        }
        public static MySqlConnection CreateConn()
        {
            string _conn = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(_conn);
            return conn;
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string sql = "delete from plan where id=1";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string sql = "insert into plan(id,name) values(3,'新增数据')";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string sql = "update plan set name='小制作计划' where id=1";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}