using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BisSandboxApi.Web.Models.Requests;

public class AuthRequest
{
    [DataMember]
    [Required]
    public string LoginName { get; set; }

    [DataMember]
    [Required]
    public string Password { get; set; }

    [DataMember]
    public string Lang { get; set; }
}