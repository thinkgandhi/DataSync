namespace BridgePattern.Sync.Employee;

public class EmployeeSourceDataConfig : ISourceDataConfig
{
    public string ConnectionString { get; set; }
    public string TableName { get; set; }
}