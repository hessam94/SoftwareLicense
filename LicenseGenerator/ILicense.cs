using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGenerator
{
    interface ILicense
    {
        BaseLicense GenerateLicenseModel  (InputLicense form);
        string GenerateSignature (BaseLicense model);

    }

    public class BaseLicense
    {
        public BaseLicense()
        { }
    }
    public class InputLicense 
    {
        

        public int? ManagedObjectCount;
        public int? MonitorCount;
        public int? FaultCount;
        public string LicenseName;
        public DateTime? ExpirationDate;
        public string UniqueId;
        public string LicenseSerialNumber;
        public int? AggregateMonitorCount;
        public int? UserCount;
        public int? SiteChildCount;


    }
}
