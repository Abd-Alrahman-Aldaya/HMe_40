<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Hire_me_v2.HireMe.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Page-Home</title>

    <link href="Pages-Ministry/CSS/Style1-Ministry.css" rel="stylesheet" />

</head>

<body class="body" style="width:85%">
    <form id="form_page_home" runat="server">
        <div>

            <!--HEADER-->
                <header class="mainHeader" dir="rtl">
                    <img src="image/casing.jpg" width="900" />
                    <nav><ul>
                        <li><a href="Pages-Ministry/Sign-in-Ministry.aspx"><i class="fa fa-user"> </i> تسجيل الدخول </a></li>
                        <li><a href="#"> <i class="fas fa-list-alt"></i> قائمة </a></li>
                        <li><a href="#"> <i class="fa fa-question-circle"></i> حول </a></li>
                        <li><a href="#"><i class="fas fa-phone"></i> اتصل بنا </a></li>  
                    </ul></nav>
                </header>

             <!--DOCUMENT-->
                <div class="mainContent">
                    <section class="top-Content" dir="rtl">

                        <header>
                            <h1 class="title-post">صفحة الرئيسية</h1>
                        </header>

                        <section class="post-document">

                            <ul>
                                <li>
                                    <a href="#">
                                        <h3 class="title-login links"><i class="fa fa-chevron-left icon"></i> تسجيل معلومات  </h3>
                                    </a>
                                </li>

                                <li>
                                    <a href="#">
                                        <h3 class="title-login links"><i class="fa fa-chevron-left icon"></i> تحقق معلومات  </h3>
                                    </a>
                                </li>

                                <li>
                                    <a href="#">
                                        <h3 class="title-login links"><i class="fa fa-chevron-left icon"></i>إظهار النتيجة  </h3>
                                    </a>
                                </li>
                            </ul>

                        </section>

                    </section>
                </div>

            <!--SIDE-->
                <div class="mainSide">
                    <aside>
                        <article class="sidebar1" dir="rtl">
                            <h2 class="title-side">تسجيل الدخول</h2>
                            <p class="post-side">
                                -  إذا كان لديك حساب
                                الوزارتك الحالية يمكن تسجيل
                                أو إدخال الأسم المستخدم
                                أو البريد الالكتروني وكلمة المرور.
                            </p>
                        </article>
                    </aside>
                    <aside>
                        <article class="sidebar1" dir="rtl">
                            <h2 class="title-side">إنشاء حساب</h2>
                            <p class="post-side">
                                - إن لم يكن لديك حساب للتسجيل الدخول
                                يمكن إنشاء حساب جديد خاص بالوزارتك الحالية
                                و يجب إدخال معلومات المطلوبة والتحقق من البيانات المدخلة.
                            </p>
                        </article>
                    </aside>
                    <aside>
                        <article class="sidebar1" dir="rtl" style="margin-bottom: 0%;">
                            <h2 class="title-side">تنبيه خاص </h2>
                            <p class="post-side">
                                - عند إنشاء حساب جديد الوزارة
                                سيتم عرض معلوات والشواغر والشروط إضافة
                                خاصة بالوزارة على الصفحة المسؤول .
                            </p>
                        </article>
                    </aside>
                </div>

                <!--FOOTER-->
                <footer class="footer">
                    <div class="post-footer">
                        <p class="title-footer">جميع حقوق محفوظة لموقع مفاضلة المهندسين الالكترونية - 2021</p>
                    </div>
                </footer>

        </div>
    </form>

    <script src="js/icons.js"></script>
</body>
</html>
