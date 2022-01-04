using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudDemo
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CNMD86D;Initial Catalog=DBDemo;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into StudentInfo values('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+DropDownList1.SelectedValue+"','"+double.Parse(TextBox3.Text)+"','"+TextBox4.Text+"')",con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Update StudentInfo set StudentName = '" + TextBox2.Text + "',Address = '" + DropDownList1.SelectedValue + "',Age = '" + double.Parse(TextBox3.Text) + "',Contact = '" + TextBox4.Text + "'Where StudentID = '" + int.Parse(TextBox1.Text) + "'",con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete StudentInfo Where StudentID = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from StudentInfo", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}