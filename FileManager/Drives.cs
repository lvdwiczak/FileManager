using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Drives
    {
        public List<DriveInfo> Disks { get; set; }

        public Drives()
        {
            Disks = new List<DriveInfo>();
            SetDrives();
        }

        public void SetDrives()
        {
            Disks.Clear();
            foreach(var di in DriveInfo.GetDrives())
            {
                if (di.IsReady)
                {
                    Disks.Add(di);
                }
            }
        }
    }
}
