using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireMe.Pages_Ministry
{
    public partial class Update_Condition : System.Web.UI.Page
    {
        int id_session_min;
        Data_Access das;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["id_ministry"] == null)
            //{
            //    Response.Redirect("~/HireMe/Home.aspx");
            //    return;
            //}



            if (!IsPostBack)
            {

                das = new Data_Access();
                id_session_min = Convert.ToInt32(Session["id_ministry"]);

                var dt_uvsn = das.SelectData("select emp_condition_name from tb_emp_condition e,tb_vacancy v, tb_ministry m where e.id_vacancy=v.id_vacancy and m.id_ministry=v.id_ministry and m.id_ministry =" + id_session_min + ";");

                name_condition.DataSource = dt_uvsn;
                name_condition.DataTextField = "emp_condition_name";
                name_condition.DataValueField = "emp_condition_name";
                name_condition.DataBind();
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
        protected void function_btn_Save_Condition(object sender, EventArgs e)
        {

            if (name_condition.Items.Count == 0)
            {
                Response.Write("<script>alert('الإختيار فارغ ')</script>");
                return;
            }

            //if (name_condition.SelectedValue == " " || name_condition.SelectedValue == null) 
            //{
            //    Response.Write("<script>alert('الإختيار فارغ ')</script>");
            //    return;
            //}

            C_HireMe check = new C_HireMe();
            if (check.check_string(name_condition_new_add.Text) == false)
            {

                lab_error.Text = "input null or contain (-,<,;)";
                return;
            }
           


            das = new Data_Access();
            das.open_connection();
            var EdNum = das.EX_Non_Query("update tb_emp_condition set emp_condition_name ='" + name_condition_new_add.Text + "' ,emp_condition_type='" + type_condition_up.SelectedValue + "' where emp_condition_name= '"+ name_condition.SelectedValue + "'  ");
            //if ()
            das.close_connection();

        }
        protected void function_btn_Remove_Condition(object sender, EventArgs e)
        {
            if (name_condition.Items.Count == 0 )
            {
                Response.Write("<script>alert('الإختيار فارغ ')</script>");
                return;
            };
            das = new Data_Access();
            das.open_connection();
            var EdNum = das.EX_Non_Query("delete from tb_emp_condition where emp_condition_name='" + name_condition.SelectedValue + "' ");
            //if ()
            das.close_connection();

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("display_gradute.aspx");
        }
    }
}