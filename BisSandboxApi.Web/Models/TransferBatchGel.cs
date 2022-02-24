namespace BisSandboxApi.Web.Models;

public class TransferBatchGel
{
    [DataMember]
    [Required]
    public string SenderAcc { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAcc { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAccName { get; set; }

    [DataMember]
    [Required]
    public string ReceiverBankCode { get; set; }

    [DataMember]
    [Required]
    [Range(0, double.MaxValue)]
    public decimal Amount { get; set; }

    [DataMember]
    public string Descrip { get; set; }

    [DataMember]
    [StringLength(11)]
    public string TaxPayerTaxCode { get; set; }

    [DataMember]
    public string TaxPayerName { get; set; }

    public int? DocNum { get; set; }

    public int? ClientInternalID { get; set; }
}