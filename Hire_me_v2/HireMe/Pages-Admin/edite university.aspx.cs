using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HireMe.Class;
using System.Data;

namespace Hire_me_v2.HireMe.Pages_Admin
{
    public partial class edite_university : System.Web.UI.Page
    {
        Data_Access ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = new Data_Access();
            string q = "select university_name from tb_university";
            if (!IsPostBack)
            {
                var ministry_n = ds.SelectData(q);
                DropDown_university.DataSource = ministry_n;
                DropDown_university.DataValueField = "university_name";
                DropDown_university.DataTextField = "university_name";
                DropDown_university.DataBind();
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            ds = new Data_Access();
            ds.open_connection();
            string update = "update tb_university set university_name='" + new_name_university.Text + "' where university_name='" + DropDown_university.SelectedValue + "'";
            ds.EX_Non_Query(update);
            ds.close_connection();
            //---------
            string q = "select university_name from tb_university";
            var ministry_n = ds.SelectData(q);
            DropDown_university.DataSource = ministry_n;
            DropDown_university.DataValueField = "university_name";
            DropDown_university.DataTextField = "university_name";
            DropDown_university.DataBind();
        }

        protected void btn_remove_Click(object sender, EventArgs e)
        {
            ds = new Data_Access();
            ds.open_connection();
            string remove = "delete from tb_university where university_name='" + DropDown_university.SelectedValue + "'";
            ds.EX_Non_Query(remove);
            ds.close_connection();
            //-------
            string q = "select university_name from tb_university";
            var ministry_n = ds.SelectData(q);
            DropDown_university.DataSource = ministry_n;
            DropDown_university.DataValueField = "university_name";
            DropDown_university.DataTextField = "university_name";
            DropDown_university.DataBind();
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("page-admin.aspx");
        }
    }
}