using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUBEAccounts.Common;

namespace NUBEAccounts.SL.Hubs
{
    public partial class NubeServerHub
    {
        private BLL.UserTypeDetail UserTypeDetailDAL_BLL(DAL.UserTypeDetail d)
        {
            BLL.UserTypeDetail b = d.toCopy<BLL.UserTypeDetail>(new BLL.UserTypeDetail());
            b.UserTypeFormDetail = d.UserTypeFormDetail.toCopy<BLL.UserTypeFormDetail>(new BLL.UserTypeFormDetail());
            return b;
        }
    }
}