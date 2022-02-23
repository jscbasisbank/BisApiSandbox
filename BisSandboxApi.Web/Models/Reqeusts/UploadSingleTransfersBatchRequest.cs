using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class UploadSingleTransfersBatchRequest
    {
        public string TicketId { get; set; }
        public string Otp { get; set; }
        public List<TransferBatchInternal> InternalTransfers { get; set; }
        public List<TransferBatchGel> NationalCurrencyTransfers { get; set; }
        public List<TransferBatchVal> ForeignCurrencyTransfers { get; set; }
        public List<TransferBatchTreasury> TreasuryTransfers { get; set; }
    }

}
