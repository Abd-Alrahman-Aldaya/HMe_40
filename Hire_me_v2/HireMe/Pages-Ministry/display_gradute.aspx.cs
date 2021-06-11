using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hire_me_v2.HireMe.Pages_Ministry
{
    public partial class display_gradute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Data_Access das = new Data_Access();
            //   int id_min = Convert.ToInt32(Session["id_ministry"]);
            int id_min = 3;

            var dt_result_gra = das.SelectData("select tb_graduate.*,tb_phone.phone from tb_result,tb_graduate,tb_phone where tb_result.id_graduate=tb_graduate.id_graduate and tb_phone.id_graduate=tb_graduate.id_graduate  and tb_result.id_ministry="+id_min+";");
            if (dt_result_gra.Rows.Count == 0)
            {
                return;
            }
            dt_result_gra.Columns.RemoveAt(0);
          
            dt_result_gra.Columns.RemoveAt(10);
            dt_result_gra.Columns.RemoveAt(10);
            dt_result_gra.Columns.RemoveAt(10);
            dt_result_gra.Columns.RemoveAt(10);
            dt_result_gra.Columns.RemoveAt(8);
            GridView_All.DataSource = dt_result_gra;
            GridView_All.DataBind();

        }

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

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("display_gradute.aspx");
        }
    }
}