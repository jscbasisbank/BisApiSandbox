namespace BisSandboxApi.Web.Models.Responses;

public class ApiResponse
{
    public int ErrorCode { get; set; }
    public string ErrorMsg { get; set; }
    public object Data { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
