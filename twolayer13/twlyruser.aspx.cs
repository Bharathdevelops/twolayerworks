using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace twolayer13
{
    public partial class twlyruser : System.Web.UI.Page
    {
        twlyrcon conob = new twlyrcon();
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "select name,age,address,photo,username,password from table_1 where id=" + Session["id"] + "";
            SqlDataReader dr = conob.Fn_Reader(str );
            while (dr.Read())
            {
                TextBox1.Text = dr["name"].ToString();
                TextBox2.Text = dr["age"].ToString();
                TextBox3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }
            DataSet ds = conob.Fn_DataSet(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            DataTable dt = conob.Fn_DataTable(str);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}