using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class UploadPackageTreasuryRequest
    {
        public string TicketId { get; set; }
        public string SenderAcc { get; set; }
        public string PackageName { get; set; }
        public string Otp { get; set; }
        public List<UploadPackageGelItem> PackageItems { get; set; }
    }
}
