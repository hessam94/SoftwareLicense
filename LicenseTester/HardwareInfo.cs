using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LicenseTester
{
   public  class HardwareInfo
    {
        public static string GenerateUID()
        {
            //Combine the IDs and get bytes
            //concat more items  such as diskId, ...
            string _id = string.Concat( GetMotherboardID(),GetProcessorId(),GetHardDiskId(), GetMACAddress());
            byte[] _byteIds = Encoding.UTF8.GetBytes(_id);

            //Use MD5 to get the fixed length checksum of the ID string
            MD5CryptoServiceProvider _md5 = new MD5CryptoServiceProvider();
            byte[] _checksum = _md5.ComputeHash(_byteIds);

            //Convert checksum into 4 ulong parts and use BASE36 to encode both
            string _part1Id = BASE36.Encode(BitConverter.ToUInt32(_checksum, 0));
            string _part2Id = BASE36.Encode(BitConverter.ToUInt32(_checksum, 4));
            string _part3Id = BASE36.Encode(BitConverter.ToUInt32(_checksum, 8));
            string _part4Id = BASE36.Encode(BitConverter.ToUInt32(_checksum, 12));

            //Concat these 4 part into one string
            return string.Format("{0}-{1}-{2}-{3}", _part1Id, _part2Id, _part3Id, _part4Id);
        }


        // due to security concerns this is not guranteed to be unique
        private static string GetProcessorId()
        {
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
                ManagementObjectCollection mosList = mos.Get();
                string id = "";
                foreach (ManagementObject mo in mosList)
                {
                    id = mo["ProcessorId"].ToString();
                    break;
                }

                return id;

            }
            catch
            {
                return "";
            }

        }

        private static string GetMotherboardID()
        {

            try
            {
                ManagementObjectSearcher _mbs = new ManagementObjectSearcher("Select SerialNumber From Win32_BaseBoard");
                ManagementObjectCollection _mbsList = _mbs.Get();
                string _id = string.Empty;
                foreach (ManagementObject _mo in _mbsList)
                {
                    _id = _mo["SerialNumber"].ToString();
                    break;
                }

                return _id;
            }
            catch
            {
                return string.Empty;
            }

        }

        private static string GetHardDiskId()
        {
            try
            {
                ManagementObjectSearcher mbs = new ManagementObjectSearcher("SELECT  SerialNumber FROM Win32_DiskDrive ");
                ManagementObjectCollection mbsList = mbs.Get();
                string id = string.Empty;
                foreach (ManagementObject item in mbsList)
                {
                    id = item["SerialNumber"].ToString();
                    break;
                }

                return id;
            }
            catch (Exception e)
            {
                return string.Empty;
            }

        }

        private static string GetMACAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress().ToString();
                }
            }
            return null;
        }
    }
}
