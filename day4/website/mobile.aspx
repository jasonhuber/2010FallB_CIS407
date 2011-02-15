<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mobile.aspx.cs" Inherits="mobile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="iui/iui.css" type="text/css" />

<link rel="stylesheet" title="Default" href="iui/t/default/default-theme.css"  type="text/css"/>
<link rel="alternate stylesheet" title="Default using Gradients" href="iui/t/defaultgrad/defaultgrad-theme.css"  type="text/css"/>
<link rel="alternate stylesheet" title="iPhoneDevCamp" href="iui/t/ipdc/ipdc-theme.css"  type="text/css"/>
<script type="application/x-javascript" src="iui/iui.js"></script>
<script type="application/x-javascript" src="iui/js/iui-theme-switcher.js"></script>
 <script  type="text/javascript"  src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
    <script src="rml.js" type="text/javascript"></script>

<script type="text/javascript">
    function LoadProducts(xCatId) {
        //alert(xCatId);
        var lis = "";
        var divs = "";
        $.getJSON("getproducts.aspx?categoryid=" + xCatId,
             function (data) {
                 $.each(data.product, function (key, value) {
                     //need to get some rml in here to load up my LIs...
                     lis += RML.li({ content: RML.a({ href: "#Prod" + value, content: value, _class: "productsclass" }) });
                     divs += RML.ul({ id: "Prod" + value, title: value, content: RML.li({ content: "Loading" }) });
                 });
                 $("#Cat" + xCatId).html(lis);
                 $('body').append(divs);
                 $(".productsclass").each(function (key) {
                     $(this).bind("click", function () {
                         Loadproductdetail(this.text);
                     }
                     );
                 });
             });


         }
         function Loadproductdetail(xProdId) {
             alert(xProdId);
             var lis = "";
             var divs = "";

             $.get("getproductdetail.aspx?prodid=" + xProdId,
             function (data) {
                 $("#Prod" + xProdId).html(data);
             });
         }
</script>
</head>
<body>
      <div class="toolbar">
        <h1 id="pageTitle"></h1>
        <a id="backButton" class="button" href="#"></a>
        
    </div>
    
    <ul id="categories" title="Categories" selected="true">
    <asp:Repeater ID="rptCategories" runat=server>
        <ItemTemplate>
            <li><a href="#Cat<%# DataBinder.Eval(Container.DataItem, "categorynumber")%>" onclick="LoadProducts('<%# DataBinder.Eval(Container.DataItem, "categorynumber")%>')"><%# DataBinder.Eval(Container.DataItem, "categoryname")%></a></li>
        </ItemTemplate>
    </asp:Repeater>
     </ul>
    <asp:Repeater ID="rptCatUls" runat=server>
        <ItemTemplate>
            <ul id="Cat<%# DataBinder.Eval(Container.DataItem, "categorynumber")%>">
            
            </ul>
        </ItemTemplate>
    </asp:Repeater>


   
</body>
</html>
