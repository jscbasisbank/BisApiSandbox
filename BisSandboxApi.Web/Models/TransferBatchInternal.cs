namespace BisSandboxApi.Web.Models;

public class TransferBatchInternal
{
    [DataMember]
    [Required]
    public string SenderAcc { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAcc { get; set; }

    [DataMember]
    [Required]
    [StringLength(3)]
    public string Ccy { get; set; }

    [DataMember]
    [Required]
    [Range(0, double.MaxValue)]
    public decimal Amount { get; set; }

    [DataMember]
    public string Descrip { get; set; }

    public int? DocNum { get; set; }

    public int? ClientInternalID { get; set; }
}