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
<<<<<<< HEAD
                                    <a href="#">
                                        <%--<h3 class="title-login links"><i class="fa fa-chevron-left icon"></i> تسجيل معلومات  </h3>--%>
=======
                                    <a href="#" runat="server" onserverclick="function_link_sign_info">
                                        <h3 class="title-login links"><i class="fa fa-chevron-left icon"></i> تسجيل معلومات  </h3>
>>>>>>> eab5a12777f2c43e3294ac0a4d9777c7377f7031
                                    </a>
                                    <i class="fa fa-chevron-left icon"></i>
                                    <asp:Button ID="btn_enter" runat="server"  CssClass="title-login button" Text="تسجيل معلومات" OnClick="btn_enter_Click" />
                                </li>

                                <li>
<<<<<<< HEAD
                                    <a href="#">
                                        <%--<h3 class="title-login links"><i class="fa fa-chevron-left icon"></i> تحقق معلومات  </h3>--%>
=======
                                    <a href="#" runat="server" onserverclick="function_link_check_info">
                                        <h3 class="title-login links"><i class="fa fa-chevron-left icon"></i> تحقق معلومات  </h3>
>>>>>>> eab5a12777f2c43e3294ac0a4d9777c7377f7031
                                    </a>
                                    <i class="fa fa-chevron-left icon"></i>
                                    <asp:Button ID="btn_check" runat="server" CssClass="title-login button" Text="التحقق من وجود خطأ " OnClick="btn_check_Click" />
                                </li>

                                <li>
<<<<<<< HEAD
                                   
                                        <%--<h3 class="title-login links" runat="server" onclick="fun"><i class="fa fa-chevron-left icon" ></i>إظهار النتيجة  </h3>--%>
                                    <i class="fa fa-chevron-left icon"></i>
                                    <asp:Button ID="btn_result" runat="server" CssClass="title-login button" Text="إظهار النتيجة " OnClick="btn_result_Click"  />
                                  
=======
                                    <a href="#" runat="server" onserverclick="function_link_view_result">
                                        <h3 class="title-login links"><i class="fa fa-chevron-left icon"></i>إظهار النتيجة  </h3>
                                    </a>
>>>>>>> eab5a12777f2c43e3294ac0a4d9777c7377f7031
                                </li>
                            </ul>

                        </section>

                    </section>
                </div>
            
            <!--SIDE-->
                <div class="mainSide">
                    <aside>
                        <article class="sidebar1" dir="rtl">
                            <h2 class="title-side">شرح بسيط</h2>
                            <p class="post-side">
                                الرجاء الضغط ع الزر المتاح و استكمال الاجراءات
                            </p>
                        </article>
                    </aside>
                    <aside>
                        <article class="sidebar1" dir="rtl">
                            <h2 class="title-side"> ادخال الرغبات</h2>
                            <p class="post-side">
                               الرجاء اختيار 5 رغبات عند تسجيل الرغبات
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
