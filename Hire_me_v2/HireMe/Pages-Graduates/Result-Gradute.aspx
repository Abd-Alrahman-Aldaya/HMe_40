<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result-Gradute.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Graduates.Result_Gradute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Result-Gradute</title>

    <link href="CSS/Style1-Gradute.css" rel="stylesheet" />

    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>

<body class="body">

    <form id="form_Result_Gradute" runat="server">
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
                       <h1 class="title-post">النتيجة</h1>
                   </header>

                    <div class="post-document">

                        <div class="post-login">
                            <span class="icon"><i class="fab fa-resolving"></i></span>                        
                            <asp:TextBox ID="result_gradute" CssClass="input" Enabled="false" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            
                            <span class="span-bottom"></span>
                        </div>

                    </div>

                </section>
            </div>  

            <!--FOOTER-->
            <footer class="footer">
                <div class="post-footer">
                    <p class="title-footer">جميع حقوق محفوظة لموقع مفاضلة المهندسين الالكترونية - 2021</p>
                </div>
            </footer>

        </div>
    </form>

    <script src="../js/icons.js"></script>

</body>

</html>
