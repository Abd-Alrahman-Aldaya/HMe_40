using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireMe.Pages_Graduates
{
    public partial class Sign_in_Gradutes : System.Web.UI.Page
    {
        Data_Access das;
        string uni;

        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void function_Create_Account_Next(object sender, EventArgs e)
        {
            das = new Data_Access();
            string q = "insert into tb_graduate values('" + id_number_gradute.Text+ "','" + first_name_gradute.Text + "','"+last_name_gradute.Text+"','" + fname_gradute.Text + "','" + mname_gradute.Text + "','" + date_gradute.Text + "'," + avg_gradute.Text + ",'" + DDL_specialization_gradute.SelectedItem + "','"+ university_country.SelectedValue + "' ,'" + DDL_country_gradute.SelectedValue + "','0','" + email_gradute_new.Text + "','" + pass_gradute_new.Text + "',0)";
            das.open_connection();
            das.EX_Non_Query(q);
            das.close_connection();
           var id_gardute= das.SelectData("select id_graduate from tb_graduate where graduate_id_number ='"+id_number_gradute.Text+"'");

            Session["id_grad"] = id_gardute.Rows[0][0];
           Session["brof"] = DDL_specialization_gradute.SelectedItem;
             Session["avg"] = avg_gradute.Text;
            Response.Redirect("Desires-Gradute.aspx");
        }

        protected void university_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            uni = university_country.SelectedValue;
            avg_gradute.Text = uni;
            var dt_U_Name = das.SelectData("select university_name from tb_university  where university_country ='"+uni+"' group by university_name");
            DDL_specialization_gradute.DataSource = dt_U_Name;
            DDL_specialization_gradute.DataTextField = "university_name";
            DDL_specialization_gradute.DataValueField = "university_name";
            DDL_specialization_gradute.DataBind();

        }
    }
}