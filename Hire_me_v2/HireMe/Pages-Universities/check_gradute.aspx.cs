using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hire_me_v2.HireMe.Pages_Universities
{
    public partial class check_gradute : System.Web.UI.Page
    {
        Data_Access das;
        int id_grad;
        int shd;
        string name_uni;
        string country_uni;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id_university"] == null)
            {
                Response.Redirect("~/HireMe/Home.aspx");
                return;
            }

             int id_univer = Convert.ToInt32(Session["id_university"]);
            string q = "select * from tb_university where id_university =" + id_univer + "";
            
            das = new Data_Access();
            var dt_uni = das.SelectData(q);

             name_uni = dt_uni.Rows[0][2].ToString();
             country_uni = dt_uni.Rows[0][5].ToString();

           var dt_spec_gra= das.SelectData("select * from tb_graduate where graduate_profession='"+name_uni+ "' and graduate_university_country='"+country_uni+"' and graduate_check=0");
            
            if (dt_spec_gra.Rows.Count == 0)
            {
                lab_id_number_grdute.Text = "finish";
                lab_name_gradute.Text = "finish";
                lab_last_gradute.Text = "finish";
                lab_father_name.Text = "finish";
                lab_mather_name.Text = "finish";
                lab_date_gra.Text = "finish";
                lab_avg.Text = "finish";
                lab_prof.Text = "finish";

                return;
            }
            id_grad =(int) dt_spec_gra.Rows[0][0];
            lab_id_number_grdute.Text = dt_spec_gra.Rows[0][1].ToString();
            lab_name_gradute.Text = dt_spec_gra.Rows[0][2].ToString();
            lab_last_gradute.Text = dt_spec_gra.Rows[0][3].ToString();
            lab_father_name.Text = dt_spec_gra.Rows[0][4].ToString();
            lab_mather_name.Text = dt_spec_gra.Rows[0][5].ToString();
            lab_date_gra.Text= dt_spec_gra.Rows[0][6].ToString();
            lab_avg.Text= dt_spec_gra.Rows[0][7].ToString(); 
            lab_prof.Text= dt_spec_gra.Rows[0][8].ToString();

         


        }
        protected void btn_yes_Click(object sender, EventArgs e)
        {
            if (CheckBox_id_num.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }
            if (CheckBox_FNmae.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }
            if (CheckBox_LNmae.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }
            if (CheckBox_fa_name.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }
            if (CheckBox_mather_name.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }
            if (CheckBox_avg.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }
            if (CheckBox_porn.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }
            if (CheckBox_prof.Checked == false)
            {
                lab_error.Text = "must checked all";
                return;
            }



            shd = 0;
            if (CheckBox_shd.Checked)
            {
                shd = 1;
            }
            das = new Data_Access();
            das.open_connection();
            das.EX_Non_Query("update tb_graduate set graduate_check=1,graduate_shahid='" + shd+"' where id_graduate=" + id_grad+"");
            das.close_connection();
            var dt_spec_gra = das.SelectData("select * from tb_graduate where graduate_profession = '"+name_uni+ "' and graduate_university_country = '"+country_uni+"' and graduate_check = 0");
           
            if (dt_spec_gra.Rows.Count == 0)
            {


                lab_id_number_grdute.Text = "finish";
                lab_name_gradute.Text = "finish";
                lab_last_gradute.Text = "finish";
                lab_father_name.Text = "finish";
                lab_mather_name.Text = "finish";
                lab_date_gra.Text = "finish";
                lab_avg.Text = "finish";
                lab_prof.Text = "finish";
                return;
            }
            id_grad = (int)dt_spec_gra.Rows[0][0];
            lab_id_number_grdute.Text = dt_spec_gra.Rows[0][1].ToString();
            lab_name_gradute.Text = dt_spec_gra.Rows[0][2].ToString();
            lab_last_gradute.Text = dt_spec_gra.Rows[0][3].ToString();
            lab_father_name.Text = dt_spec_gra.Rows[0][4].ToString();
            lab_mather_name.Text = dt_spec_gra.Rows[0][5].ToString();
            lab_date_gra.Text = dt_spec_gra.Rows[0][6].ToString();
            lab_avg.Text = dt_spec_gra.Rows[0][7].ToString();
            lab_prof.Text = dt_spec_gra.Rows[0][8].ToString();

            CheckBox_id_num.Checked = false;
            CheckBox_avg.Checked = false;
            CheckBox_fa_name.Checked = false;
            CheckBox_FNmae.Checked = false;
            CheckBox_LNmae.Checked = false;
            CheckBox_mather_name.Checked = false;
            CheckBox_porn.Checked = false;
            CheckBox_prof.Checked = false;
            CheckBox_shd.Checked = false;

            lab_error.Text = " ";
            CheckBox_checkall.Checked = false;
        }

        protected void btn_no_Click(object sender, EventArgs e)
        {
            string message=" ";
            if (CheckBox_id_num.Checked == false)
            {
                message += "خطأ بالرقم الوطني,";
            }
            if (CheckBox_FNmae.Checked == false)
            {
                message += "خطأ بالاسم الأول ";
            }
            if (CheckBox_LNmae.Checked == false)
            {
                message += "خطأ بالاسم الثاني ,";
            }
            if (CheckBox_fa_name.Checked == false)
            {
                message += "خطأ بأسم الأب ,";
            }
            if (CheckBox_mather_name.Checked == false)
            {
                message += "خطأ بالسم الأم ,";
            }
            if (CheckBox_avg.Checked == false)
            {
                message += "خطأ بالمعدل,";
            }
            if (CheckBox_porn.Checked == false)
            {
                message += "خطأ بتاريخ الولادة ";
            }
            if (CheckBox_prof.Checked == false)
            {
                message += "خطأ بالإختصاص";
            }

            if (CheckBox_shd.Checked)
            {
                shd = 1;
            }
            das = new Data_Access();
            das.open_connection();
            das.EX_Non_Query("update tb_graduate set graduate_check = 3, graduate_shahid = '" + shd+"' where id_graduate = " + id_grad+"");
            das.close_connection();

            CheckBox_id_num.Checked = false;
            CheckBox_avg.Checked = false;
            CheckBox_fa_name.Checked = false;
            CheckBox_FNmae.Checked = false;
            CheckBox_LNmae.Checked = false;
            CheckBox_mather_name.Checked = false;
            CheckBox_porn.Checked = false;
            CheckBox_prof.Checked = false;
            CheckBox_shd.Checked = false;

            lab_error.Text = " ";
            CheckBox_checkall.Checked = false;
            Response.Redirect($"~/HireMe/Pages-Universities/send message.aspx?id={id_grad} &message={message}");
        }

        protected void CheckBox_checkall_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_id_num.Checked =true;
            CheckBox_avg.Checked =  true;
            CheckBox_fa_name.Checked=true;
            CheckBox_FNmae.Checked =true;
            CheckBox_LNmae.Checked =true;
            CheckBox_mather_name.Checked=true;
            CheckBox_porn.Checked = true;
            CheckBox_prof.Checked = true;
        }
    }
}