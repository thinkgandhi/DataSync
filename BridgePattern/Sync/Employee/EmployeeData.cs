using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Sync.Employee
{
    public record Employee(string empcode, string name, string mobile);
    public class EmployeeData : SourceDataObject
    {
        private IList<Employee> _employees = new List<Employee>();
        private readonly ISourceDataConfig _sourceDataConfig;
        private readonly IDestinationConfig _destinationDataConfig;

        public EmployeeData(ISourceDataConfig sourceDataConfig, IDestinationConfig _destinationDataConfig)
        {
            _sourceDataConfig = sourceDataConfig;
            _destinationDataConfig = _destinationDataConfig;
        }

        public override void LoadData()
        {
            Console.WriteLine("Loading Data");
        }

        public override void UploadAllRecords()
        {
            Console.WriteLine("Uploading Data");
        }

        
    }
}
