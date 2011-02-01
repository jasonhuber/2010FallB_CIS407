<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updateproduct.aspx.cs" Inherits="updateproduct" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      Product ID:<asp:TextBox ID="txtProductId" runat="server"></asp:TextBox><br />
        Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        description: <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox><br />
        price: <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
        QOH: <asp:TextBox ID="txtQOH" runat="server"></asp:TextBox><br />
        image: 
        <asp:FileUpload ID="txtFile" runat="server" /><br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Me!" 
            onclick="btnUpdate_Click" />
    </div>
    </form>
</body>
</html>
