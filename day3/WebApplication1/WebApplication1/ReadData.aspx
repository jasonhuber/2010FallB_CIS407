<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadData.aspx.cs" Inherits="WebApplication1.ReadData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div>
                    firstname: <%# DataBinder.Eval(Container.DataItem, "firstname")%><br />
                    Lastname:<%# DataBinder.Eval(Container.DataItem, "lastname")%><br />
                    email:<%# DataBinder.Eval(Container.DataItem, "email")%><br />
                    username:<%# DataBinder.Eval(Container.DataItem, "username")%><br />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
