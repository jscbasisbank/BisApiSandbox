using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class UploadPackageGelItem 
    {
        public decimal Amount { get; set; }
        public string ReceiverAcc { get; set; }
        public string ReceiverAccName { get; set; }
        public string Descrip { get; set; }
        public string TaxPayerTaxCode { get; set; }
        public string TaxPayerName { get; set; }
        public int? DocNum { get; set; }
    }
}
