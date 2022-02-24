namespace BisSandboxApi.Web.Models.Requests;

public class UploadSingleTransfersBatchRequest : BaseRequest
{
    [DataMember]
    [Required]
    public string Otp { get; set; }

    [DataMember]
    public List<TransferBatchInternal> InternalTransfers { get; set; }

    [DataMember]
    public List<TransferBatchGel> NationalCurrencyTransfers { get; set; }

    [DataMember]
    public List<TransferBatchVal> ForeignCurrencyTransfers { get; set; }

    [DataMember]
    public List<TransferBatchTreasury> TreasuryTransfers { get; set; }
}