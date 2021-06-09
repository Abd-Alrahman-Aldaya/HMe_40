<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="send message.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Universities.send_message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Send-Message</title>

    <link href="../Pages-Ministry/CSS/Style1-Ministry.css" rel="stylesheet" />

    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body class="body">
    <form id="form_Send_Message" runat="server">
        <div>

             <!--HEADER-->
            <header class="mainHeader" dir="rtl">
                <img src="../image/casing.jpg" width="900"/>
                <nav><ul>
                    <li><a href="#"> <i class="fa fa-home"></i> الصفحة الرئيسية </a></li>
                    <li><a href="#"> <i class="fas fa-list-alt"></i> قائمة </a></li>
                    <li><a href="#"> <i class="fa fa-question-circle"></i> حول </a></li>
                    <li><a href="#"><i class="fas fa-phone"></i> اتصل بنا </a></li>  
                </ul></nav>
            </header>

            <!--DOCUMENT-->
            <div class="mainContent">

                <section class="top-Content" dir="rtl" >                    

                    <header>
                       <h1 class="title-post" style="font-size:40px">إرسال رسالة نصية</h1>
                   </header>

                    <h3 class="title-login"><i class="fa fa-chevron-left icon" ></i>  اكتب الرسالة<asp:Label ID="lab_error" runat="server" Font-Size="25px" ForeColor="Red" Text="*"></asp:Label>
                    </h3>

                    <section class="post-document" style="width:60%;">

                        <%--<asp:Label ID="Label1" runat="server" Text="اكتب الرسالة "></asp:Label>--%>
                        

                               <div class="post-form" style="height:90%">
                                   <span class="icon"><i class="fas fa-message"></i></span>                                     
                                   <asp:TextBox ID="txt_message" CssClass="input-textarea input"  AutoCompleteType="Disabled" runat="server" TextMode="MultiLine" Height="200px" Width="90%"></asp:TextBox>                                              
                               </div>

                    </section>

                    <div class="btn" style="width:45%">
                        <asp:Button CssClass="button" ID="btn_send" runat="server" Text="ارسال " OnClick="btn_send_message" />
                    </div>

                </section>

            </div>

           <!--SIDE-->
            <div class="mainSide">
                <aside>
                    <article class="sidebar1" dir="rtl">
                        <h2 class="title-side">رسالة الجامعة</h2>
                        <p class="post-side">
                           سيتم تهيئة رسالة جاهزة يمكن تعديل
                            .عليها حسب ما يلزم وإرسالها الى الخريج
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
