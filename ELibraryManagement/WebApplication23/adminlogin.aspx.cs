using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication23
{



    public partial class adminlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // user Login
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if(con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM admin_login_tbl WHERE USERNAME = '" + TextBox1.Text.Trim() + 
                                                    "' AND PASSWORD = '" + TextBox2.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Response.Write("<script>alert('Successful Login')</script>");
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["fullname"] = dr.GetValue(2).ToString();
                        Session["role"] = "admin";
                    }

                    Response.Redirect("homepage.aspx");
                } 
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>'");
                }


            }
            catch(Exception ex)
            {

            }

        }
    }
}