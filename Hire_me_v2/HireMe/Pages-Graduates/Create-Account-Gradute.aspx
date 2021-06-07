<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create-Account-Gradute.aspx.cs" Inherits="HireMe.Pages_Graduates.Sign_in_Gradutes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Create-Account-Gradutes</title>

    <link href="CSS/Style1-Gradute.css" rel="stylesheet" />

    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>
<body class="body">
    <form id="form_Create_Account_Gradute" runat="server">
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
                       <h1 class="title-post">وظفني</h1>
                   </header>
                    

                    <h3 class="title-login"><i class="fa fa-chevron-left icon" ></i>  بيانات الشخصية </h3>

                    <div class="post-document">
                        <div class="colume1">
                               <div class="post-login">
                                   <span class="icon"><i class="fas fa-user"></i></span>
                                   <span class="title-input">الأسم الأول</span>
                                   <asp:TextBox ID="first_name_gradute" CssClass="input" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            
                                   <span class="span-bottom"></span>
                               </div>
                               <br />

                             <div class="post-login">
                                   <span class="icon"><i class="fas fa-user"></i></span>
                                   <span class="title-input">أسم العائلة</span>
                                   <asp:TextBox ID="last_name_gradute" CssClass="input" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            
                                   <span class="span-bottom"></span>
                               </div>
                               <br />
                               

                               <div class="post-login">
                                   <span class="icon"><i class="fas fa-male"></i></span>
                                   <span class="title-input">الاسم الأب </span>
                                   <asp:TextBox ID="fname_gradute" CssClass="input" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            
                                   <span class="span-bottom"></span>
                               </div>
                               <br />

                               <div class="post-login">
                                   <span class="icon"><i class="fas fa-female"></i></span>
                                   <span class="title-input">الاسم الأم </span>
                                   <asp:TextBox ID="mname_gradute" CssClass="input" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            
                                   <span class="span-bottom"></span>
                               </div>
                               <br />
                         </div>

                        <div class="colume2">

                             <div class="post-login">
                                <span class="icon"><i class="fas fa-lock"></i></span>
                                <span class="title-input">رقم الوطني</span>
                                <asp:TextBox ID="id_number_gradute" CssClass="input" TextMode="Password" AutoCompleteType="Disabled" MaxLength="20" runat="server"></asp:TextBox>                                
                                <span class="span-bottom"></span>
                            </div>

                               <div class="post-login">
                                   <span class="icon"><i class="far fa-calendar-alt"></i></span>
                                   <span class="title-input">تاريخ الولادة </span>
                                   <asp:TextBox ID="date_gradute" CssClass="input" TextMode="Date" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            
                                   <span class="span-bottom"></span>
                               </div>
                               <br />

                               <div class="post-login">
                                   <span class="icon"><i class="fas fa-phone"></i></span>
                                   <span class="title-input">هاتف </span>
                                   <asp:TextBox ID="phone_gradute" CssClass="input" TextMode="Number" AutoCompleteType="Disabled" MaxLength="10" runat="server"></asp:TextBox>                               
                                   <span class="span-bottom"></span>
                               </div>

                               <div class="post-login">
                                   <span class="icon"><i class="fas fa-phone"></i></span>
                                   <span class="title-input">محافظة </span>
                                   <asp:DropDownList ID="DDL_country_gradute" CssClass="drop_level" runat="server">
                                         <asp:ListItem Value="damas">دمشق</asp:ListItem>
                                          <asp:ListItem Value="allepo">حلب</asp:ListItem>
                                          <asp:ListItem Value="homs">حمص</asp:ListItem>
                                          <asp:ListItem Value="hama">حماة</asp:ListItem>
                                          <asp:ListItem Value="latakya">اللاذقية </asp:ListItem>
                                          <asp:ListItem Value="tartos">طرطوس</asp:ListItem>
                                          <asp:ListItem Value="adlep">ادلب</asp:ListItem>
                                          <asp:ListItem Value="daraa">درعا</asp:ListItem>
                                          <asp:ListItem Value="soedaa">السويداء</asp:ListItem>
                                          <asp:ListItem Value="qunetra">القنيطرة</asp:ListItem>
                                          <asp:ListItem Value="daeralzor">دير الزور</asp:ListItem>
                                          <asp:ListItem Value="hasaka">الحسكة</asp:ListItem>
                                          <asp:ListItem Value="raqa">الرقة</asp:ListItem>
                         
                                   </asp:DropDownList>
                               </div> 

                         </div>
                    </div>

                    <br />
                    <h3 class="title-login" style="margin-top:47%;"><i class="fa fa-chevron-left icon" ></i>  المستوى التعليمي </h3>  


                    <div class="post-document">
                        <div class="colume1">
                            <div class="post-login">
                                <span class="icon"><i class="fas fa-th-list"></i></span>
                                <span class="title-input">الاختصاص </span>
                               <%-- <asp:TextBox ID="specialization_gradute" CssClass="input" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            --%>
                                 <asp:DropDownList ID="DDL_specialization_gradute" CssClass="drop_level" runat="server">
                                       
                                </asp:DropDownList>
                                <span class="span-bottom"></span>
                            </div>
                            <br />

                             <div class="post-login">
                                <span class="icon"><i class="fas fa-th-list"></i></span>
                                <span class="title-input">المعدل </span>
                                <asp:TextBox ID="avg_gradute" CssClass="input" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                            
                                <span class="span-bottom"></span>
                            </div>
                            <br />

                        </div>

                        <div class="colume2">
                            <div class="post-login">
                                <span class="icon"><i class="fa fa-bookmark"></i></span>
                                <span class="title-input">محافظة الجامعة
                                </span>
                                <asp:DropDownList ID="university_country" CssClass="drop_level" runat="server" AutoPostBack="True" OnSelectedIndexChanged="university_country_SelectedIndexChanged">
                                          <asp:ListItem Value="damas">دمشق</asp:ListItem>
                                          <asp:ListItem Value="allepo">حلب</asp:ListItem>
                                          <asp:ListItem Value="homs">حمص</asp:ListItem>
                                          <asp:ListItem Value="hama">حماة</asp:ListItem>
                                          <asp:ListItem Value="latakya">اللاذقية </asp:ListItem>
                                          <asp:ListItem Value="tartos">طرطوس</asp:ListItem>
                                          <asp:ListItem Value="adlep">ادلب</asp:ListItem>
                                          <asp:ListItem Value="daraa">درعا</asp:ListItem>
                                          <asp:ListItem Value="soedaa">السويداء</asp:ListItem>
                                          <asp:ListItem Value="qunetra">القنيطرة</asp:ListItem>
                                          <asp:ListItem Value="daeralzor">دير الزور</asp:ListItem>
                                          <asp:ListItem Value="hasaka">الحسكة</asp:ListItem>
                                          <asp:ListItem Value="raqa">الرقة</asp:ListItem>
                                </asp:DropDownList>

                            </div>

                        </div>
                    </div>

                    <br />
                    <h3 class="title-login" style="margin-top:25%;"><i class="fa fa-chevron-left icon" ></i>  حساب الكتروني جديد </h3>  

                    <div class="post-document">
                        <div class="colume1">
                            <div class="post-login">
                                 <span class="icon"><i class="fas fa-envelope"></i></span>
                                 <span class="title-input">البريد الالكتروني</span>
                                 <asp:TextBox ID="email_gradute_new" CssClass="input" TextMode="Email" AutoCompleteType="Disabled" runat="server"></asp:TextBox>                                
                                 <span class="span-bottom"></span>
                            </div>
                         </div>

                        <div class="colume2">
                            <div class="post-login">
                                <span class="icon"><i class="fas fa-lock"></i></span>
                                <span class="title-input">كلمة المرور</span>
                                <asp:TextBox ID="pass_gradute_new" CssClass="input" TextMode="Password" AutoCompleteType="Disabled" MaxLength="20" runat="server"></asp:TextBox>                                
                                <span class="span-bottom"></span>
                            </div>
                        </div>
                    </div>

                    <div class="post-document btn">                        
                            <button runat="server" id="btn_to_next_gradute" class="button" onserverclick="function_Create_Account_Next" title="Creare_Account" ><i class="fa fa-caret-left icon-btn" style="font-size:20px; margin-left:2%;"></i> التالي </button>
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
