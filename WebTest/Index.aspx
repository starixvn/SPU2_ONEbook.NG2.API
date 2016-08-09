<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebTest.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%= Newtonsoft.Json.JsonConvert.SerializeObject(ONEbook.NG2.API.Configuration.NG2Configuration.Instance)%>
    </div>
    </form>
</body>
</html>
