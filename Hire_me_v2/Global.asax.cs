using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Hire_me_v2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Data_Access das = new Data_Access();
            var Admin = das.SelectData("select * from tb_admin");
            if (Admin.Rows.Count == 0)
            {
                das.open_connection();
                das.EX_Non_Query("insert into tb_admin (admin_first_name,admin_last_name,admin_email,admin_password) values ('a','d','admin@admin.com','123')");
                das.close_connection();
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {


        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}