using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HireMe.Class;

namespace HireMe.Pages_Ministry
{
    public partial class Add_Vacancy : System.Web.UI.Page
    {
            Data_Access da = new Data_Access();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id_ministry"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }



            var specialization = da.SelectData("select university_name from tb_university group by university_name ");
            if (!IsPostBack)
            {
                name_specialization_new.DataSource = specialization;
                name_specialization_new.DataTextField = "university_name";
                name_specialization_new.DataValueField = "university_name";
                name_specialization_new.DataBind();
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
        protected void function_btn_Add_Vacancy(object sender, EventArgs e)
        {
            C_HireMe check = new C_HireMe();

            if (check.check_string(name_specialization_new.Text) == false)
            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }

            if (check.check_string(type_specialization_new.Text) == false)
            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }

            if (check.check_string(avg_specialization_new.Text) == false)
            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }

            if (check.check_string(count_specialization_new.Text) == false)
            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }

            string q = "select vacancy_name,vacancy_type from tb_vacancy";
            if (check.double_check(name_specialization_new.SelectedValue, type_specialization_new.SelectedValue, q)==false)
            {
                lab_error.Text = "name exisit";
                return;

            }

            var avg = avg_specialization_new.Text;
            var count = count_specialization_new.Text;
            var name = name_specialization_new.SelectedValue;
            var type = type_specialization_new.SelectedValue;
            int id_ministry = Convert.ToInt32(Session["id_ministry"]);
            da.open_connection();
<<<<<<< HEAD
            da.EX_Non_Query_Insert("insert into tb_vacancy(vacancy_count,vacancy_avg,vacancy_name,vacancy_type,id_ministry,vacancy_check_count) values(" + count+","+avg+",'"+name+"','"+type+"',"+id_ministry+",0)");
=======
            da.EX_Non_Query_Insert("insert into tb_vacancy(vacancy_count,vacancy_avg,vacancy_name,vacancy_type,id_ministry) values(" + count + "," + avg + ",'" + name + "','" + type + "'," + id_ministry + ")");
>>>>>>> eab5a12777f2c43e3294ac0a4d9777c7377f7031
            da.open_connection();

            lab_error.Text = " ";
            avg_specialization_new.Text = " ";
            count_specialization_new.Text = " ";
        }

        protected void name_specialization_new_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("display_gradute.aspx");
        }
    }
}