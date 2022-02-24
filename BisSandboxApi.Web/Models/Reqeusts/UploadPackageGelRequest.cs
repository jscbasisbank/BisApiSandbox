namespace BisSandboxApi.Web.Models.Requests;

public class UploadPackageGelRequest : BaseRequest
{
    [DataMember]
    [Required]
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

