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
    public partial class All_View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id_ministry"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }

            if (!IsPostBack)
            {
                int? id_min = Convert.ToInt32(Session["id_ministry"]);
                Data_Access ds = new Data_Access();
                DataTable dt_vac = new DataTable();
                string q_all_vac_vac = "select * from tb_vacancy where id_ministry=" + id_min + " ";
                dt_vac = ds.SelectData(q_all_vac_vac);
                dt_vac.Columns.RemoveAt(0);
                dt_vac.Columns.RemoveAt(2);
                dt_vac.Columns.RemoveAt(4);

                GridView_All.DataSource = dt_vac;
                GridView_All.DataBind();
                var vac_name = ds.SelectData("select vacancy_name from tb_vacancy where id_ministry=" + id_min + "");
                DropDownList1.DataSource = vac_name;
                DropDownList1.DataTextField = "vacancy_name";
                DropDownList1.DataValueField = "vacancy_name";
                DropDownList1.DataBind();
                
            }
            s = DropDownList1.SelectedValue;
        }

        //-----------------------------------SideBar-------------------------------------//
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
            //int? id_min = Convert.ToInt32(Session["id_ministry"]);
            //Data_Access ds = new Data_Access();
            //DataTable dt_vac = new DataTable();
            //string q_all_vac_vac = "select * from tb_vacancy where id_ministry=1 ";
            //dt_vac=ds.SelectData(q_all_vac_vac);
            //GridView_All.DataSource = dt_vac;
            //GridView_All.DataBind();
            //var ss= ds.SelectData("select vacancy_name from tb_vacancy where id_ministry=1");
            //        DropDownList1.DataSource = ss;
            //        DropDownList1.DataTextField = "vacancy_name";
            //        DropDownList1.DataValueField = "vacancy_name";
            //        DropDownList1.DataBind();
                
           // int id_vac;
            //string q_con_vac;
            //DataTable dt_con = new DataTable();
            //for (int i = 0; i < dt_vac.Rows.Count; i++)
            //{
                //id_vac = (int)dt_vac.Rows[i][0];
                //var name= dt_vac.Rows[i][1].ToString();
                //var id = dt_vac.Rows[i][0].ToString();
                // ListBox1.DataSource = dt_vac.Rows[0][1].ToString();
                //ListBox1.DataBind();
                //li_vac.InnerText = "'" + dt_vac.Rows[i][1] + "'";
                //q_con_vac = "select * from tb_emp_condition where id_vacancy='" + id_vac + "'";
                // dt_con = ds.SelectData(q_con_vac);


                //GridView_All.DataSource = dt_vac;
                //GridView_All.DataBind();
                //for (int j = 0; j < dt_con.Rows.Count; j++)
                //{
                //    dd_con.DataBind();
                //    li_con.InnerText = "'" + dt_con.Rows[j][2] + "'";
                //}

            //}
            //GridView_All.DataSource = dt;
            //GridView_All.DataBind();
           
        }

        //    GridView_All.DataBind();

        //    //ListBox2.DataSource = dt_con.Rows[0][2].ToString();
        //    //ListBox2.DataBind();
        //}
        string s;
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = DropDownList1.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Data_Access ds = new Data_Access();
            var ss = ds.SelectData("select id_vacancy from tb_vacancy where vacancy_name='" + s + "'");
            string q_con_vac;
            DataTable dt_con = new DataTable();
            q_con_vac = "select emp_condition_name,emp_condition_type from tb_emp_condition where id_vacancy='" + ss.Rows[0][0] + "'";
            dt_con = ds.SelectData(q_con_vac);
            GridView_All0.DataSource = dt_con;
            GridView_All0.DataBind();
        }

<<<<<<< HEAD
        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("display_gradute.aspx");
        }



        //protected void GridView_All_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    if (e.CommandName == "con")
        //    {
        //        int rows = Convert.ToInt32(e.CommandArgument);
        //        GridViewRow row = GridView_All.Rows[rows];
        //        var id_vac = row.Cells[1];
        //        Data_Access ds = new Data_Access();
        //        string q_con_vac;
        //        DataTable dt_con = new DataTable();
        //        q_con_vac = "select * from tb_emp_condition where id_vacancy='" + 1 + "'";
        //        dt_con = ds.SelectData(q_con_vac);
        //        ListBox2.DataSource = dt_con.Rows[0][2].ToString();
        //        ListBox2.DataBind();
        //    }
        //    return;
        //}
=======
>>>>>>> eab5a12777f2c43e3294ac0a4d9777c7377f7031
    }
}