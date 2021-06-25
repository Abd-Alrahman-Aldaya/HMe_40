using HireMe.Class;
using System;

namespace HireMe.Pages_Ministry
{
    public partial class Add_Condition : System.Web.UI.Page
    {
        Data_Access da = new Data_Access();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id_ministry"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }

                if (!IsPostBack)
            {
                int? id_min = Convert.ToInt32(Session["id_ministry"]);
                var vacancy_name = da.SelectData("select id_vacancy,vacancy_name from tb_vacancy where id_ministry=" + id_min + ";");
                type_specialization_for_cond.DataSource = vacancy_name;
                type_specialization_for_cond.DataTextField = "vacancy_name";
                type_specialization_for_cond.DataValueField = "id_vacancy";
                type_specialization_for_cond.DataBind();
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
        protected void function_btn_Add_Condition(object sender, EventArgs e)
        {
<<<<<<< HEAD


            if (type_condition_new.Items.Count == 0)
            {
                Response.Write("<script>alert('الإختيار فارغ ')</script>");
                return;
            }


            C_HireMe check = new C_HireMe();
            if (check.check_string(name_condition_new.Text) == false)
            {

                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }

=======
>>>>>>> eab5a12777f2c43e3294ac0a4d9777c7377f7031
            var condation_name = name_condition_new.Text;
            var condition_type = type_condition_new.SelectedValue;
            var vacncy_id = type_specialization_for_cond.SelectedValue;
            da.open_connection();
            da.EX_Non_Query_Insert("insert into tb_emp_condition (emp_condition_name,emp_condition_type,id_vacancy,result_condition) values('" + condation_name + "','"+condition_type+"',"+ vacncy_id + ",0)");
            da.close_connection();
        }

        protected void type_specialization_for_cond_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("display_gradute.aspx");
        }
    }
}