<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="HireMe.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

          
           <ul id ="ll" runat="server">
               <li id="ii" runat="server">abd

               </li>

           </ul>
          
        </div>
        <asp:DataList ID="DataList1" runat="server"></asp:DataList>
    </form>
</body>
</html>
