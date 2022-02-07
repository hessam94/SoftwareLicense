using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseTester
{
    public class License
    {
        public int ManagedObjectCount;
        public int MonitorCount;
        public int FaultCount;
        public string LicenseName;
        public DateTime? ExpirationDate;
        public string UniqueId;
        public string LicenseSerialNumber;
        public int AggregateMonitorCount;

        public bool ExtraValidation()
        {
            if (this.UniqueId == HardwareInfo.GenerateUID())
            {
                return true;

            }
            else
                return false;
        }
    }

    public class LicenseMay2018  : ILicense
    {
        public LicenseMay2018()
        { }
        public byte[] _certPubicKeyData;

        public int ManagedObjectCount;
        public int MonitorCount;
        public int FaultCount;
        public string LicenseName;
        public DateTime? ExpirationDate;
        public string UniqueId;
        public string LicenseSerialNumber;
        public int AggregateMonitorCount;
        public bool ExtraValidation()
        {
            // test default
            return true;
        }
    }
    }
