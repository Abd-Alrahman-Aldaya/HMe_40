using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HireMe.Class;
using System.Data;

namespace HireMe
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  C_HireMe hm = new C_HireMe();
            //  var x = hm.check_vacancy(70, "هندسة معلوماتية");
            //  var x = hm.Insert_To_Desire("min-prog",1,1);
            //  GridView1.DataSource = x;
            //GridView1.DataBind();
            // hm.insert_To_Result();
            // Label1.Text = Convert.ToString( x);
            //DataTable dt_90_shahed = new DataTable();
            //Data_Access ds = new Data_Access();
            //string q_90_shahed = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=80 order by graduate_avg desc";
            //dt_90_shahed = ds.SelectData(q_90_shahed);
            ////dt_90_shahed.Columns.RemoveAt(0);
            //var s = dt_90_shahed;
            //ds.open_connection();
            //for (int i = 0; i < 3; i++)
            //{
            //    ds.EX_Non_Query_Insert("insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
            //        "values('" + dt_90_shahed.Rows[0][1]+ "','" + dt_90_shahed.Rows[0][2] + "','" + dt_90_shahed.Rows[0][3] + "','" + dt_90_shahed.Rows[0][4] + "','" + dt_90_shahed.Rows[0][5] + "','" + dt_90_shahed.Rows[0][7] + "','" + dt_90_shahed.Rows[0][8] + "','" + dt_90_shahed.Rows[0][9] + "','" + dt_90_shahed.Rows[0][10] + "','" + dt_90_shahed.Rows[0][11] + "','" + dt_90_shahed.Rows[0][12] + "','" + dt_90_shahed.Rows[0][13] + "')");
            //}
            //GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            C_HireMe h = new C_HireMe();
            var dt= h.sort_shahed();
            GridView1.DataSource = dt;
            GridView1.DataBind();
            h.SORT();
            //DataTable dt_90_shahed = new DataTable();
            //Data_Access ds = new Data_Access();
            //string q_90_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=80 order by graduate_avg desc";
            //dt_90_shahed = ds.SelectData(q_90_shahed);
            //GridView1.DataSource = dt_90_shahed.Rows[0];
            //GridView1.DataBind();
            //Label1.Text = "fssf";

         
        
            
        }
    }
}