using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace My_info
{
   public abstract class Info_PC
    {
        public List<string> temp;
        public abstract string[] GetInfo();
    }
    public class Video_card : Info_PC
    {
        public override string[] GetInfo()
        {
           temp = new List<string>();
            using (ManagementObjectSearcher searcher11 =
              new ManagementObjectSearcher("root\\CIMV2",
              "SELECT * FROM Win32_VideoController"))
            {

                int i = 1;
                foreach (ManagementObject queryObj in searcher11.Get())
                {
                    temp.Add(i.ToString());
                    temp.Add("AdapterRAM: " + queryObj["AdapterRAM"].ToString());
                    temp.Add("Caption: " + queryObj["Caption"].ToString());
                    temp.Add("Description: " + queryObj["Description"].ToString());
                    temp.Add("VideoProcessor: " + queryObj["VideoProcessor"].ToString());
                    temp.Add("\n");
                    i++;
                }
            }
            return temp.ToArray();
        }
    }
    public class CPU : Info_PC
    {
        public override string[] GetInfo()
        {
             temp = new List<string>();
            using (ManagementObjectSearcher searcher8 =
             new ManagementObjectSearcher("root\\CIMV2",
             "SELECT * FROM Win32_Processor"))
            {
                int i = 1;
                foreach (ManagementObject queryObj in searcher8.Get())
                {
                    temp.Add(i.ToString());
                    temp.Add("Name: " + queryObj["Name"].ToString());
                    temp.Add("NumberOfCores: " + queryObj["NumberOfCores"].ToString());
                    temp.Add("ProcessorId: " + queryObj["ProcessorId"].ToString());
                    temp.Add("\n");
                    i++;
                }
            }
            return temp.ToArray();
        }

    }
    public class HDD : Info_PC
    {
     
        public override string[] GetInfo()
        {
            temp = new List<string>();
            using (ManagementObjectSearcher searcher =
              new ManagementObjectSearcher("root\\CIMV2",
              "SELECT * FROM Win32_Volume"))
            {
                int i = 1;
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    temp.Add(i.ToString());
                    temp.Add("Capacity: " + queryObj["Capacity"]);
                    temp.Add("Caption: " + queryObj["Caption"]);
                    temp.Add("DriveLetter: " + queryObj["DriveLetter"]);
                    temp.Add("DriveType: " + queryObj["DriveType"]);
                    temp.Add("FileSystem: " + queryObj["FileSystem"]);
                    temp.Add("FreeSpace: " + queryObj["FreeSpace"]);
                    temp.Add("\n");
                    i++;
                }
            }
            return temp.ToArray();
        }
    }
}
