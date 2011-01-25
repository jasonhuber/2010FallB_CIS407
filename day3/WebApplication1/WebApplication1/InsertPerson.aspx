<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPerson.aspx.cs" Inherits="WebApplication1.InsertPerson" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Person</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        First Name:<asp:TextBox ID="txtFName" runat="server"></asp:TextBox><br />
        Last Name: <asp:TextBox ID="txtLName" runat="server"></asp:TextBox><br />
        Desired Username: <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
        Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
        Password: <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnInsert" runat="server" Text="Add Me!" 
            onclick="btnInsert_Click" />
    </div>
    </form>
</body>
</html>
