using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hire_me_v2.HireMe.Pages_Graduates
{
    public partial class Result_Gradute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id_student"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }

            result_gradute.Enabled = false;
            int id_garad = Convert.ToInt32(Session["id_student"]);
            Data_Access das = new Data_Access();
            var dt_id_minis= das.SelectData("select id_ministry from tb_result where id_graduate =" + id_garad + "");
            if (dt_id_minis.Rows.Count == 0)
            {
                result_gradute.Text = " جميع الرغبات مرفوضة ";
                return;
            }
            int id_minis = Convert.ToInt32(dt_id_minis.Rows[0][0]);

            var dt_resut = das.SelectData("select ministry_name from tb_ministry where id_ministry=" + id_minis + ";");
            if (dt_resut.Rows.Count == 0)
            {
                result_gradute.Text = " جميع الرغبات مرفوضة ";
                return;
            }

            result_gradute.Text = dt_resut.Rows[0][0].ToString();

            

        }
    }
}