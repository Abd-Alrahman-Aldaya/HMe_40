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
        .adm
        {
            background-color:darkblue;
            color:white;
            direction:rtl;
           margin-left:860px;
           margin-top:-22px;
           padding-bottom:50px;
           
          
          
        }
        .count2 , .count3{
            margin-top:20px;
            display:none;
        }
        .count2 .bn1 , .count3 .bn1
        {
            color:white;
            background-color:#14213D;
            padding:0px 25px;
            height:40px;
            text-align:center;
            
        } 
        .count3 .bn1{
            padding:0px 40px;
            font-size:15px;
            font-weight:bold;
        }
        .count2 .bn1:hover , .count3 .bn1:hover
        {
            
           
           border-bottom-right-radius:40%;
           border-top-right-radius:40%;
            
        }
        .li1{
            margin-top:60px;
        }
        .adm li:hover{
            margin-right:6px;
            font-size:25px;
            color:black;
           
        }
      .li1
      {
          font-size:20px;
          font-weight:bold;
          cursor:pointer;
      } 
      .G1
      {
          width:200px;       
      }
      .fu1 ,.gradvi
      {
         position:absolute;
         top:450px;
         left:300px;
         background-color:#eee;
         padding:30px;
         padding-left:100px;
         height:500px;
       
      }
      .fu1{
           display:none;
      }
      .gradvi
      {
          width:500px;
          left:300px
      }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div >
                <img class="img-responsive" src="../tarek/images/casing.jpg" />
            </div>
              <nav class="navbar navbar-default" role="navigation" style=" background-color:#14213D;color:white;">
          <div class="navbar-header">
               <span class="span2" runat="server"> H I R E_ M E</span>

              <button type="button" class="navbar-toggle" data-target="#ta" data-toggle="collapse">
                  <span class="icon-bar"></span>
                  <span class="icon-bar"></span>
                  <span class="icon-bar"></span>
              </button>
          </div>
          <div class="collapse navbar-collapse" id="ta">
              <ul class="nav navbar-nav navbar-right">
                  
                  <li class="mov stop"><a href="#" style="color:red;">توقيف الموقع</a></li>
                  <li class="mov open"><a href="#" style="color:greenyellow;Background:none">تشغيل الموقع</a></li>
                  
              </ul>
          </div>

      </nav>
          
        <div class="row">
            <div class="adm col-xs-3">
                <ul style="list-style: none;">
                        <li class="li1 sor" >أولوية الفرز</li>
                        <li class="li1 cn1">إدارة الحسابات</li>
                       <div class="count2">
                            <asp:Button ID="ministry_manigar" runat="server"  CssClass="bn1"  Text="ministry" OnClick="ministry_manigar_Click" /><br /><br />
                            <asp:Button ID="university_manigar" runat="server" CssClass="bn1" Text="university" OnClick="university_manigar_Click" />                                 
                       </div>
                        <li class="li1 cn3">استعراض الحسابات</li>  
                     <div class="count3">
                            <asp:Button ID="ministry" runat="server" OnClick="ministry_Click" Text="الوزارة" CssClass="bn1" /><br /><br />
                            <asp:Button ID="university" runat="server" Text="الجامعة" OnClick="university_Click" CssClass="bn1" /><br /><br />
                            <asp:Button ID="admin" runat="server" Text="الأدمن " OnClick="admin_Click" CssClass="bn1" /><br /><br />
                   
                     </div>
                </ul>
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
    
            </div>
         </div>
    
    </form>
    <script src="../tarek/java%20script/jquery.js"></script>
    <script src="../tarek/java%20script/bootstrap.min.js"></script>
    <script src="../tarek/java%20script/java.js"></script>
   
    <script>
       
    </script>
</body>
</html>
