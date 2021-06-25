using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireMe.Pages_Ministry
{
    public partial class Update_Vacancy : System.Web.UI.Page
    {
        int id_session_min;
        Data_Access das;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id_ministry"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }

            das = new Data_Access();
            id_session_min = Convert.ToInt32(Session["id_ministry"]);

            if (!IsPostBack)
            {
                var dt_uvsn = das.SelectData("select vacancy_name from tb_vacancy where id_ministry="+id_session_min+" group by vacancy_name;");
               
                name_specialization.DataSource = dt_uvsn;
                name_specialization.DataTextField = "vacancy_name";
                name_specialization.DataValueField = "vacancy_name";
                name_specialization.DataBind();
                lab_error.Text = " ";
            }
        }

        //-----------------------------------SideBar-------------------------------------//
        protected void function_link_add_vacany(object sender, EventArgs e)
        {
            Response.Redirect("Add-Vacancy.aspx");
        }
        protected void function_link_update_vacany(object sender, EventArgs e)
        {
            Response.Redirect("Update-Vacancy.aspx");
        }
        protected void function_link_add_condition(object sender, EventArgs e)
        {
            Response.Redirect("Add-Condition.aspx");
        }
        protected void function_link_update_condition(object sender, EventArgs e)
        {
            Response.Redirect("Update-Condition.aspx");
        }
        protected void function_link_view_cond_vac(object sender, EventArgs e)
        {
            Response.Redirect("All-View.aspx");
        }

        //-----------------------------------ButtonEvent-------------------------------------//
        protected void function_btn_Save_Vacancy(object sender, EventArgs e)
        {

            if (name_specialization.Items.Count == 0)
            {
                Response.Write("<script>alert('الإختيار فارغ ')</script>");
                return;
            }

            C_HireMe check = new C_HireMe();

            if(check.check_string( avg_specialization .Text)==false)
            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }
            if (check.check_string(count_specialization.Text)==false)
            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }


            das = new Data_Access();
            das.open_connection();
            var EdNum = das.EX_Non_Query("update tb_vacancy set vacancy_name ='" + name_specialization.SelectedValue + "' ,vacancy_count=" + count_specialization.Text + ", vacancy_avg=" + avg_specialization.Text + ",vacancy_type='" + type_specialization.SelectedValue + "',id_ministry = '" + id_session_min + "' where vacancy_name='" + name_specialization.SelectedValue + "'and vacancy_type='" + type_specialization.SelectedValue + "' and id_ministry ='" + id_session_min+"' ");
            //if ()
            das.close_connection();
        }
        protected void function_btn_Remove_Vacancy(object sender, EventArgs e)
        {
            if (name_specialization.Items.Count == 0)
            {
                Response.Write("<script>alert('الإختيار فارغ ')</script>");
                return;
            }

            das = new Data_Access();
            das.open_connection();
            var EdNum = das.EX_Non_Query("delete from tb_vacancy where vacancy_name='" + name_specialization.SelectedValue + "'and vacancy_type='" + type_specialization.SelectedValue + "' and id_ministry ='" + id_session_min + "' ");
            //if ()
            das.close_connection();
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("display_gradute.aspx");
        }
    }
}