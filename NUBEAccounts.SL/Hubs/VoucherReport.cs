using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NUBEAccounts.SL.Hubs
{
    public partial class NubeServerHub
    {
        public List<BLL.VoucherReport> VoucherReport_List(int? LedgerId, DateTime dtFrom, DateTime dtTo, string EntryNo, string PayTo)
        {
            List<BLL.VoucherReport> lstVoucherReport = new List<BLL.VoucherReport>();
            BLL.VoucherReport rp = new BLL.VoucherReport();
            var lstLedger = DB.Ledgers.Where(x => x.AccountGroup.CompanyId == Caller.CompanyId && (LedgerId == null || x.Id == LedgerId)).ToList();
         
            decimal? TotAmountDr = 0, TotAmountCr = 0;
            return lstVoucherReport;
        }
    }
}
