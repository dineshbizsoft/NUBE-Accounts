using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUBEAccounts.Common;

namespace NUBEAccounts.SL.Hubs
{
    public partial class NubeServerHub
    {
        public List<BLL.UserTypeFormDetail> UserTypeFormDetail_List()
        {
            return DB.UserTypeFormDetails.Where(x => x.IsActive == true)
                                         .OrderBy(x => x.OrderNo).ToList()
                                         .Select(x => x.toCopy<BLL.UserTypeFormDetail>(new BLL.UserTypeFormDetail()))
                                         .ToList();
        }
    }
}