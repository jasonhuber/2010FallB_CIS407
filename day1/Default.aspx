<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>My First Page</title>
    <script language="javascript">
        function Add() {
            document.form1.lblResult.value =
                parseFloat(document.form1.txtNum1.value) +
                parseFloat(document.form1.txtNum2.value);

            alert("from the client!");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="lblResult" runat="server"></asp:TextBox><br />
        <asp:Button ID="cmdAdd" runat="server" Text="Add" onclick="cmdAdd_Click" />
        <input type=button name="btnAdd" onclick="Add()" />
    </div>
    </form>
</body>
</html>
