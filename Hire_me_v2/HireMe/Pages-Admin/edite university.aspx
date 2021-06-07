<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edite university.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Admin.edite_university" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>ادارة الجامعات</title>
    <meta charset="utf-8" content="width=device-width, initial-scale=1"/>
     <link href="../tarek/fontawesome/css/font-awesome.css" rel="stylesheet" />
    <link href="../tarek/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../tarek/css/tarek-style.css" rel="stylesheet" />
    <style>
      
       
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
          <div class="row ">
              <div class="img  col-xs-12">
                <img class="img-responsive" src="../tarek/images/casing.jpg" />
              </div><br />
            <div class="col-xs-12 ministryhome" dir="rtl">
                <span class="span1" >الصفحة الرئيسية</span>
                <span class="span2"> H I R E_ M E</span>
                
            </div><br /><br /><br />       
              <h1 class="updateministry text-center">تعديل الجامعات</h1><br /><br /><br /><br />
              <div class="col-xs-12 text-center" dir="rtl">
                <br />
                  <label class="upminisrty">الجامعة</label><br />
                  <asp:DropDownList ID="DropDown_university" runat="server" class="dropministry form-control" DataTextField="university_name" DataValueField="university_name"></asp:DropDownList><br />
                  <asp:Label ID="Label1" runat="server" class="upminisrty" Text="الاسم الجديد"></asp:Label><br />
                  <asp:TextBox ID="new_name_university" runat="server"></asp:TextBox><br />
              </div><br /><br /><br /><br /><br /><br />
             
              <div class="col-xs-4">
                  <asp:Button ID="btn_remove" CssClass="btn1mistry form-control" runat="server" Text="حذف" OnClick="btn_remove_Click" />
              </div>
              <div class="col-xs-4">
                  <asp:Button ID="btn_back" CssClass="btn2mistry form-control" runat="server" Text="عودة" OnClick="btn_back_Click" />
              </div>
               <div class="col-xs-4">
                  <asp:Button ID="btn_update" CssClass="btn3mistry  form-control"  runat="server"  Text="تم" OnClick="btn_update_Click" />
              </div> 
            </div>
         
     </div>
        <br /><br />
    </form>
     <script src="../tarek/java%20script/bootstrap.min.js"></script>  
    <script src="../tarek/java%20script/jquery.js"></script>
   <script src="../tarek/java%20script/java.js"></script>
    <script>

</script>
</body>

</html>
