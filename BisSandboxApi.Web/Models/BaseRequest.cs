using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BisSandboxApi.Web.Models;

public class BaseRequest
{
    [DataMember]
    [Required]
    public string TicketId { get; set; }
}