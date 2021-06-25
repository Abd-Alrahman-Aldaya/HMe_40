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
    public partial class create_account_university : System.Web.UI.Page
    {
        Data_Access ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lab_error.InnerText = " ";
            }
        }
        string country;
        protected void sing_in_univarsity(object sender, EventArgs e)
        {
            C_HireMe c = new C_HireMe();
            //if (c.check_string(univer_email.Text) == false)
            //{
            //    lab_error.InnerText = "input null or contain(-,<,;)";
            //    return;
            //}

            //if (c.check_string(univer_name.Text) == false)
            //{
            //    lab_error.InnerText = "input null or contain(-,<,;)";
            //    return;
            //}
            //if (c.check_string(univer_pass.Text) == false)
            //{
            //    lab_error.InnerText = "input null or contain(-,<,;)";
            //    return;
            //}
            //if (c.check_string(univer_phone.Text) == false)
            //{
            //    lab_error.InnerText = "input null or contain(-,<,;)";
            //    return;
            //}
            //if (c.check_string(univer_conf_pass.Text) == false)
            //{
            //    lab_error.InnerText = "input null or contain(-,<,;)";
            //    return;
            //}

            //if (c.check_Email(univer_email.Text, "select university_email from tb_university ") == false)
            //{
            //    lab_error.InnerText = "email excist";
            //    return;

            //}
            //if (univer_pass.Text != univer_conf_pass.Text)
            //{
            //    lab_error.InnerText = "no match password";
            //    return;
            //}


            string q = "select university_name,university_country from tb_university";
            if (c.double_check(univer_name.Text, DropDown_country.SelectedValue, q) == false)
            {
                lab_error.InnerText = "name exisit";
                return;

            }




            ds = new Data_Access();
            country = DropDown_country.SelectedValue;
            string univer_name1 = univer_name.Text;

            string Encrypted_pass = C_HireMe.Encrypt(univer_pass.Text, 5);
            string q_insert_info = "insert into tb_university (university_name,university_email,university_password,university_country) values('" + univer_name1 + "','" + univer_email.Text + "','" + Encrypted_pass + "','" + country + "')";
            ds.open_connection();
            ds.EX_Non_Query_Insert(q_insert_info);
            string q_id_univer = "select id_university from tb_university where university_name='"+univer_name1+ "'and university_country='" + country + "'";
            DataTable dt_phone = new DataTable();
            dt_phone= ds.SelectData(q_id_univer);
            string q_insert_phone = "insert into tb_phone (phone,id_unversity) values ('" + univer_phone.Text+"','"+(int)dt_phone.Rows[0][0]+"')";
            ds.EX_Non_Query_Insert(q_insert_phone);
            ds.close_connection();


            univer_name.Text = null;
            univer_email.Text = null;
            univer_pass.Text = null;
            univer_conf_pass.Text = null;
            univer_phone.Text = null;
            lab_error.InnerText = null;

            
        }

        protected void DropDown_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = DropDown_country.SelectedValue;
        }
    }
}