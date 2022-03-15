using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewBasic
{
    public partial class Gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void retrivedata()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["str"].ToString());
            SqlCommand cmd = new SqlCommand("Select * From SYCS", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gdview.DataSource = dt;
            gdview.DataBind();

        }
        protected void btnshow_Click(object sender, EventArgs e)
        {
            retrivedata();
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["str"].ToString());
            SqlCommand cmd = new SqlCommand("insert into sycs values('"+txtname.Text+"','"+txtrollno.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtname.Text =string.Empty;
            txtrollno.Text = string.Empty;
            retrivedata();

        }
    }
}