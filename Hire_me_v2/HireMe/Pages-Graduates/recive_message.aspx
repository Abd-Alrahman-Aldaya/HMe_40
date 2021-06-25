<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recive_message.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Graduates.recive_message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Recive-Message</title>

    <link href="../Pages-Ministry/CSS/Style1-Ministry.css" rel="stylesheet" />

    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body class="body">
    <form id="form_recive_message" runat="server">
        <div>

            <!--HEADER-->
            <header class="mainHeader" dir="rtl">
                <img src="../image/casing.jpg" width="900"/>
                <nav><ul>
                    <li><a href="../Home.aspx"> <i class="fa fa-home"></i> الصفحة الرئيسية </a></li>
                    <li><a href="result display.aspx"> <i class="fas fa-list-alt"></i>  </a></li>
                    <li><a href="#"> <i class="fa fa-question-circle"></i> حول </a></li>
                    <li><a href="#"><i class="fas fa-phone"></i> اتصل بنا </a></li>  
                </ul></nav>
            </header>

            <!--DOCUMENT-->
            <div class="mainContent">

                <section class="top-Content" dir="rtl" >                    

                    <header>
                       <h1 class="title-post" style="font-size:40px">البريد الواردة</h1>
                   </header>                    

                    <div class="post-document" style="width:60%; padding-bottom:30%">
                        
                        <div class="info-name">
                            <asp:Label ID="lab_text" runat="server" Text="الرسالة الواردة "></asp:Label>
                            <br />  
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            
                            <asp:Label ID="Label1" runat="server" Text="التاريخ"></asp:Label>
                            <br /> 
                        </div>

                        <div class="info-grad" style="width:60%">
                            <asp:Label ID="lab_message" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="lab_Mdate" runat="server" Text="Label"></asp:Label>
                        </div>

                    </div>

                    <div class="btn" style="width:50%">
                       <asp:Button CssClass="button" ID="btn_ok" runat="server" Text="تم" OnClick="btn_ok_Click" />
                        <br />
                        <br />
                       <asp:Button CssClass="button" ID="btn_edite" runat="server" Text="اعادة ادخال بيانات" OnClick="btn_edite_Click" />
                    </div>

                </section>

            </div>                               

            <!--SIDE-->
            <div class="mainSide">
                <aside>
                    <article class="sidebar1" dir="rtl">
                        <h2 class="title-side">استقبال رسائل</h2>
                        <p class="post-side">
                           تم اظهار في البريد الوارد استلام رسالة جامعة .
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
</body>
</html>
