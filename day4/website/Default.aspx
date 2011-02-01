<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="insertproduct.aspx">Insert new product</a>
     <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div>
                    Productid: <a href="updateproduct.aspx?productid=<%# DataBinder.Eval(Container.DataItem, "productid")%>"><%# DataBinder.Eval(Container.DataItem, "productid")%></a> - 
                    name: <%# DataBinder.Eval(Container.DataItem, "productname")%> - 
                    description: <%# DataBinder.Eval(Container.DataItem, "productiondescription")%> - 
                    Price: <%# DataBinder.Eval(Container.DataItem, "price")%> - 
                    <img src="images/<%# DataBinder.Eval(Container.DataItem, "imagelocation")%>" /> 

                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
