using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private Drives Drives;
        private GetDirectories Directories;

        private void ListViewSettings(ListView listView)
        {
            // Set the view to show details.
            listView.View = View.Details;
            // Allow the user to edit item text.
            listView.LabelEdit = false;
            // Allow the user to rearrange columns.
            listView.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView.FullRowSelect = true;
            // Display grid lines.
            listView.GridLines = true;

            listView.Columns.Add("Nazwa");
            listView.Columns.Add("Data utworzenia");
            listView.Columns.Add("Typ");
        }

        

        public Form1()
        {
            InitializeComponent();
            ListViewSettings(listView1);
            
            Drives = new Drives();
            Directories = new GetDirectories();

            // dodawanie dysków do listy wyboru
            driveList1.Items.AddRange(Drives.Disks.ToArray());

        }

        private void driveList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Path1.Clear();
            Path1.Text = driveList1.SelectedItem.ToString();
            
            Directories.ShowFilesFromDirectory(listView1, Path1.Text);
        }

        private void Path1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Directories.ShowFilesFromDirectory(listView1, Path1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string type = listView1.SelectedItems[0].SubItems[2].Text;
                string newPath = listView1.SelectedItems[0].SubItems[0].Text;
                
                if(type == "<dir>")
                {
                    if (Path1.Text.Last()=='\\')
                    {
                        Path1.Text = Path1.Text + listView1.SelectedItems[0].Text;
                    }
                    else
                    {
                        Path1.Text = Path1.Text + "\\" + listView1.SelectedItems[0].Text;
                    }
                        
                    
                    Directories.ShowFilesFromDirectory(listView1, Path1.Text);
                }
                else if(type == "...")
                {
                    Path1.Text = listView1.SelectedItems[0].Text;
                    Directories.ShowFilesFromDirectory(listView1, Path1.Text);
                }
                else
                {
                    System.Diagnostics.Process.Start(Path1.Text + "\\" + listView1.SelectedItems[0].Text);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Błąd");
            }
            
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
