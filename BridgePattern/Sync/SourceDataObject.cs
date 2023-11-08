using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Sync
{
    public abstract class SourceDataObject
    {
        public abstract void LoadData();
        public abstract void UploadAllRecords();
        
    }
}
