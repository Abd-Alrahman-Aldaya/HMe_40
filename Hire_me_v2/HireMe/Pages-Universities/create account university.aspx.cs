﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HireMe.Class;
using System.Data;

namespace HireMe.Pages_Universities
{
    public partial class create_account_university : System.Web.UI.Page
    {
        Data_Access ds;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string country;
        protected void sing_in_univarsity(object sender, EventArgs e)
        {
            ds = new Data_Access();
            string univer_name1 = univer_name.Text;
            string q_insert_info = "insert into tb_university (university_name,university_email,university_password,university_country) values('"+univer_name1+"','"+univer_email.Text+"','"+univer_pass.Text+"','"+country+"')";
            ds.open_connection();
            ds.EX_Non_Query_Insert(q_insert_info);
            string q_id_univer = "select id_university from tb_university where university_name='"+univer_name1+ "'and university_country='" + country + "'";
            DataTable dt_phone = new DataTable();
            dt_phone= ds.SelectData(q_id_univer);
            string q_insert_phone = "insert into tb_phone (phone,id_unversity) values ('" + univer_phone.Text+"','"+(int)dt_phone.Rows[0][0]+"')";
            ds.EX_Non_Query_Insert(q_insert_phone);
            ds.close_connection();


            univer_name.Text = null;
            univer_email.Text = null;
            univer_pass.Text = null;
            univer_conf_pass.Text = null;
            univer_phone.Text = null;
        }

        protected void DropDown_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = DropDown_country.SelectedValue;
        }
    }
}