<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
        Password: <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
        <asp:Button ID="cmdLogon" runat="server" Text="Logon" 
            onclick="cmdLogon_Click" />    
    </div>
    </form>
</body>
</html>
