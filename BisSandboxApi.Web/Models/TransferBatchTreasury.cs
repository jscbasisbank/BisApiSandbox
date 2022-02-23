namespace AuthApi.Web.NewFolder
{
    public class TransferBatchTreasury 
    {
        public string SenderAcc { get; set; }
        public string TreasuryCode { get; set; }
        public decimal Amount { get; set; }
        public string TaxPayerTaxCode { get; set; }
        public string TaxPayerName { get; set; }
        public string ExtraInfo { get; set; }
        public int? DocNum { get; set; }
        public int? ClientInternalID { get; set; }
    }
}
