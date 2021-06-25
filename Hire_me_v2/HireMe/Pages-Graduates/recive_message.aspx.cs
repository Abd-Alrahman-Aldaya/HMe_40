using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hire_me_v2.HireMe.Pages_Graduates
{
    public partial class recive_message : System.Web.UI.Page
    {
        Data_Access ds= new Data_Access(); 
        int id_graduate;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id_student"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }

            id_graduate = Convert.ToInt32(Session["id_student"]);

            var dt_message = ds.SelectData("select * from tb_message where id_graduate=" + id_graduate + " and message_read=0;");
            if (dt_message.Rows.Count == 0)
            {
                lab_message.Text = "no message";
                btn_edite.Font.Size = FontUnit.Smaller;
                btn_edite.Enabled = false;
                return;
            }
            string a = dt_message.Rows[0][3].ToString();
            lab_message.Text = a;
            string Mdate = dt_message.Rows[0][4].ToString();

            lab_Mdate.Text = Mdate;
            btn_ok.Font.Size = FontUnit.Smaller;
            btn_ok.Enabled = false;

        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {

            ds.open_connection();
            ds.EX_Non_Query("update tb_message set message_read=1 where id_graduate=" + id_graduate + "");
            ds.close_connection();
            Response.Redirect("~/HireMe/Home.aspx");
        }

        protected void btn_edite_Click(object sender, EventArgs e)
        {
            ds.open_connection();
            ds.EX_Non_Query("update tb_message set message_read=1 where id_graduate=" + id_graduate + "");
            ds.close_connection();

            Response.Redirect("~/HireMe/Pages-Graduates/update_gardue.aspx");
        }
    }
}