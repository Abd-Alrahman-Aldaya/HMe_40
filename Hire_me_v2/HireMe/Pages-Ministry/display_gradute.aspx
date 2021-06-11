<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display_gradute.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Ministry.display_gradute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>All-View</title>

    <link href="CSS/Style2-Ministry.css" rel="stylesheet" />

    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <style>
        .grid{
            margin-left:100px;
            text-align:right;
        }
    </style>

</head>
<body class="body">
   <form id="form_All_View" runat="server">
        <div>

            <!--HEADER-->
            <header class="mainHeader">
                <nav><ul>
                    <li><a href="Sign-in.aspx"> <i class="fa fa-home"></i> الصفحة الرئيسية </a></li>
                    <li><a href="#"> <i class="fas fa-list-alt"></i> قائمة </a></li>
                    <li><a href="#"> <i class="fa fa-question-circle"></i> حول </a></li>
                    <li><a href="#"><i class="fas fa-phone"></i> اتصل بنا </a></li>  
                </ul></nav>
            </header>

             <!--DOCUMENT-->
            <div class="mainContent">

                <section class="top-Content" >

                    <header>
                        <h1 class="title-post"><i class="fa fa-chevron-left icon" ></i> استعراض الخريجين </h1>
                        <img src="../image/logo-hire-me.png" />
                    </header>
                    <br />
                    <br />

                    <section class="post-document">

                        <div class="post-form">
                            <asp:GridView ID="GridView_All" Width="427px" Height="232px" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" CssClass="grid"  >
                                <AlternatingRowStyle BackColor="Gainsboro" />
                                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#000065" />
                            </asp:GridView>

        <%--                          <dl id="dl_vac" runat="server">
                                    <dt id="dt_vac">
                                         <ul><li id="li_vac" runat="server"></li></ul>
                                    </dt>
                                     <dd id="dd_con" runat="server">
                                          <ul><li id="li_con" runat="server"></li></ul>
                                     </dd>

                                  </dl>--%>
                          
                            
                          
                        </div>
                        <br />
                        <br />
                        <br />

                    </section>
                </section>
            </div>

             <!--SIDE-->
            <div class="mainSide">

                <aside class="sidebar">

                    <header>
                        <h2 class="title-side">إدارة الوزارات</h2>
                    </header>

                    <ul style="list-style: none;">
                        <li><a runat="server" onserverclick="function_link_add_vacany">إضافة الشاغر</a></li>
                        <li><a runat="server" onserverclick="function_link_update_vacany">تعديل الشاغر</a></li>
                        <li><a runat="server" onserverclick="function_link_add_condition">إضافة الشرط</a></li>
                        <li><a runat="server" onserverclick="function_link_update_condition">تعديل الشرط</a></li>
                        <li><a runat="server" onserverclick="function_link_view_cond_vac">استعراض الشواغر و الشروط</a></li>
                        <li><a runat="server" onserverclick="Unnamed_ServerClick">استعراض الخريج</a></li>
                    </ul>

                </aside>

            </div>

            <!--FOOTER-->
            <footer class="footer">
                    <div class="post-footer">
                        <p class="title-footer">جميع حقوق محفوظة لموقع مفاضلة المهندسين الالكترونية - 2021</p>
                    </div>
            </footer>

            <script src="../js/icons.js"></script>

        </div>
    </form>

</body>
</html>
