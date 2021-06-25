using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HireMe.Class;
using System.Data;

namespace HireMe.Class
{
    //كلاس خاص بالموقع يوجد فيه الاجراءات التي سيتم تنفيذهاوالعمل عليها داخل المشروع
    public class C_HireMe
    {

        //ميثود يأخذ باراميتر المعدل و الإختصاص
        public DataTable check_vacancy(int avg, string prof)
        {  
            string q = "select ministry_name+' | '+ vacancy_type z,id_vacancy, ministry_name, vacancy_type from tb_ministry,tb_vacancy where tb_vacancy.id_ministry=tb_ministry.id_ministry and tb_vacancy.vacancy_avg<='" + avg + "'and tb_vacancy.vacancy_name='" + prof + "';";
            Data_Access ds = new Data_Access();
            //تنفيذ التعلية و حفظها في جدول برمجي
            DataTable dt = ds.SelectData(q);
            //يعيد اسم الوزارة و نوع الشرط حسب قيمة الباراميتر
            return dt;
        }

        DataTable dt_all_grad;
        public DataTable sort_shahed()
        {
            // لكل شريحة  datatable  تم انشاء
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
            //----------------------------------------
            //تعليمة عرض الطلاب ذات المعدل فوق ال 90 وليسوا من ابناء الشهداء 
            string q_90_normal = "select * from tb_graduate where graduate_shahid=0 and  graduate_avg>=90 order by graduate_avg desc";
            dt_90_normal = ds.SelectData(q_90_normal);

            //تعليمة عرض الطلاب ذات المعدل فوق ال 90 وهم من ابناء الشهداء 
            string q_90_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=90 order by graduate_avg desc";
            dt_90_shahed = ds.SelectData(q_90_shahed);
            //----------------------------------------

            //تعليمة عرض الطلاب ذات المعدل فوق ال 80 وليسوا من ابناء الشهداء 
            string q_80_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=80 and graduate_avg<90 order by graduate_avg desc";
            dt_80_normal = ds.SelectData(q_80_normal);

            //تعليمة عرض الطلاب ذات المعدل فوق ال 80 وهم من ابناء الشهداء 
            string q_80_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=80 and graduate_avg<90 order by graduate_avg desc";
            dt_80_shahed = ds.SelectData(q_80_shahed);
            //----------------------------------------

            //تعليمة عرض الطلاب ذات المعدل فوق ال 70 وليسوا من ابناء الشهداء 
            string q_70_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=70 and graduate_avg<80 order by graduate_avg desc";
            dt_70_normal = ds.SelectData(q_70_normal);

            //تعليمة عرض الطلاب ذات المعدل فوق ال 70 وهم من ابناء الشهداء 
            string q_70_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=70 and graduate_avg<80 order by graduate_avg desc";
            dt_70_shahed = ds.SelectData(q_70_shahed);

            //----------------------------------------
            //تعليمة عرض الطلاب ذات المعدل فوق ال 60 وليسوا من ابناء الشهداء 
            string q_60_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=60 and graduate_avg<70 order by graduate_avg desc";
            dt_60_normal = ds.SelectData(q_60_normal);
            //تعليمة عرض الطلاب ذات المعدل فوق ال 60 وهم من ابناء الشهداء 
            string q_60_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=60 and graduate_avg<70 order by graduate_avg desc";
            dt_60_shahed = ds.SelectData(q_60_shahed);

            //----------------------------------------
            //تعليمة عرض الطلاب ذات المعدل فوق ال 50 وليسوا من ابناء الشهداء 
            string q_50_normal = "select * from tb_graduate where graduate_shahid=0 and graduate_avg>=50 and graduate_avg<60 order by graduate_avg desc";
            dt_50_normal = ds.SelectData(q_50_normal);
            //تعليمة عرض الطلاب ذات المعدل فوق ال 50 وهم من ابناء الشهداء 
            string q_50_shahed = "select * from tb_graduate where graduate_shahid=1 and graduate_avg>=50 and graduate_avg<60 order by graduate_avg desc";
            dt_50_shahed = ds.SelectData(q_50_shahed);
            //----------------------------------------
            //تم انشاء كائن جديد من  
            dt_all_grad = new DataTable();
            //قمت بتعبئة الداتا تابل ليقوم يانشاء سطور 
            dt_all_grad = ds.SelectData("select * from tb_graduate");
            // متحول تتم زيادته في كل حلقة للتعبئة وتجنب اعادة المعرّف لكل خريج عند كل حلقة 
            int y = 0;
            //حلقة للمرور على كل الخريجين ضمن الشريحة الواحدة
            for (int i = 0; i < dt_90_shahed.Rows.Count; i++)
            {
                //حلقة لتعبئة الحقول 
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_90_shahed.Rows[i][j];
                }
                //  زيادة المتحول لتجنب فقدان البيانات 
                y++;

            }
            //---------------------------
            for (int i = 0; i < dt_90_normal.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_90_normal.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_80_shahed.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_80_shahed.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_80_normal.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_80_normal.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_70_shahed.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_70_shahed.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_70_normal.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_70_normal.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_60_shahed.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_60_shahed.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_60_normal.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_60_normal.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_50_shahed.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_50_shahed.Rows[i][j];
                }
                y++;
            }
            //---------------------------
            for (int i = 0; i < dt_50_normal.Rows.Count; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dt_all_grad.Rows[y][j] = dt_50_normal.Rows[i][j];
                }
                y++;
            }
            //لحفظ البيانات وامكانية اجراء المعالجات 
            return dt_all_grad;
        }

        //ميثود للتشفير 
        public static string encoding(string txt, int key)
        {
            //تحويل السلسلة النصية الى مصفوفة احرف
            char[] chr = txt.ToCharArray();
            //متحول لاجراءالمعالجات عليه وعدم تغيير القيم السابقة 
            char letter;
            //حلقة للمرور على المصفوفة  
            for (int i = 0; i < chr.Length; i++)
            {
                //اسناد الحرف الى المتحول لاجراء المعالجة
                letter = chr[i];
                //اضافة الحرف الى المتحول بعد اضافة قيمة 5 كمفتاح للتشفير
                letter = (char)(letter + key);
                //ارجاع الحرف بعد التشفير الى المصفوفة
                chr[i] = letter;
            }
            //تحويل المصفوفة الى متحول نصي 
            return new string(chr);
        }


        public static string Encrypt(string txt, int key)
        {
            //ميثود استدعاء الطريقة 
            return encoding(txt, key);
        }

        public static string Decrypt(string txt, int key)
        {
            //ميثود استدعاء الطريقة 
            return encoding(txt, -key);
        }

        public void SORT()
        {
            //انشاء كائن لامكانية الوصول والتعامل مع قاعدة البيانات 
            Data_Access ds = new Data_Access();
            //متحول معرف الخريج
            int id_grad;
            //متحول لكتابة تعليمة لجلب معرف الرغبة
            string q_id_vacancy;
            DataTable dt_vacancy = new DataTable();
            //متحول لاختصاص الخريج
            string prof_grad;
            //متحول لكتابة تعليمة لجلب عدد الشواغر المتاحة 
            string q_count_vac;
            DataTable dt_count_vac = new DataTable();
            //متحول لعدد الشواغر
            int count_vac;
            //متحول لعدد الشواغر التي تم تعبأتها 
            int? count_vac_check = 0;
            //حلقة للمرور على كل الخريجين 
            for (int i = 0; i < dt_all_grad.Rows.Count; i++)
            {
                //تعبئة معرف الخريج 
                id_grad = (int)dt_all_grad.Rows[i][0];
                //متحول لجلب ترتيب الرغبة المختارة 
                var count_des = ds.SelectData("select des_order from tb_desire where id_graduate = " + id_grad + "");
                //حلقة للمرور على الرغبات المختارة لكل خريج
                for (int j = 1; j <= count_des.Rows.Count; j++)
                {
                    //تعليمة جلب معرف  الشاغر بناءاً على معرف الخريج وترتيب الرغبة المختارة  
                    q_id_vacancy = "select id_vacancy from tb_desire where id_graduate='" + id_grad + "' and des_order='" + j + "' ";
                    //لتنفيذ التعليمة
                    dt_vacancy = ds.SelectData(q_id_vacancy);
                    //تعبئة اختصاص الطالب
                    prof_grad = dt_all_grad.Rows[i][8].ToString();
                    //تعليمة لجلب عدد الشواغر المتاحة والتي تم اختيارها بناءاً على معرف الشاغر
                    q_count_vac = "select vacancy_count,vacancy_check_count from tb_vacancy where id_vacancy=" + (int)dt_vacancy.Rows[0][0] + ";";
                    //لتنفيذ التعليمة
                    dt_count_vac = ds.SelectData(q_count_vac);
                    //تعبئة عدد الشواغر المتاحة ضمن متحول 
                    count_vac = (int)dt_count_vac.Rows[0][0];
                    //شرط من اجل الفرز الاول لكل شاغر لكي يأخذ قيمة الصفر  
                    if (dt_count_vac.Rows[0][1] == null)
                    {
                        //فتح الاتصال مع قاعدة البيانات 
                        ds.open_connection();
                        //تعليمة تعديل على عدد الشواغر التي تم اختيارهاحسب معرف الشاغر
                        ds.EX_Non_Query_Insert("update tb_vacancy set vacancy_check_count =" + count_vac_check + " where id_vacancy=" + (int)dt_vacancy.Rows[0][0] + ";");

                    }
                    //تعليمة لجلب عدد الشواغر التي تم اختيارها لمعرفة امكانية الاضافة او لا 
                    var dt_check_count = ds.SelectData("select vacancy_check_count from tb_vacancy where id_vacancy=" + (int)dt_vacancy.Rows[0][0] + ";");
                    //لاسناد الى متحول 
                    count_vac_check = (int)dt_check_count.Rows[0][0];
                    //تعليمة لجلب معرف الوزارة لاسنادها الى جدول اخر بناءاً على معرف الشاغر الذي تم اختياره
                    var dt_id_ministry = ds.SelectData("select id_ministry from tb_vacancy where id_vacancy =" + (int)dt_vacancy.Rows[0][0] + ";");
                    //شرط لطرح عدد الشواغر المطلوبة مع عدد الشواغر التي تم اختيارها لمعرفة امكانية اختيار هذه الرغبة للخريج
                    if (count_vac - count_vac_check > 0)
                    {
                        //فتح اتصال مع قاعدة البيانات
                        ds.open_connection();
                        //تعليمة اضافة الى جدول النتيجة (معرف الوزارة,معرف الخريج) لامكانية العرض ومعرفة النتيجة 
                        ds.EX_Non_Query_Insert("insert into tb_result (id_ministry,id_graduate) values('" + dt_id_ministry.Rows[0][0] + "','" + id_grad + "')");
                        //زيادةالمتحول مقدار 1
                        count_vac_check += 1;
                        //تعليمة تعديل عدد الشواغر التي تم اختيارها بعد اضافة 1 بعد تأكيد اختيار الرغبة
                        ds.EX_Non_Query("update tb_vacancy set vacancy_check_count='" + count_vac_check + "' where id_vacancy='" + dt_vacancy.Rows[0][0] + "' ");
                        //اغلاق الاتصال
                        ds.close_connection();
                        //للخروج من رغبات الطالب والانتقال الى الطالب التالي
                        break;
                    }
                }
            }
        }
       
        public bool check_string(string Text)
        {
            // التحقق من اذا كان النص فارغ او يحتوي على مسطرة
            if (string.IsNullOrEmpty(Text))
            {
                //إذا تحقق الشرط رد خطا
                return false;
            }
            //التحقق من ان النص تحتوي علي إشارات محددة
            if (Text.Contains('<') || Text.Contains('-') || Text.Contains(';'))
            {
                //إذا تحقق الشرط رد خطا
                return false;
            }
            // يرد صح في حال لم يتحقق اي شرط
            return true;
        }
        // ميثود تأخذ باراميتر نص و تعليمة مولفة من عمود واحد لجلب بيانات من قاعدة البيانات 
        public bool check_Email(string Text, string quary_email)
        {

            Data_Access das = new Data_Access();
            //جلب  معلومات التعليمة
            var dt_email = das.SelectData(quary_email);
            // حلقة للدوران على كامل الجدول البرمجي
            for (int i = 0; i < dt_email.Rows.Count; i++)
            {
                //شرط اذا كان احد قيم العمود الاول الحقول بالجدول يساوي النص الاول المرسل
                if (dt_email.Rows[i][0].ToString() == Text)
                {
                    //سيقوم بإرجاع خطأ
                    return false;
                }
            }
            //اذا لم يتحقق الشرط نرجع صح 
            return true;
        }
        // ميثود تأخذ باراميتر نص اول وبارامتر نص ثاني و تعليمة مؤلفة من عمودين لجلب بيانات من قاعدة البيانات 
        public bool double_check(string Text1, string Text2, string quary_email)
        {

            //select culumeName,culumeName, from table 
            Data_Access das = new Data_Access();
            var dt_email = das.SelectData(quary_email);
            // حلقة للدوران على كامل الجدول البرمجي
            for (int i = 0; i < dt_email.Rows.Count; i++)
            {
                //شرط اذا كان احد قيم العمود الاول الحقول بالجدول يساوي النص الاول المرسل
                if (dt_email.Rows[i][0].ToString() == Text1)
                {
                    //شرط اذا كان احد قيم العمود الثاني بالحقل المحدد بالشرط السابق يساوي النص الثاني المرسل
                    if (dt_email.Rows[i][1].ToString() == Text2)
                    {
                        //سيقوم بإرجاع خطأ
                        return false;
                    }
                }
            }
            //اذا لم يتحقق الشرط نرجع صح 
            return true;
        }
    }
}