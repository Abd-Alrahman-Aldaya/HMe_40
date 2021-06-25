using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireMe.Class
{
    //كلاس للتعامل مع قاعدة البيانات من استعراض واضافة وتعديل
    public class Data_Access
    {
        //متحول لسلسلة الاتصال
        string constring;
        // يستخدم لاتصال مع قاعدة البياناتSystem.Data.SqlClient كلاس من 
        SqlConnection connection;
        //يستخدم للاضافة والتعديل على قاعدة البيانات System.Data.SqlClient كلاس من
        SqlCommand sqlcmd;
        //ميثود للتعامل مع قاعدة البيانات 
        public Data_Access()
        {
            // Web.configاعطاء السلسلة للمتحول من  
            constring = ConfigurationManager.ConnectionStrings["tcc_con"].ConnectionString;
            //ادراج سلسلة الاتصال للوصول الى القاعدة
            connection = new SqlConnection(constring);
        }
        //ميثود لفتح الاتصال مع قاعدة البيانات
        public void open_connection()
        {
            //شرط لمعرفة حالة الاتصال مع القاعدة اذا كانت مغلقة
            if (connection.State == ConnectionState.Closed)
            {
                //فتح الاتصال مع القاعدة
                connection.Open();
            }
        }
        //ميثود للاستعراض من قاعدة البيانات بعد اعطاءها التعليمة المطلوبة
        public DataTable SelectData(string Query)
        {
            //استعراض من القاعدة بعد اعطاءها السلسلة والتعليمة المطلوبة
            sqlcmd = new SqlCommand(Query, connection);
            //يحول التعليمة الى بيانات استطيع التعامل معها 
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcmd);
            //جدول برمجي لتعبأة البيانات
            DataTable dataTable = new DataTable();
            //تعبأة البيانات بالجدول البرمجي
            sqlDataAdapter.Fill(dataTable);
            //اعادة الجدول لامكانية التعامل معه بباقي الصفحات 
            return dataTable;
        }
        //ميثود للتعديل او الحذف على جداول قاعدة البيانات 
        public int EX_Non_Query(string Query)
        {
            sqlcmd = new SqlCommand(Query, connection);
            return sqlcmd.ExecuteNonQuery();
        }
        //ميثود للاضافة على جداول قاعدة البيانات
        public void EX_Non_Query_Insert(string insert)
        {
            sqlcmd = new SqlCommand(insert, connection);
            sqlcmd.ExecuteNonQuery();
        }
        //ميثود لاغلاق الاتصال مع قاعدة البيانات
        public void close_connection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}