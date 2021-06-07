using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HireMe.Class;
using System.Data;

namespace HireMe.Class
{
    public class C_HireMe
    {
        DataTable order;

        public DataTable Order { get => order; set => order = value; }

        public void AVG_Sort()
        {
            string q = "select * from tb_graduate order by graduate_avg desc";
            Data_Access ds = new Data_Access();
            Order= ds.SelectData(q);
        }
        public DataTable check_vacancy(int avg ,string prof)
        {
          //  string q = "select ministry_name+ vacancy_type ministry_name, vacancy_type from tb_ministry,tb_vacancy where tb_vacancy.id_ministry=tb_ministry.id_ministry and tb_vacancy.vacancy_avg>='" + avg+"'and tb_vacancy.vacancy_name='"+prof+"';";
            string q = "select ministry_name+' | '+ vacancy_type z,id_vacancy, ministry_name, vacancy_type from tb_ministry,tb_vacancy where tb_vacancy.id_ministry=tb_ministry.id_ministry and tb_vacancy.vacancy_avg>='" + avg+"'and tb_vacancy.vacancy_name='"+prof+"';";
            Data_Access ds = new Data_Access();
            DataTable dt = ds.SelectData(q);
            return dt ;
        }

        //public void choice()
        //{
        //    Data_Access ds = new Data_Access();
        //    DataTable dt = new DataTable();
        //    for (int i = 0; i < Order.Rows.Count; i++)
        //    {
        //        int x = (int)order.Rows[i][0];
        //        for (int j = 1; j < 6; j++)
        //        {
        //        string q = "select id_vacancy from tb_desire where id_graduate='" + x + "' and des_order='" + j + "'";
        //        var x1 =  ds.SelectData(q);
        //         var s = ds.SelectData("select vacancy_count from tb_vacancy where id_vacancy='"+x1.Rows[0][0]+"'");
        //            var x2 = ds.SelectData("select * from tb_result where id_ministry='" + x1 + "'");
        //            if (x2.Rows.Count <(int) s.Rows[0][0])
        //            {

        //            }
        //        }

        //    }

        //}

        //public DataTable Insert_To_Desire(string minstryname, string vacancy_type,int id_grudat,int desorder)
        //{
        //    string q = "select id_ministry from tb_ministry where ministry_name='" + minstryname + "'";
        //    Data_Access ds = new Data_Access();
        //    DataTable dt = ds.SelectData(q);
        //    int id_minstry =(int) dt.Rows[0][0];
        //    ds.open_connection();
        //    ds.EX_Non_Query("insert into tb_desire (id_graduate,id_vacancy,des_order) values('"+id_grudat+"','"+id_minstry+"','"+desorder+"')");
        //    ds.close_connection();
        //        return dt;
        // }
        public void Insert_To_Desire(int id_vacancy, string vacancy_type, int id_grudat, int desorder)
        {
           // string q = "select id_ministry from tb_ministry where ministry_name='" + minstryname + "'";
            Data_Access ds = new Data_Access();
          //  DataTable dt = ds.SelectData(q);
         //   int id_minstry = (int)dt.Rows[0][0];
            ds.open_connection();
            ds.EX_Non_Query("insert into tb_desire (id_graduate,id_vacancy,des_order) values('" + id_grudat + "'," + id_vacancy + ",'" + desorder + "')");
            ds.close_connection();
           
        }

        public void insert_To_Result()
        {

            int id_gradute = 0;
            Data_Access ds = new Data_Access();
            //gradute prof
            //vac count 
            AVG_Sort();
            for (int i = 0; i < order.Rows.Count; i++)
            {
                id_gradute = (int)order.Rows[i][0];
                string prof = "select graduate_profession from tb_graduate where id_graduate ='" + id_gradute + "';";
                var pro = ds.SelectData(prof);
                for (int j = 0; j < 1; j++)
                {
                    var id_minstry_desire = ds.SelectData("select id_vacancy from tb_desire where id_graduate='" + id_gradute + "'and des_order='" + 1 + "'");
                    string count = "select vacancy_count from tb_vacancy where id_ministry ='" + id_minstry_desire.Rows[0][0] + "' and vacancy_name ='" + pro.Rows[0][0] + "'";
                    var vaccount = ds.SelectData(count);

                    if ((int)vaccount.Rows[0][0] > 0)
                    {
                        // توقفنا عندما فرش البرنامج عند الطالب رقم 2 و سنكمل بعد انتهاء من صفحة الطالب
                        string insert_to_result = "insert into tb_result values('" + id_minstry_desire.Rows[0][0] + "','" + id_gradute + "';";
                        ds.open_connection();
                        //   ds.EX_Non_Query(insert_to_result);
                        ds.close_connection();
                        break;
                    }
                }
            }
        }

        public void sort_shahed()
        {
            Data_Access ds = new Data_Access();
            DataTable dt_90_shahed = new DataTable();
            DataTable dt_90_normal = new DataTable();
            DataTable dt_80_shahed = new DataTable();
            DataTable dt_80_normal = new DataTable();
            DataTable dt_70_shahed = new DataTable();
            DataTable dt_70_normal = new DataTable();
            DataTable dt_60_shahed = new DataTable();
            DataTable dt_60_normal = new DataTable();
            DataTable dt_50_shahed = new DataTable();
            DataTable dt_50_normal = new DataTable();
            // DataTable dt_all = new DataTable();
            // string q_shahed = "select * from tb_graduate";
            // dt_all = ds.SelectData(q_shahed);
            //----------------------------------------
            string q_90_normal = "select * from tb_graduate where graduate_shahid=0 and  graduate_avg>=90 order by graduate_avg desc";
            dt_90_normal = ds.SelectData(q_90_normal);
            string q_90_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=90 order by graduate_avg desc";
            dt_90_shahed = ds.SelectData(q_90_shahed);
            //----------------------------------------
            string q_80_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=80 and graduate_avg<90 order by graduate_avg desc";
            dt_80_normal = ds.SelectData(q_80_normal);
            string q_80_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=80 and graduate_avg<90 order by graduate_avg desc";
            dt_80_shahed = ds.SelectData(q_80_shahed);
            //----------------------------------------
            string q_70_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=70 and graduate_avg<80 order by graduate_avg desc";
            dt_70_normal = ds.SelectData(q_70_normal);
            string q_70_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=70 and graduate_avg<80 order by graduate_avg desc";
            dt_70_shahed = ds.SelectData(q_70_shahed);
            //----------------------------------------
            string q_60_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=60 and graduate_avg<70 order by graduate_avg desc";
            dt_60_normal = ds.SelectData(q_60_normal);
            string q_60_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=60 and graduate_avg<70 order by graduate_avg desc";
            dt_60_shahed = ds.SelectData(q_60_shahed);
            //----------------------------------------
            string q_50_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=50 and graduate_avg<60 order by graduate_avg desc";
            dt_50_normal = ds.SelectData(q_50_normal);
            string q_50_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=50 and graduate_avg<60 order by graduate_avg desc";
            dt_50_shahed = ds.SelectData(q_50_shahed);
            //----------------------------------------
            ds.open_connection();
            string q_delete_grad = "delete from tb_graduate";
            ds.EX_Non_Query(q_delete_grad);
            string insert_90_shahed;
            for (int i = 0; i < dt_90_shahed.Rows.Count; i++)
            {
                 insert_90_shahed = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                        "values('" + dt_90_shahed.Rows[i][1] + "','" + dt_90_shahed.Rows[i][2] + "','" + dt_90_shahed.Rows[i][3] + "','" + dt_90_shahed.Rows[i][4] + "','" + dt_90_shahed.Rows[i][5] + "','" + dt_90_shahed.Rows[i][6] + "','" + dt_90_shahed.Rows[i][7] + "','" + dt_90_shahed.Rows[i][8] + "','" + dt_90_shahed.Rows[i][9] + "','" + dt_90_shahed.Rows[i][10] + "','" + dt_90_shahed.Rows[i][11] + "','" + dt_90_shahed.Rows[i][12] + "','" + dt_90_shahed.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_90_shahed);
            }
            //---------------------------
            string insert_90_normal;
            for (int i = 0; i < dt_90_normal.Rows.Count; i++)
            {
                insert_90_normal = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                        "values('" + dt_90_normal.Rows[i][1] + "','" + dt_90_normal.Rows[i][2] + "','" + dt_90_normal.Rows[i][3] + "','" + dt_90_normal.Rows[i][4] + "','" + dt_90_normal.Rows[i][5] + "','" + dt_90_normal.Rows[i][6] + "','" + dt_90_normal.Rows[i][7] + "','" + dt_90_normal.Rows[i][8] + "','" + dt_90_normal.Rows[i][9] + "','" + dt_90_normal.Rows[i][10] + "','" + dt_90_normal.Rows[i][11] + "','" + dt_90_normal.Rows[i][12] + "','" + dt_90_normal.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_90_normal);
            }
            //---------------------------
            string insert_80_shahed;
            for (int i = 0; i < dt_80_shahed.Rows.Count; i++)
            {
                 insert_80_shahed = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                        "values('" + dt_80_shahed.Rows[i][1] + "','" + dt_80_shahed.Rows[i][2] + "','" + dt_80_shahed.Rows[i][3] + "','" + dt_80_shahed.Rows[i][4] + "','" + dt_80_shahed.Rows[i][5] + "','" + dt_80_shahed.Rows[i][6] + "','" + dt_80_shahed.Rows[i][7] + "','" + dt_80_shahed.Rows[i][8] + "','" + dt_80_shahed.Rows[i][9] + "','" + dt_80_shahed.Rows[i][10] + "','" + dt_80_shahed.Rows[i][11] + "','" + dt_80_shahed.Rows[i][12] + "','" + dt_80_shahed.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_80_shahed);
            }
            //---------------------------
            string insert_80_normal;
            for (int i = 0; i < dt_80_normal.Rows.Count; i++)
            {
                 insert_80_normal = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                        "values('" + dt_80_normal.Rows[i][1] + "','" + dt_80_normal.Rows[i][2] + "','" + dt_80_normal.Rows[i][3] + "','" + dt_80_normal.Rows[i][4] + "','" + dt_80_normal.Rows[i][5] + "','" + dt_80_normal.Rows[i][6] + "','" + dt_80_normal.Rows[i][7] + "','" + dt_80_normal.Rows[i][8] + "','" + dt_80_normal.Rows[i][9] + "','" + dt_80_normal.Rows[i][10] + "','" + dt_80_normal.Rows[i][11] + "','" + dt_80_normal.Rows[i][12] + "','" + dt_80_normal.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_80_normal);
            }
            //---------------------------
            string insert_70_shahed;
            for (int i = 0; i < dt_70_shahed.Rows.Count; i++)
            {
                 insert_70_shahed = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                        "values('" + dt_70_shahed.Rows[i][1] + "','" + dt_70_shahed.Rows[i][2] + "','" + dt_70_shahed.Rows[i][3] + "','" + dt_70_shahed.Rows[i][4] + "','" + dt_70_shahed.Rows[i][5] + "','" + dt_70_shahed.Rows[i][6] + "','" + dt_70_shahed.Rows[i][7] + "','" + dt_70_shahed.Rows[i][8] + "','" + dt_70_shahed.Rows[i][9] + "','" + dt_70_shahed.Rows[i][10] + "','" + dt_70_shahed.Rows[i][11] + "','" + dt_70_shahed.Rows[i][12] + "','" + dt_70_shahed.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_70_shahed);
            }
            //---------------------------
            string insert_70_normal;
            for (int i = 0; i < dt_70_normal.Rows.Count; i++)
            {
                 insert_70_normal = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                        "values('" + dt_70_normal.Rows[i][1] + "','" + dt_70_normal.Rows[i][2] + "','" + dt_70_normal.Rows[i][3] + "','" + dt_70_normal.Rows[i][4] + "','" + dt_70_normal.Rows[i][5] + "','" + dt_70_normal.Rows[i][6] + "','" + dt_70_normal.Rows[i][7] + "','" + dt_70_normal.Rows[i][8] + "','" + dt_70_normal.Rows[i][9] + "','" + dt_70_normal.Rows[i][10] + "','" + dt_70_normal.Rows[i][11] + "','" + dt_70_normal.Rows[i][12] + "','" + dt_70_normal.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_70_normal);
            }
            //---------------------------
            string insert_60_shahed;
            for (int i = 0; i < dt_60_shahed.Rows.Count; i++)
            {
                insert_60_shahed = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                       "values('" + dt_60_shahed.Rows[i][1] + "','" + dt_60_shahed.Rows[i][2] + "','" + dt_60_shahed.Rows[i][3] + "','" + dt_60_shahed.Rows[i][4] + "','" + dt_60_shahed.Rows[i][5] + "','" + dt_60_shahed.Rows[i][6] + "','" + dt_60_shahed.Rows[i][7] + "','" + dt_60_shahed.Rows[i][8] + "','" + dt_60_shahed.Rows[i][9] + "','" + dt_60_shahed.Rows[i][10] + "','" + dt_60_shahed.Rows[i][11] + "','" + dt_60_shahed.Rows[i][12] + "','" + dt_60_shahed.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_60_shahed);
            }
            //---------------------------
            string insert_60_normal;
            for (int i = 0; i < dt_60_normal.Rows.Count; i++)
            {
                insert_60_normal = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                       "values('" + dt_60_normal.Rows[i][1] + "','" + dt_60_normal.Rows[i][2] + "','" + dt_60_normal.Rows[i][3] + "','" + dt_60_normal.Rows[i][4] + "','" + dt_60_normal.Rows[i][5] + "','" + dt_60_normal.Rows[i][6] + "','" + dt_60_normal.Rows[i][7] + "','" + dt_60_normal.Rows[i][8] + "','" + dt_60_normal.Rows[i][9] + "','" + dt_60_normal.Rows[i][10] + "','" + dt_60_normal.Rows[i][11] + "','" + dt_60_normal.Rows[i][12] + "','" + dt_60_normal.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_60_normal);
            }
            //---------------------------
            string insert_50_shahed;
            for (int i = 0; i < dt_50_shahed.Rows.Count; i++)
            {
                insert_50_shahed = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                       "values('" + dt_50_shahed.Rows[i][1] + "','" + dt_50_shahed.Rows[i][2] + "','" + dt_50_shahed.Rows[i][3] + "','" + dt_50_shahed.Rows[i][4] + "','" + dt_50_shahed.Rows[i][5] + "','" + dt_50_shahed.Rows[i][6] + "','" + dt_50_shahed.Rows[i][7] + "','" + dt_50_shahed.Rows[i][8] + "','" +dt_50_shahed.Rows[i][9] + "','" + dt_50_shahed.Rows[i][10] + "','" + dt_50_shahed.Rows[i][11] + "','" + dt_50_shahed.Rows[i][12] + "','" + dt_50_shahed.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_50_shahed);
            }
            //---------------------------
            string insert_50_normal;
            for (int i = 0; i < dt_50_normal.Rows.Count; i++)
            {
                insert_50_normal = "insert into tb_graduate (graduate_id_number,graduate_first_name,graduate_last_name,graduate_father_name,graduate_mother_name,graduate_date,graduate_avg,graduate_profession,graduate_resident_country,graduate_shahid,graduate_email,graduate_password,graduate_check) " +
                       "values('" + dt_50_normal.Rows[i][1] + "','" + dt_50_normal.Rows[i][2] + "','" + dt_50_normal.Rows[i][3] + "','" + dt_50_normal.Rows[i][4] + "','" + dt_50_normal.Rows[i][5] + "','" + dt_50_normal.Rows[i][6] + "','" + dt_50_normal.Rows[i][7] + "','" + dt_50_normal.Rows[i][8] + "','" + dt_50_normal.Rows[i][9] + "','" + dt_50_normal.Rows[i][10] + "','" + dt_50_normal.Rows[i][11] + "','" + dt_50_normal.Rows[i][12] + "','" + dt_50_normal.Rows[i][13] + "')";
                ds.EX_Non_Query_Insert(insert_50_normal);
            }
            ds.close_connection();
           
        }


        public string encoding(string txt)
        {
            char[] chr = txt.ToCharArray();
            char letter;
            for (int i = 0; i < chr.Length; i++)
            {
                letter = chr[i];
                letter = (char)(letter + 5);
                chr[i] = letter;
            }
            return new string(chr);
        }


        public void SORT()
        {
            Data_Access ds = new Data_Access();
            string q_get_id_grad = "select * from tb_graduate";
            DataTable dt_all_grad = new DataTable();
            dt_all_grad = ds.SelectData(q_get_id_grad);
            int id_grad;
            string q_id_vacancy;
            DataTable dt_vacancy = new DataTable();
            string prof_grad;
            string q_count_vac;
            DataTable dt_count_vac = new DataTable();
            int count_vac;
            for (int i = 0; i < dt_all_grad.Rows.Count; i++)
            {
                for (int j = 1; i < 6; i++)
                {
                    id_grad = (int)dt_all_grad.Rows[i][0];
                    q_id_vacancy = "select id_vacancy from tb_desire where id_graduate='" + id_grad + "' and des_order='" + j + "' ";
                    dt_vacancy = ds.SelectData(q_id_vacancy);
                    //int s = (int)dt_vacancy.Rows[0][0];
                    prof_grad = dt_all_grad.Rows[i][8].ToString();
                    q_count_vac = "select vacancy_count from tb_vacancy where id_ministry='" + (int)dt_vacancy.Rows[0][0] + "' and vacancy_name='" + prof_grad + "'";
                    dt_count_vac = ds.SelectData(q_count_vac);
                    count_vac = (int)dt_count_vac.Rows[0][0];
                    if (count_vac > 0)  
                    {
                        ds.open_connection();
                        ds.EX_Non_Query_Insert("insert into tb_result (id_ministry,id_graduate) values('" + dt_vacancy.Rows[0][0] + "','" + id_grad + "')");
                        ds.close_connection();
                        break;
                    }
                }
            }
        }


    }
}