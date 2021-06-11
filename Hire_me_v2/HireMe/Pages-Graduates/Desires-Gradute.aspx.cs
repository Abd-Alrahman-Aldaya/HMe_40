using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireMe.Pages_Graduates
{
    public partial class Desires_Gradute : System.Web.UI.Page
    {
        Data_Access das;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                string prof = Session["brof"].ToString();
                int avg = Convert.ToInt32(Session["avg"]);

                C_HireMe hm = new C_HireMe();
                var dt_vac = hm.check_vacancy(avg, prof);
                desires_available.DataSource = dt_vac;
                desires_available.DataTextField = "z";
                desires_available.DataValueField = "id_vacancy";
                desires_available.DataBind();
            }
        }

        protected void function_btn_Add_Desire(object sender, EventArgs e)
        {
            // desires_selected.Items.Add(new ListItem(desires_available.SelectedItem.ToString()));
            // desires_selected.DataTextField = desires_available.DataTextField;
            // desires_selected.DataValueField = desires_available.DataValueField
            ListItem ls = new ListItem(desires_available.SelectedItem.ToString(), desires_available.SelectedValue);
            desires_selected.Items.Add(ls);
          //  Label2.Text = desires_available.SelectedValue[0].ToString();
          //  Label1.Text = desires_selected.SelectedValue[0].ToString();

                
        }
        protected void function_btn_Remove_Desire(object sender, EventArgs e)
        {
            desires_selected.Items.Clear();
        }

        protected void function_btn_sign_Desire(object sender, EventArgs e)
        {
            
            int id_g = Convert.ToInt32( Session["id_grad"]);
            das = new Data_Access();
            string q = " ";
            for (int i = 0; i < desires_selected.Items.Count; i++)
            {
                int x = i + 1;
                q = "insert into tb_desire values (" + id_g + "," + desires_selected.Items[i].Value + "," + x + ")";
                    
                das.open_connection();
                das.EX_Non_Query(q);
                das.close_connection();
            }
          


        }
    }
}