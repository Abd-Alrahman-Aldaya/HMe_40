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

            if (Session["id_admin"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }
            Panel1.Visible = false;
            btn_no_open.Visible = false;
            btn_yes_open.Visible = false;
            btn_no_sort.Visible = false;
            btn_yes_sort.Visible = false;
            lab_open.Visible = false;
            lab_sort.Visible = false;
        }

       protected void Button1_Click(object sender, EventArgs e)
       {
        
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

        protected void btn_stop_Click(object sender, EventArgs e)
        {
            Application["state_site"] = 0;
            btn_sort.Enabled = true;
        }

        protected void btn_open_Click(object sender, EventArgs e)
        {
           
            Panel1.Visible = true;
            btn_yes_open.Visible = true;
            btn_no_open.Visible = true;
            lab_open.Visible = true;
            lab_open.Text = "سيتم اعادة تشغيل الموقع و حذف جميع الخريجين المسجلين سابقا\n هل انت متأكد  ";

        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            Application["state_site"] = 2;
        }

        protected void btn_result_Click(object sender, EventArgs e)
        {
            Application["state_site"] = 3;
        }

        protected void btn_sort_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            btn_yes_sort.Visible = true;
            btn_no_sort.Visible = true;
            lab_sort.Visible = true;
            lab_sort.Text = "سيقوم الموقع بفرز الخريجين الي الشواغر المناسبة ولن تستطيع العودة " +
                "\n هل انت متأكد";
             
        }

        protected void btn_min_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HireMe/Pages-Ministry/Create-Account-Ministry.aspx");
        }

        protected void btn_univer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HireMe/Pages-Universities/create account university.aspx");
        }

        protected void btn_yes_sort_Click(object sender, EventArgs e)
        {
            C_HireMe c_HireMe = new C_HireMe();
            c_HireMe.sort_shahed();
            c_HireMe.SORT();
            btn_sort.Enabled = false;
        }

        protected void btn_no_sort_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HireMe/Pages-Admin/page-admin.aspx");
            return;
        }

        protected void btn_yes_open_Click(object sender, EventArgs e)
        {

            Application["state_site"] = 1;
            //Data_Access das = new Data_Access();
            //das.open_connection();
            //das.EX_Non_Query("delete from tb_result");
            //das.EX_Non_Query("update tb_vacancy set vacancy_check_count=0;");
            //das.EX_Non_Query("delete from tb_desire");
            //das.EX_Non_Query("delete from tb_graduate;");
            //das.EX_Non_Query("delete from tb_message");
            
            //das.close_connection();
            btn_sort.Enabled = true;
        }

        protected void btn_no_open_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HireMe/Pages-Admin/page-admin.aspx");
            return;
        }
    }
}