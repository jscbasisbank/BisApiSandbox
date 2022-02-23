using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class TransferBatchInternal
    {
        public string SenderAcc { get; set; }
        public string ReceiverAcc { get; set; }
        public string Ccy { get; set; }
        public decimal Amount { get; set; }
        public string Descrip { get; set; }
        public int? DocNum { get; set; }
        public int? ClientInternalID { get; set; }
    }
}
