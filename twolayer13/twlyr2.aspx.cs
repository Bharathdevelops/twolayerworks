using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace twolayer13
{
    public partial class twlyr2 : System.Web.UI.Page
    {
        twlyrcon conob = new twlyrcon();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string str = "insert into Table_1  values('" + TextBox1.Text + "', " + TextBox2.Text + " , '" + TextBox3.Text + "','" + path + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
            int i = conob.Fn_NOnquery(str);
            if (i == 1)
            {
                Label7.Text = "inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
}