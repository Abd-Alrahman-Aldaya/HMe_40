using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HireMe.Class;
using System.Data;

namespace HireMe.Pages_Ministry
{
    public partial class Create_Account : System.Web.UI.Page
    {
        Data_Access ds;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void function_btn_Create_Account_new(object sender, EventArgs e)
        {
            C_HireMe check = new C_HireMe();

            if (check.check_string(name_ministry_new.Text) == false)
            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
            }
            if(check.check_string (email_ministry_new.Text)==false)
                    {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
                    }
            if(check.check_string ( pass_ministry_new.Text)==false)
                        {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
                        }
            if(check.check_string ( confirm_pass_ministry_new.Text)==false)
                            {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
                            }
            if(check.check_string ( phone_ministry_new.Text)==false)
                                {
                lab_error.Text = "input null or contain(-,<,;)";
                return;
                                }
            



            ds = new Data_Access();
            string min_name = name_ministry_new.Text;
            string q_insert_info = "insert into tb_ministry (ministry_name,ministry_email,ministry_password) values('" + min_name+ "','"+ email_ministry_new .Text+ "','"+ pass_ministry_new .Text+ "')";
            ds.open_connection();
            ds.EX_Non_Query_Insert(q_insert_info);
            string q_id_ministry = "select id_ministry from tb_ministry where ministry_name= '"+min_name+"'";
            DataTable dt = new DataTable();
            dt=ds.SelectData(q_id_ministry);
            string q_insert_phone = "insert into tb_phone (phone,id_ministry) values ('"+ phone_ministry_new .Text+ "','"+ (int)dt.Rows[0][0] + "')";
            ds.EX_Non_Query_Insert(q_insert_phone);
            ds.close_connection();
            name_ministry_new.Text = null;
            email_ministry_new.Text = null;
            pass_ministry_new.Text = null;
            confirm_pass_ministry_new.Text = null;
            phone_ministry_new.Text = null;
            
            lab_error.Text = " ";
          //  Response.Redirect("~/HireMe/Pages-Ministry/Add-Vacancy.aspx");

        }
    }
}