using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Sync
{
    public interface ISourceDataConfig
    {
        string ConnectionString { get; set; }
        string TableName { get; set; }
    }
}
