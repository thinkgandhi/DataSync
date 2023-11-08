namespace BridgePattern.Sync.Employee;

public class EmployeeBase
{
    private readonly SourceDataObject _sourceDataObject;

    public EmployeeBase(EmployeeData data)
    {
       _sourceDataObject = data;
    }

    public virtual void LoadData()
    {
        _sourceDataObject.LoadData();
    }

    public virtual void UploadAllRecords()
    {
        _sourceDataObject.UploadAllRecords();
    }
}