namespace BridgePattern.Sync.Employee;

public class EmployeeDestinationConfig : IDestinationConfig
{
    public string clientid { get; set; }
    public string clientsecret { get; set; }
    public string ApiEndpoint { get; set; }

    public EmployeeDestinationConfig()
    {
        
    }
}