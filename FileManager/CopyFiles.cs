using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class CopyFiles
    {
        private void CopyFolder(DirectoryInfo from, string to)
        {
            try
            {
                Directory.SetCurrentDirectory(to);
                Directory.CreateDirectory(from.Name);
                Directory.SetCurrentDirectory(from.Name);

                ArrayList current = new ArrayList();
                current.AddRange(from.GetFiles());
                current.AddRange(from.GetDirectories());

                foreach (var i in current)
                {
                    if (i is FileInfo)
                    {
                        (i as FileInfo).CopyTo($"{Directory.GetCurrentDirectory()}\\{(i as FileInfo).Name}");
                    }
                    else
                    {
                        CopyFolder(i as DirectoryInfo, Directory.GetCurrentDirectory());
                        Directory.SetCurrentDirectory("..");
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
