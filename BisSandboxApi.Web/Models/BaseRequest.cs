namespace BisSandboxApi.Web.Models;

public class BaseRequest
{
    [DataMember]
    [Required]
    public string TicketId { get; set; }
}