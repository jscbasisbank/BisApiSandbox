namespace AuthApi.Web.NewFolder
{
    public class TransferBatchVal 
    {
        public string SenderAcc { get; set; }
        public string Ccy { get; set; }
        public string ReceiverAcc { get; set; }
        public string ReceiverAccName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverBankCode { get; set; }
        public string ReceiverBankName { get; set; }
        public decimal Amount { get; set; }
        public string Descrip { get; set; }
        public string ExtraInfo { get; set; }
        public string IntermediateBankCode { get; set; }
        public string IntermediateBankName { get; set; }
        public string DetailOfCharg { get; set; }
        public int? DocNum { get; set; }
        public int? ClientInternalID { get; set; }
    }
}
