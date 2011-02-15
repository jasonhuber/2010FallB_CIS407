<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Caller.aspx.cs" Inherits="Caller" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script  type="text/javascript"  src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
     <script type="text/javascript">
    
        function LoadProducts() {
            var uls = "";
            $.getJSON("getproducts.aspx",
             function (data) {
                 $.each(data.product, function (key, value) {
                     //need to get some rml in here to load up my LIs...

                     uls += value + "<br />";
                 });
                 debugger;
                 $('body').append(uls);
             });
         }

</script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type=button name=cmdGetData value="Get Data" onclick="javascript:LoadProducts()" />
    </div>
    </form>
</body>
</html>