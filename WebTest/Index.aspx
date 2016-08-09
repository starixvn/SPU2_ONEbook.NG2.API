<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebTest.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%= Newtonsoft.Json.JsonConvert.SerializeObject(new ONEbook.NG2.API.DTO.Request())%><br />
        <%= Newtonsoft.Json.JsonConvert.SerializeObject(new ONEbook.NG2.API.DTO.Response())%>
        <%new ONEbook.NG2.API.Services().SyncCustomers(new ONEbook.NG2.API.DTO.Request { Call = new ONEbook.NG2.API.DTO.Call { CustIds = new List<int> { 123456 } } }); %>
    </div>
    </form>
</body>
</html>
