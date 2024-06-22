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
    public partial class adminmembermanagement : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            getMemberList();
        }

        // Go Button
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            getMemeberByID();
        }

        // Active Button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("active");
            getMemberList();
        }

        // Pending Button
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("pending");
            getMemberList();
        }

        // Deactive Button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("deactive");
            getMemberList();
        }

        // Delete Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteMemberByID();
            getMemberList();
        }

        void getMemberList()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection objCon = new SqlConnection())
                {
                    objCon.ConnectionString = strCon;
                    objCon.Open();

                    using (SqlCommand objCmd = new SqlCommand())
                    {
                        objCmd.Connection = objCon;
                        objCmd.CommandText = "SELECT member_id id, full_name name, account_status, contact_no, email, state, city FROM member_master_tbl;";

                        using (SqlDataAdapter objAdpt = new SqlDataAdapter())
                        {
                            objAdpt.SelectCommand = objCmd;
                            objAdpt.Fill(dt);
                        }
                    }
                }

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        // user defined function
        bool checkIfMemberExists()
        {
            try
            {
                DataTable dt = new DataTable();

                using(SqlConnection objCon = new SqlConnection())
                {
                    objCon.ConnectionString = strCon;
                    objCon.Open();

                    using(SqlCommand objCmd = new SqlCommand())
                    {
                        objCmd.Connection = objCon;
                        objCmd.CommandText = "SELECT * FROM member_master_tbl WHERE member_id = '" + TextBox1.Text.Trim() + "';";

                        using(SqlDataAdapter objAdpt = new SqlDataAdapter())
                        {
                            objAdpt.SelectCommand = objCmd;
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
                    {
                        return false;
                    }
                }
            } catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void getMemeberByID()
        {
            try
            {
                SqlConnection objCon = new SqlConnection(strCon);
                if (objCon.State == ConnectionState.Closed)
                {
                    objCon.ConnectionString = strCon;
                    objCon.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from member_master_tbl where member_id='" + TextBox1.Text.Trim() + "'", objCon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TextBox2.Text = dr.GetValue(0).ToString();
                        TextBox7.Text = dr.GetValue(10).ToString();
                        TextBox8.Text = dr.GetValue(1).ToString();
                        TextBox3.Text = dr.GetValue(2).ToString();
                        TextBox4.Text = dr.GetValue(3).ToString();
                        TextBox9.Text = dr.GetValue(4).ToString();
                        TextBox10.Text = dr.GetValue(5).ToString();
                        TextBox11.Text = dr.GetValue(6).ToString();
                        TextBox6.Text = dr.GetValue(7).ToString();

                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deleteMemberByID()
        {
            if(checkIfMemberExists())
            {
                try
                {
                    using(SqlConnection objCon = new SqlConnection())
                    {
                        objCon.ConnectionString = strCon;
                        objCon.Open();
                        using(SqlCommand objCmd = new SqlCommand())
                        {
                            objCmd.Connection = objCon;
                            objCmd.CommandText = "DELETE FROM member_master_tbl WHERE member_id = '" + TextBox1.Text.Trim() + "'";

                            objCmd.ExecuteNonQuery();
                            Response.Write("<script>alert('Memeber Deleted Successfully');</script>");
                            clearForm();
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            } else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }
        }

        void updateMemberStatusByID(string status)
        {
            if(checkIfMemberExists())
            {
                try
                {
                    using (SqlConnection objCon = new SqlConnection())
                    {
                        objCon.ConnectionString = strCon;
                        objCon.Open();
                        using (SqlCommand objCmd = new SqlCommand())
                        {
                            objCmd.Connection = objCon;
                            objCmd.CommandText = "UPDATE member_master_tbl SET account_status = '" + status + "' " +
                                " WHERE member_id = '" + TextBox1.Text.Trim() + "'";

                            objCmd.ExecuteNonQuery();
                            Response.Write("<script>alert('Member Status Updated');</script>");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }
        }

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
        }

    }
}