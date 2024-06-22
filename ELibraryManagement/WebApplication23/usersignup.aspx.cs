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
    public partial class usersignup : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        bool checkMemberExists()
        {
            string strSql = "SELECT * FROM member_master_tbl WHERE member_id = '" + TextBox8.Text.Trim() + "';";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection objCon = new SqlConnection(strCon))
                {
                    if (objCon.State == ConnectionState.Closed)
                    {
                        objCon.Open();
                    }

                    using (SqlCommand objCmd = new SqlCommand(strSql, objCon))
                    {
                        using (SqlDataAdapter objAdpt = new SqlDataAdapter(objCmd))
                        {
                            objAdpt.Fill(dt);
                        }
                    }
                }

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error was occured. " + ex.Message + "'</script>");
                return false;
            }
        }

        void signUpNewMember()
        {
            string strSql = "INSERT INTO member_master_tbl" +
                                " (full_name,dob,contact_no,email,state,city,pincode," +
                                "full_address,member_id,password,account_status)" +
                                " VALUES (@full_name,@dob,@contact_no," +
                                "@email,@state,@city,@pincode,@full_address," +
                                "@member_id,@password,@account_status);";
            int intExecResult;

            try
            {
                using(SqlConnection objCon = new SqlConnection(strCon))
                {
                    if(objCon.State == ConnectionState.Closed)
                    {
                        objCon.Open();
                    }

                    using(SqlCommand objCmd = new SqlCommand(strSql, objCon))
                    {
                        objCmd.Parameters.AddWithValue("@full_name", TextBox1.Text.Trim());
                        objCmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                        objCmd.Parameters.AddWithValue("@contact_no", TextBox3.Text.Trim());
                        objCmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                        objCmd.Parameters.AddWithValue("@state", TextBox10.Text.Trim());
                        objCmd.Parameters.AddWithValue("@city", TextBox6.Text.Trim());
                        objCmd.Parameters.AddWithValue("@pincode", TextBox7.Text.Trim());
                        objCmd.Parameters.AddWithValue("@full_address", TextBox5.Text.Trim());
                        objCmd.Parameters.AddWithValue("@member_id", TextBox8.Text.Trim());
                        objCmd.Parameters.AddWithValue("@password", TextBox9.Text.Trim());
                        objCmd.Parameters.AddWithValue("@account_status", "pendiing");
                        intExecResult = objCmd.ExecuteNonQuery();
                    }
                }
                if(intExecResult > 0)
                {
                    Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Sign Up did not Succes.');</script>");
                }
            } 
            catch(Exception ex)
            {
                Response.Write("<script>alert('Error was occured. " + ex.Message + "');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExists())
            {
                Response.Write("<script>alert('Member Already Exist with this Member ID, try other ID');</script>");
            }
            else
            {
                signUpNewMember();
            }
        }
    }
}