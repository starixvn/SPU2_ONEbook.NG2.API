using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONEbook.NG2.API.Utils
{
    internal class ApiFunction
    {
        public enum Func
        {
            /// <summary>
            /// Synchonizes customer to 3rd.
            /// </summary>
            CreateAccount,

            /// <summary>
            /// Changes user group commission.
            /// </summary>
            ChangeSetting,

            /// <summary>
            /// Gets risk and forecast page url.
            /// </summary>
            ShowRiskAndForecast,

            /// <summary>
            /// Synchronizes exchange rate.
            /// </summary>
            SyncExchangeRate,

            /// <summary>
            /// Checks list of customers are synchronized or not with 3rd.
            /// </summary>
            CheckIsSyncCustomers,

            /// <summary>
            /// Kicks member out of lobby game.
            /// </summary>
            KickOutMember,

            /// <summary>
            /// Shows result of all sports by date.
            /// </summary>
            ShowResult,

            /// <summary>
            /// Shows ticket result of member.
            /// </summary>
            ShowTicketResult
        }
    }
}