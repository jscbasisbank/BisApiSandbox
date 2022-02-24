using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

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
