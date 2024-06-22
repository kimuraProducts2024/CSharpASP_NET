using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication23
{
    public partial class adminauthormanagement : System.Web.UI.Page
    {

        string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                getGridViewList();
            }
        }

        // Go Button Click
        protected void Button1_Click(object sender, EventArgs e)
        {
            getAuthorByID();
        }

        // Add Button Click
        protected void Button3_Click(object sender, EventArgs e)
        {
            if(checkIfAuthorExist())
            {
                Response.Write("<script>alert('Author with this ID already Exist. You cannot add another Author with th same Author ID');</script>");

            }
            else
            {
                addAnotherAuthor();
                Response.Write("<script>alert('Add Author Successful')</script>");
                getGridViewList();
                clearForm();
            }
        }

        // Update Button Click
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfAuthorExist())
            {
                updateAuthor();
                Response.Write("<script>alert('Author Update Successful')</script>");
                getGridViewList();
                clearForm();
            }
            else
            {
                Response.Write("<script>alert('this ID is not Exist. You cannot update these data.');</script>");
            }
        }

        // Delete Button Click
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfAuthorExist())
            {
                deleteAuthor();
                Response.Write("<script>alert('Author delete Successful')</script>");
                getGridViewList();
                clearForm();
            }
            else
            {
                Response.Write("<script>alert('this ID is not Exist. You cannot update these data.');</script>");
            }
        }

        void getGridViewList()
        {
            string strSql = "SELECT * FROM author_master_tbl ";
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
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        void getAuthorByID()
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
                        objCmd.CommandText = "SELECT * FROM author_master_tbl WHERE author_id ='" + TextBox1.Text.Trim() + "'";

                        using (SqlDataAdapter objAdpt = new SqlDataAdapter())
                        {
                            objAdpt.SelectCommand = objCmd;
                            DataTable dt = new DataTable();
                            objAdpt.Fill(dt);

                            if(dt.Rows.Count >= 1)
                            {
                                TextBox2.Text = dt.Rows[0][1].ToString();
                            } else
                            {
                                Response.Write("<script>alert('Invalid Author ID')</script>");
                            }
                        }
                    
                    }
                }
            } catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        bool checkIfAuthorExist()
        {
            string strSql = "SELECT * FROM author_master_tbl WHERE author_id = '" + TextBox1.Text.Trim() + "';";
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

        void addAnotherAuthor()
        {
            string strSql = "INSERT INTO author_master_tbl (author_id, author_name) VALUES (@author_id, @author_name)";

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
                        objCmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
                        objCmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());

                        objCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error was occured. " + ex.Message + "'</script>");
                
            }
        }
        void updateAuthor()
        {
            string strSql = "UPDATE author_master_tbl SET author_name = @author_name WHERE author_id = '" + TextBox1.Text.Trim() + "'";

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
                        objCmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());

                        objCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error was occured. " + ex.Message + "'</script>");

            }
        }
        void deleteAuthor()
        {
            string strSql = "DELETE FROM author_master_tbl WHERE author_id = '" + TextBox1.Text.Trim() + "'";

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
                        objCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error was occured. " + ex.Message + "'</script>");

            }
        }

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}