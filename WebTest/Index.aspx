<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebTest.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%
           var service = new ONEbook.NG2.API.Services();

           var rq1 = new ONEbook.NG2.API.DTO.CheckIsSyncCustomer.Request();
           rq1.Auth.SiteId = 2000;
           rq1.UserId = 8;
           rq1.Call.AccountArray.Add(new ONEbook.NG2.API.DTO.CheckIsSyncCustomer.AccountInfo { ObCustId = 123456 });
           var rs1 = service.CheckIsSyncCustomers(rq1);

           var rq2 = new ONEbook.NG2.API.DTO.CreateCurrency.Request();
           rq2.Auth.SiteId = 2000;
           rq2.UserId = 8;
           rq2.Call.CurrencyArray.Add(new ONEbook.NG2.API.DTO.CreateCurrency.CurrencyInfo { CurrencyId = 1, CurrencyName = "US$", ExchangeRate = 3.5678M });
           var rs2 = service.CreateCurrency(rq2);

           var rq3 = new ONEbook.NG2.API.DTO.ShowParlayDetail.Request();
           rq3.UserId = 8;
           rq3.Auth.SiteId = 2000;
           rq3.Call.TransactionId = "123456";
           var rs3 = service.ShowParlayDetail(rq3);

           var rq4 = new ONEbook.NG2.API.DTO.ShowResult.Request();
           rq4.UserId = 8;
           rq4.Auth.SiteId = 2000;
           var rs4 = service.ShowResult(rq4);

           var rq5 = new ONEbook.NG2.API.DTO.ShowRiskAndForecast.Request();
           rq5.Auth.SiteId = 2000;
           rq5.UserId = 8;
           rq5.Call.ObCustId = 123456;
           var rs5 = service.ShowRiskAndForecast(rq5);

           var rq6 = new ONEbook.NG2.API.DTO.ShowTicketResult.Request();
           rq6.Auth.SiteId = 2000;
           rq6.UserId = 8;
           rq6.Call.GambleId = 1;
           var rs6 = service.ShowTicketResult(rq6);

           var rq7 = new ONEbook.NG2.API.DTO.CreateAccount.Request();
           rq7.Auth.SiteId = 2000;
           rq7.UserId = 8;
           rq7.Call.CurrencyId = 1;
           rq7.Call.AccountArray.Add(new ONEbook.NG2.API.DTO.CreateAccount.AccountInfo { ObCustId = 123456 });
           rq7.Call.Level = 4;
           rq7.Call.UplineId = 123456;
           var rs7 = service.SyncCustomers(rq7);

           var rq8 = new ONEbook.NG2.API.DTO.SyncExchangeRate.Request();
           rq8.Language = "zh-CN";
           rq8.Auth.SiteId = 2000;
           rq8.UserId = 8;
           rq8.Call.CurrencyArray.Add(new ONEbook.NG2.API.DTO.SyncExchangeRate.CurrencyInfo { CurrencyId = 1, ExchangeRate = 3.4567M });
           var rs8 = service.SyncExchangeRates(rq8);


            %> 
            
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs1) %><br />
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs2) %><br />
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs3) %><br />
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs4) %><br />
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs5) %><br />
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs6) %><br />
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs7) %><br />
        <%= ONEbook.NG2.API.Utils.ApiJsonConvert.SerializeObject(rs8) %><br />
    </div>
    </form>
</body>
</html>
