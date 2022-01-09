using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public class GetDirectories
    {
        public void ShowFilesFromDirectory(ListView listView, string path)
        {
            listView.Items.Clear();
            string[] goBack = new string[3];
            goBack[0] = path.Substring(0, path.LastIndexOf("\\")) + "\\";
            goBack[1] = "";
            goBack[2] = "...";
            ListViewItem goBackDir = new ListViewItem(goBack);
            listView.Items.Add(goBackDir);

            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                DirectoryInfo flag = new DirectoryInfo(dir);
                if (flag.Attributes == FileAttributes.Directory || flag.Attributes == (FileAttributes.ReadOnly | FileAttributes.Directory))
                {
                    string[] arr = new string[3];
                    arr[0] = Path.GetFileNameWithoutExtension(dir); ;
                    arr[1] = Directory.GetCreationTime(dir).ToString();
                    arr[2] = "<dir>";
                    ListViewItem item = new ListViewItem(arr);

                    listView.Items.Add(item);
                }
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                DirectoryInfo flag = new DirectoryInfo(file);
                if (flag.Attributes == FileAttributes.Archive)
                {
                    string[] arr = new string[3];
                    arr[0] = Path.GetFileName(file);
                    arr[1] = Directory.GetCreationTime(file).ToString();
                    arr[2] = flag.Extension;
                    ListViewItem item = new ListViewItem(arr);

                    listView.Items.Add(item);
                }

            }


        }
    }
}
