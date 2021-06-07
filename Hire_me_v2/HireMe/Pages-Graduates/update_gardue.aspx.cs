using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hire_me_v2.HireMe.Pages_Graduates
{
    public partial class update_gardue : System.Web.UI.Page
    {

        Data_Access das;
        string uni;
        int id_graduate;
        protected void Page_Load(object sender, EventArgs e)
        {
            // id_graduate = Convert.ToInt32(Session["id_student"]);
            id_graduate = 4;
            das = new Data_Access();
            if (!IsPostBack)
            {

                var dt_U_Name = das.SelectData("select university_name from tb_university  where university_country ='damas' group by university_name");
                DDL_specialization_gradute.DataSource = dt_U_Name;
                DDL_specialization_gradute.DataTextField = "university_name";
                DDL_specialization_gradute.DataValueField = "university_name";
                DDL_specialization_gradute.DataBind();
            }

        }

        protected void function_Update_Account(object sender, EventArgs e)
        {
            das = new Data_Access();
            string q = "update tb_graduate set graduate_id_number ='" + id_number_gradute.Text + "',graduate_first_name='" + first_name_gradute.Text + "',graduate_last_name='" + last_name_gradute.Text + "',graduate_father_name='" + fname_gradute.Text + "',graduate_mother_name='" + mname_gradute.Text + "',graduate_date='" + date_gradute.Text + "',graduate_avg=" + avg_gradute.Text + ", graduate_profession='" + DDL_specialization_gradute.SelectedItem + "',graduate_university_country='" + university_country.SelectedValue + "',graduate_resident_country='" + DDL_country_gradute.SelectedValue + "',graduate_check='0' where id_graduate=6;";
            das.open_connection();
            das.EX_Non_Query(q);
            das.close_connection();

        }

        protected void university_country_SelectedIndexChanged(object sender, EventArgs e)
        {

            uni = university_country.SelectedValue;
            avg_gradute.Text = uni;
            var dt_U_Name = das.SelectData("select university_name from tb_university  where university_country ='" + uni + "' group by university_name");
            DDL_specialization_gradute.DataSource = dt_U_Name;
            DDL_specialization_gradute.DataTextField = "university_name";
            DDL_specialization_gradute.DataValueField = "university_name";
            DDL_specialization_gradute.DataBind();

        }
    }
}