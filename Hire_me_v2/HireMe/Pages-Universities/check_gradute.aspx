

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="check_gradute.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Universities.check_gradute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Check-Gradute</title>

    <link href="../Pages-Ministry/CSS/Style1-Ministry.css" rel="stylesheet" />

    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

</head>

<body class="body">

    <form id="form_check_graduate" runat="server">

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
                       <h1 class="title-post" style="font-size:40px">تحقق من المعلومات الخريج</h1>
                   </header>

                    <div class="post-document" style="width:60%; padding-bottom:30%">

                        <div class="info-name">
                            <asp:Label ID="Label6" runat="server" Text="الرقم الوطني"></asp:Label>
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="الاسم الاول"></asp:Label>
                            <br />
                             <asp:Label ID="Label2" runat="server" Text="اسم العائلة"></asp:Label>
                            <br />
                             <asp:Label ID="Label3" runat="server" Text="اسم الاب"></asp:Label>
                            <br />
                             <asp:Label ID="Label4" runat="server" Text="اسم الام "></asp:Label>
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="المعدل"></asp:Label>
                            <br />
                             <asp:Label ID="Label7" runat="server" Text="تاريخ الولادة "></asp:Label>
                            <br />
                            <asp:Label ID="Label8" runat="server" Text=" الاختصاص"></asp:Label>
                            <br />
                            <asp:Label ID="Label9" runat="server" Text=" ابن شهيد"></asp:Label>
                        </div>
                            
                        <div class="info-grad">
                            <asp:Label ID="lab_id_number_grdute" runat="server" Text=": "></asp:Label>

                            <br />
                            <asp:Label ID="lab_name_gradute" runat="server" Text=": "></asp:Label>
                            <br />
                            <asp:Label ID="lab_last_gradute" runat="server" Text=":"></asp:Label>
                            <br />
                            <asp:Label ID="lab_father_name" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="lab_mather_name" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="lab_avg" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="lab_date_gra" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="lab_prof" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:CheckBox ID="CheckBox_shd" runat="server" />
                        </div>


                        <div class="check-accept">
                            <asp:CheckBox CssClass="check" ID="CheckBox_id_num" runat="server" />
                            <br />
                            <asp:CheckBox ID="CheckBox_FNmae" runat="server" />
                            <br />
                            <asp:CheckBox ID="CheckBox_LNmae" runat="server" />
                            <br />
                            <asp:CheckBox ID="CheckBox_fa_name" runat="server" />
                            <br />
                            <asp:CheckBox ID="CheckBox_mather_name" runat="server" />
                            <br />
                            <asp:CheckBox ID="CheckBox_avg" runat="server" />
                            <br />
                            <asp:CheckBox ID="CheckBox_porn" runat="server" />
                            <br />
                            <asp:CheckBox ID="CheckBox_prof" runat="server" />
                            <br />
                             <asp:CheckBox ID="CheckBox_checkall" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox_checkall_CheckedChanged" />
                        </div>


                    </div><br />
                    <div  style="width:50%; text-align:center; margin-right:20%"  >
                    <asp:Label ID="lab_error" runat="server" Text=" " ></asp:Label>
                        </div>
                    
                    <div class="btn" style="width:50%">

                            <asp:Button CssClass="button" ID="btn_yes" runat="server" Text="قبول" OnClick="btn_yes_Click" />
                            <br />
                            <br />
                            <asp:Button CssClass="button" ID="btn_no" runat="server" Text="رفض" OnClick="btn_no_Click" />                            
                     </div>

                </section>
            </div>

            <!--SIDE-->
            <div class="mainSide">
                <aside>
                    <article class="sidebar1" dir="rtl">
                        <h2 class="title-side">معلومة محققة</h2>
                        <p class="post-side">
                           يتم اظهار عن بيانات الخريج لتحقيق
                            معلومات الخريج في الجامعة نفسها 
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
        <p class="title-footer">
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
