<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create account university.aspx.cs" Inherits="HireMe.Pages_Universities.create_account_university" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>إنشاء حساب جامعة</title>
     <link href="../tarek/fontawesome/css/font-awesome.css" rel="stylesheet" />
      <link href="../tarek/css/bootstrap.min.css" rel="stylesheet" />
      <link href="../tarek/css/animationn.css" rel="stylesheet" />
      <link href="../tarek/css/media.css" rel="stylesheet" />
      <link href="../tarek/css/tarek-style.css" rel="stylesheet" />
    <style>
    .row .part2
    {
      background-color: #eee;  
      box-shadow:2px 2px 20px olive;
      margin:auto;
      margin-top:30px;
    }

.part2 p
{
    color: #808080;
    font-size: 27px;
    font-weight:bolder;
    margin-bottom: 20px;
}
.row label 
{
    font-size: 20px;
    font-weight: bold;
}
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div class="container" runat="server">
        <div class="img">
            <img class="img-responsive" src="../tarek/images/casing.jpg" />
            
        </div>
       
                <div class="row">
               
                <div class="col-xs-12 ministryhome" dir="rtl">
                     <span class="span1" runat="server">الصفحة الرئيسية</span>
                     <span class="span2" runat="server"> H I R E_ M E</span>               
               </div>
                
                    <br /><br />
                <div class="col-xs-12">
                  <div class="part2 text-center">
                      <p class="text-center"> إنشاء حساب الجامعة </p><br />
                       <form class="form1">
                          <label>الإسم<sup>*</sup></label><br />
                         <asp:TextBox ID="univer_name" runat="server" class="form-control"></asp:TextBox><br /><br />
                         <%-- <input id="univer_name" type="text" required="required" class="form-control" /><br /><br />--%>
                          <label>الإيميل<sup>*</sup></label><br />
                         <asp:TextBox ID="univer_email" runat="server" class="form-control"></asp:TextBox><br /><br />
                          <%-- <input type="text" required="required" class="form-control" id="email" /><br /><br />--%>
                          <label>كلمة السر<sup>*</sup></label><br />
                         <asp:TextBox ID="univer_pass" runat="server" class="form-control"></asp:TextBox><br /><br />
                          <%-- <input type="password" required="required" class="form-control" id="pa1" /><br /><br />--%>
                          <label>تأكيد كلمة السر <sup>*</sup></label><br />
                         <asp:TextBox ID="univer_conf_pass" runat="server" class="form-control"></asp:TextBox><br /><br />
                          <%--<input type="password" required="required" class="form-control" id="pa2" maxlength="12" /><br /><br />--%>
                         <%-- <input type="checkbox"  class="check1 " value=" " /><span class="sp2">  I agree to the</span><span class="sp1">  Terms of use </span><span class="sp2">and the </span><span class="sp1"> privacy policy</span><br /><br />--%>
                          <label>الهاتف <sup>*</sup></label><br />
                          <asp:TextBox ID="univer_phone" runat="server" class="form-control"></asp:TextBox><br /><br />
                         <label>المحافظة <sup>*</sup></label><br />
                          <asp:DropDownList ID="DropDown_country" runat="server" OnSelectedIndexChanged="DropDown_country_SelectedIndexChanged">
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
                          </asp:DropDownList><br /><br />
                          <input type="submit" class="btn-info" value="تأكيد" onclick="confirmpassword()"  runat="server" onserverclick="sing_in_univarsity" />
                           <br />
                           <br />
                           <label id ="lab_error" style ="color:red; font-size:30px" runat="server">  </label>
                          </form>
                  </div>
              </div>
                    </div>               
              </div>
             <br />
    </form>
    <script src="../tarek/java%20script/bootstrap.min.js"></script>
    <script src="../tarek/java%20script/jquery.js"></script>
    <script src="../tarek/java%20script/java.js"></script>
    <script>
        $(".part2 input").focus(function () {
            $(".row label").css("color", "green");
        });
        $(".part2 input").blur(function ()
        {
            $(".row label").css("color", "black");
        })
    </script>
</body>
</html>
