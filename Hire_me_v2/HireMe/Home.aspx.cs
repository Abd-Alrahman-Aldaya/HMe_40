using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Hire_me_v2.HireMe
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int state =Convert.ToInt32( Application["state_site"]);

            if (!IsPostBack)
            {
                btn_check.Enabled = false;
                btn_enter.Enabled = false;
                btn_result.Enabled = false;
                btn_result.Font.Size = FontUnit.Smaller;
                btn_check.Font.Size = FontUnit.Smaller;
                btn_enter.Font.Size = FontUnit.Smaller;

                if (state == 1)
                {
                    btn_enter.Enabled = true;
                    btn_enter.Font.Size = FontUnit.Larger;
                }
                if (state == 2)
                {
                    btn_check.Enabled = true;
                    btn_check.Font.Size = FontUnit.Larger;
                }
                if (state == 3)
                {
                    btn_result.Enabled = true;
                    btn_result.Font.Size = FontUnit.Larger;
                }
            }
        }

        protected void btn_enter_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HireMe/Pages-Graduates/Create-Account-Gradute.aspx");

        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/HireMe/Pages-Ministry/Sign-in-Ministry.aspx");
        }

        protected void btn_result_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HireMe/Pages-Ministry/Sign-in-Ministry.aspx");

        }
        protected void function_link_sign_info(object sender, EventArgs e)
        {

        }
        protected void function_link_check_info(object sender, EventArgs e)
        {

        }
        protected void function_link_view_result(object sender, EventArgs e)
        {

        }
    }
}