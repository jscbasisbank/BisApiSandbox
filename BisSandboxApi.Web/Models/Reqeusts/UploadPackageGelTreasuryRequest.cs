namespace BisSandboxApi.Web.Models.Requests;

public class UploadPackageTreasuryRequest : BaseRequest
{
    [DataMember]
    [Required]
    [StringLength(22)]
    public string SenderAcc { get; set; }

    [DataMember]
    [Required]
    public string PackageName { get; set; }

    [DataMember]
    [Required]
    public string Otp { get; set; }

    [DataMember]
    [Required]
    public List<UploadPackageGelItem> PackageItems { get; set; }
}

