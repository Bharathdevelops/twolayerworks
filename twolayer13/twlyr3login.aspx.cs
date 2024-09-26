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
    public partial class twlyr3login : System.Web.UI.Page
    {
        twlyrcon obj = new twlyrcon();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string sel = "select count (id)from Table_1 where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
            string i = obj.Fn_Scalar(sel);
            if (i == "1")
            {
                string str = "select id from table_1 where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string id = obj.Fn_Scalar(str);
                Session["id"] = id;
                Response.Redirect("twlyruser.aspx");
            }
            else
            {
                Label1.Text = "invalid user";
            }
        }
    }
}