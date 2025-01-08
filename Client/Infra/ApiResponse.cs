namespace Client.Infra;

public class ApiResponse
{
    public DataModel Data { get; set; }
    public string Message { get; set; }
    public int Status { get; set; }
}