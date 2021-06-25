using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Data;
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

            //int state = Convert.ToInt32(Application["state_site"]);
            //if (state != 1)
            //{
            //    Response.Redirect("~/HireMe/Home.aspx");
            //    return;
            //}

                das = new Data_Access();
            if (!IsPostBack)
            {
                var dt_U_Name = das.SelectData("select university_name from tb_university  where university_country ='damas' group by university_name");
                DDL_specialization_gradute.DataSource = dt_U_Name;
                DDL_specialization_gradute.DataTextField = "university_name";
                DDL_specialization_gradute.DataValueField = "university_name";
                DDL_specialization_gradute.DataBind();
                lab_error.Text = " ";
            }

        }
        protected void function_Create_Account_Next(object sender, EventArgs e)
        {

            C_HireMe check = new C_HireMe();
            if (check.check_string(id_number_gradute.Text) == false)
            {
                lab_error.Text = "input idNumber null or contain(-,<,;)";
                return;
            }

            if (check.check_string(first_name_gradute.Text) == false)
            {
                lab_error.Text = "input first name null or contain(-,<,;)";
                return;
            }

            if (check.check_string(last_name_gradute.Text) == false)
            {
                lab_error.Text = "input last name null or contain(-,<,;)";
                return;
            }

            if (check.check_string(fname_gradute.Text) == false)
            {
                lab_error.Text = "input name father null or contain(-,<,;)";
                return;
            }

            if (check.check_string(mname_gradute.Text) == false)
            {
                lab_error.Text = "input name mather null or contain(-,<,;)";
                return;
            }

            if (check.check_string(avg_gradute.Text) == false)
            {
                lab_error.Text = "input avg null or contain(-,<,;)";
                return;
            }

            if (check.check_string(pass_gradute_new.Text) == false)
            {
                lab_error.Text = "input password null or contain(-,<,;)";
                return;
            }

            if (check.check_string(phone_gradute.Text) == false)
            {
                lab_error.Text = "input phone null or contain(-,<,;)";
                return;
            }

            if (check.check_string(email_gradute_new.Text) == false)
            {
                lab_error.Text = "input email null or contain(-,<,;)";
                return;
            }

            if (Convert.ToInt32(avg_gradute.Text) > 100)
            {
                lab_error.Text = "يجب معدل اقل من 100";
            }
            if (Convert.ToInt32(avg_gradute.Text) < 49)
            {
                lab_error.Text = "يجب معدل اكبر من 50";
            }

            if (check.check_Email(email_gradute_new.Text, "select graduate_email from tb_graduate ") == false)
            {
                lab_error.Text = "email excist";
                return;
            }

            if (check.check_Email(id_number_gradute.Text, "select graduate_id_number from tb_graduate ") == false)
            {
                lab_error.Text = "id number excist";
                return;
            }


            das = new Data_Access();
            string Encrypted_pass = C_HireMe.Encrypt(pass_gradute_new.Text, 5);
            string q = "insert into tb_graduate values('" + id_number_gradute.Text + "','" + first_name_gradute.Text + "','" + last_name_gradute.Text + "','" + fname_gradute.Text + "','" + mname_gradute.Text + "','" + date_gradute.Text + "'," + avg_gradute.Text + ",'" + DDL_specialization_gradute.SelectedItem + "','" + university_country.SelectedValue + "' ,'" + DDL_country_gradute.SelectedValue + "','0','" + email_gradute_new.Text + "','" + Encrypted_pass + "',0)";
            das.open_connection();
            das.EX_Non_Query(q);
            string q_id_grad = "select id_graduate from tb_graduate where graduate_id_number='" + id_number_gradute.Text + "';";
            DataTable dt_phone = new DataTable();
            dt_phone = das.SelectData(q_id_grad);
            string q_insert_phone = "insert into tb_phone (phone,id_graduate) values ('" + phone_gradute.Text + "','" + (int)dt_phone.Rows[0][0] + "')";
            das.EX_Non_Query_Insert(q_insert_phone);
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