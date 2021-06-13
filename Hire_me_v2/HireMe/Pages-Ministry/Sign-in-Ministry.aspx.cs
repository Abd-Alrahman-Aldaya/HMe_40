using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireMe.Pages_Ministry
{
    public partial class Sign_in : System.Web.UI.Page
    {
        Data_Access da = new Data_Access();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void function_SignUp(object sender, EventArgs e)
        {
            string stu_login_info = "select id_graduate,graduate_email,graduate_password from tb_graduate;";
            var data_stu_login_info = da.SelectData(stu_login_info);
            string admin_login_info = "select id_admin,admin_email,admin_password from tb_admin;";
            var data_admin_login_info = da.SelectData(admin_login_info);
            string ministry_login_info = "select id_ministry,ministry_email,ministry_password from tb_ministry;";
            var data_ministry_login_info = da.SelectData(ministry_login_info);
            string university_login_info = "select id_university,university_email,university_password from tb_university;";
            var data_university_login_info = da.SelectData(university_login_info);
            string entered_email = Login_Email.Text;
            string entered_password = Login_Password.Text;
            for (int i = 0; i < data_admin_login_info.Rows.Count; i++)
            {

                if (data_admin_login_info.Rows[i][1].ToString() == entered_email)
                {
                    if (data_admin_login_info.Rows[i][2].ToString() == entered_password)
                    {
                        Login_Email.Text = "";
                        Login_Password.Text = "";
                        Session["id_admin"] = data_admin_login_info.Rows[i][0].ToString();
                        Response.Redirect("~/HireMe/Pages-Admin/page-admin.aspx");
                        return;
                    }
                }
            }
            for (int i = 0; i < data_ministry_login_info.Rows.Count; i++)
            {

                if (data_ministry_login_info.Rows[i][1].ToString() == entered_email)
                {
                    if (data_ministry_login_info.Rows[i][2].ToString() == entered_password)
                    {
                        Login_Email.Text = "";
                        Login_Password.Text = "";
                        Session["id_ministry"] = data_ministry_login_info.Rows[i][0].ToString();
                        Response.Redirect("~/HireMe/Pages-Ministry/Add-Vacancy.aspx");
                        return;
                    }
                }
            }
            for (int i = 0; i < data_university_login_info.Rows.Count; i++)
            {

                if (data_university_login_info.Rows[i][1].ToString() == entered_email)
                {
                    if (data_university_login_info.Rows[i][2].ToString() == entered_password)
                    {
                        Login_Email.Text = "";
                        Login_Password.Text = "";
                        Session["id_university"] = data_university_login_info.Rows[i][0].ToString();
                        Response.Redirect("~/HireMe/Pages-Universities/check_gradute.aspx");
                        return;
                    }
                }
            }
            for (int i = 0; i < data_stu_login_info.Rows.Count; i++)
            {

                if (data_stu_login_info.Rows[i][1].ToString() == entered_email)
                {
                    if (data_stu_login_info.Rows[i][2].ToString() == entered_password)
                    {
                        Login_Email.Text = "";
                        Login_Password.Text = "";
                        Session["id_student"] = data_stu_login_info.Rows[i][0].ToString();
                        Response.Redirect("~/HireMe/Pages-Graduates/recive_message.aspx");
                        return;
                    }
                }
            }
            Login_Email.Text = "";
            Login_Password.Text = "";
            Response.Write("<script>alert('Wrong info entred')</script>");
        }
        protected void function_Create_Account(object sender, EventArgs e)
        {

        }

    }
}