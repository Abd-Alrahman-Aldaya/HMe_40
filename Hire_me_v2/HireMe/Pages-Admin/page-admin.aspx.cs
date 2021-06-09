using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HireMe.Class;
using System.Data;

namespace HireMe.Pages_Universities
{
    public partial class page_admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       protected void Button1_Click(object sender, EventArgs e)
       {
            //Data_Access ds = new Data_Access();
            //string q_ministry = "select * from tb_ministry";
            //string q_university = "select * from tb_university";
            //string q_admin = "select * from tb_admin";
            //DataTable dt_m = new DataTable();
            //DataTable dt_u = new DataTable();
            //DataTable dt_a = new DataTable();
            //dt_m = ds.SelectData(q_ministry);
            //dt_u=ds.SelectData(q_university);
            //dt_a = ds.SelectData(q_admin);
        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Data_Access ds = new Data_Access();
            string q_admin = "select * from tb_admin";
            DataTable dt_a = new DataTable();
            dt_a = ds.SelectData(q_admin);
            GridView1.DataSource = dt_a;
            GridView1.DataBind();
        }

        protected void university_Click(object sender, EventArgs e)
        {
            Data_Access ds = new Data_Access();
            string q_university = "select * from tb_university";
            DataTable dt_u = new DataTable();
            dt_u = ds.SelectData(q_university);
            GridView1.DataSource = dt_u;
            GridView1.DataBind();
        }

        protected void ministry_Click(object sender, EventArgs e)
        {
            Data_Access ds = new Data_Access();
            string q_ministry = "select * from tb_ministry";
            DataTable dt_m = new DataTable();
            dt_m = ds.SelectData(q_ministry);
            GridView1.DataSource = dt_m;
            GridView1.DataBind();
        }

        protected void ministry_manigar_Click(object sender, EventArgs e)
        {
            Response.Redirect("edite ministry.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void university_manigar_Click(object sender, EventArgs e)
        {
            Response.Redirect("edite university.aspx");
        }

       
    }
}