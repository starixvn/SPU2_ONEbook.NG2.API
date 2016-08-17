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
        <%= Newtonsoft.Json.JsonConvert.SerializeObject(new ONEbook.NG2.API.Services().SyncCustomers(new ONEbook.NG2.API.DTO.Request { Auth = new ONEbook.NG2.API.DTO.Auth { SiteId = "2000" }, Call = new ONEbook.NG2.API.DTO.Call { CustIds = new List<int> { 123456 }, UserId = 8 } })) %>
        <%
            var currencies = new Dictionary<int, decimal>();
            currencies.Add(20, 1.5M);
            currencies.Add(22, 1.8M);

            ONEbook.NG2.API.Services service = new ONEbook.NG2.API.Services();
            service.CheckIsSyncCustomers(new ONEbook.NG2.API.DTO.Request { Call = new ONEbook.NG2.API.DTO.Call { CustIds = new List<int> { 1540414 }, UserId = 16, Currencies = currencies } });
             %>
    </div>
    </form>
</body>
</html>
