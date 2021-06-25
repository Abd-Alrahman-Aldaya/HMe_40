<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page-admin.aspx.cs" Inherits="HireMe.Pages_Universities.page_admin" %>

<!DOCTYPE html>
<script runat="server">

</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>page Admin</title>    
    <meta name="viewport" charset="UTF-8" content="width=device-width, initial-scale=1"/>
    <link href="../tarek/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../tarek/css/tarek-style.css" rel="stylesheet" />
    <link href="../tarek/css/media.css" rel="stylesheet" />
    <link href="../tarek/css/animationn.css" rel="stylesheet" />
   
    <style>
        .pan1{
           text-align:center;
           }
        .pn2{
              color: white;
        background-color: #14213D;
        padding: 0px 25px;
        height: 40px;
        text-align: center;
        }
    </style>
 
</head>
    
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div >
                <img class="img-responsive" src="../tarek/images/casing.jpg" />
            </div>
              <nav class="navbar navbar-default" role="navigation" style=" background-color:#14213D;color:white; top: 0px; left: 0px;">
          <div class="navbar-header">
              <a href ="../Home.aspx">
               <span class="span2" runat="server"> H I R E_ M E</span>
                  </a>
              <button type="button" class="navbar-toggle" data-target="#ta" data-toggle="collapse">
                  <span class="icon-bar"></span>
                  <span class="icon-bar"></span>
                  <span class="icon-bar"></span>
              </button>
          &nbsp;</div>
                  <br />
          <div class="collapse navbar-collapse" id="ta">
              <ul class="nav navbar-nav navbar-right">
                  
                  <li class="mov stop"> 
                      <asp:Button ID="btn_stop" CssClass="stop not" runat="server"  Text="ايقاف الموقع" OnClick="btn_stop_Click" /></li>
                  <li class="mov stop">
                      <asp:Button ID="btn_open" CssClass="stop" runat="server" Text="تشغيل الموقع" OnClick="btn_open_Click" /></li>
                  <li class="mov open">
                      <asp:Button ID="btn_check" CssClass="stop" runat="server" Text="فتح تحقق الخريج من صحة معلوماته " OnClick="btn_check_Click" /></li>
                  <li class="mov open">
                      <asp:Button ID="btn_result" CssClass="stop" runat="server" Text=" فتح رؤية الخريج نتيجته" OnClick="btn_result_Click" /></li>
                    <li class="mov open">
                      <asp:Button ID="btn_sort" CssClass="stop" runat="server" Text=" قيام بالفرز" OnClick="btn_sort_Click" /></li>
              </ul>
          </div>
      </nav>
          
           
        <div class="row">
            <div class="adm col-xs-3">
                <ul style="list-style: none;">
                        <li class="li1 cn1">إدارة الحسابات</li>
                       <div class="count2">
                            <asp:Button ID="ministry_manigar" runat="server"  CssClass="bn1"  Text="الوزارة" OnClick="ministry_manigar_Click" /><br /><br />
                            <asp:Button ID="university_manigar" runat="server" CssClass="bn1" Text="الجامعة" OnClick="university_manigar_Click" />                                 
                       </div>
                        <li class="li1 cn3">استعراض الحسابات</li>  
                     <div class="count3">
                            <asp:Button ID="ministry" runat="server" OnClick="ministry_Click" Text="الوزارة" CssClass="bn1" /><br /><br />
                            <asp:Button ID="university" runat="server" Text="الجامعة" OnClick="university_Click" CssClass="bn1" /><br /><br />
                            <asp:Button ID="admin" runat="server" Text="الأدمن " OnClick="admin_Click" CssClass="bn1" /><br /><br />
                   
                     </div>
                    <li class="li1 cn4">استعراض الروابط</li>  
                     <div class="count4">
                             <asp:Button ID="btn_min" CssClass="bn1" runat="server" Text="انشاء وزارة" OnClick="btn_min_Click" /><br /><br />
                             <asp:Button ID="btn_univer" CssClass="bn1" runat="server" Text="انشاء جامعة" OnClick="btn_univer_Click" />
    
                     </div>
                </ul>
            </div>
            
              <div style="text-align:center; margin-left:20%;margin-bottom:300px;">
              <asp:Panel ID="Panel1" runat="server" Height="187px"  Width="405px" CssClass="pan1">
                  <asp:Label ID="lab_open" runat="server" Text="Label"></asp:Label>
                  <asp:Label ID="lab_sort" runat="server" Text="Label"></asp:Label>
                  <br />
                  <br />
                  <br />
                  <br />
                  <asp:Button ID="btn_yes_open" runat="server" CssClass="pn2" Text="تاكيد" OnClick="btn_yes_open_Click" />
                  <asp:Button ID="btn_no_open" runat="server" CssClass="pn2" Text="الغاء" OnClick="btn_no_open_Click" /><br />
                  <asp:Button ID="btn_yes_sort" runat="server" CssClass="pn2" Text="تاكيد" OnClick="btn_yes_sort_Click" />
                  <asp:Button ID="btn_no_sort" runat="server" CssClass="pn2" Text="الغاء" OnClick="btn_no_sort_Click" />
                
            </asp:Panel>
            </div>
              

            <div class="col-xs-5 fu1">
                 <div class="" id="" >   
                     <asp:DropDownList ID="DropDownList2" CssClass="G1" runat="server"></asp:DropDownList>

                       
                        <div class="r2 " id="">
                            <input type="button" class="btn-default" value=">>" /><br />
                             <input type="button" class="btn-default" value="<<" />
                        </div>
                         
                        <asp:DropDownList ID="DropDownList1" CssClass="G1" runat="server"></asp:DropDownList>
                        
                    </div>
            </div>
            
        
        <asp:GridView ID="GridView1" CssClass="gradvi" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
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
            
    <div class="alwezara">
     </div>
            <br />
        <asp:GridView ID="GridView2" CssClass="gradvi" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
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
    
            </div>
         </div>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </form>
    <script src="../tarek/java%20script/jquery.js"></script>
    <script src="../tarek/java%20script/bootstrap.min.js"></script>
    <script src="../tarek/java%20script/java.js"></script>
   
    <script>
       
    </script>
</body>
</html>
