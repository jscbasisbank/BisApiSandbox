namespace BisSandboxApi.Web.Models.Requests;

public class GetReportRequest : BaseRequest
{
    [DataMember]
    [Required]
    public string Account { get; set; }

    [DataMember]
    [Required]
    [StringLength(3)]
    public string Ccy { get; set; }

    [DataMember]
    public DateTime? StartDate { get; set; }

    [DataMember]
    public DateTime? EndDate { get; set; }

    [DataMember]
    public int PageNo { get; set; }
}