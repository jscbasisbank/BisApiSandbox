namespace BisSandboxApi.Web.Models.Requests;

public class ChangePasswordRequest : BaseRequest
{
    [DataMember]
    [Required]
    public string OldPassword { get; set; }

    [DataMember]
    [Required]
    public string NewPassword { get; set; }

    [DataMember]
    [Required]
    public string Otp { get; set; }
}
