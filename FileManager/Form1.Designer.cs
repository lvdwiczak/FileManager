namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Path1 = new System.Windows.Forms.TextBox();
            this.driveList1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Path1
            // 
            this.Path1.Location = new System.Drawing.Point(52, 12);
            this.Path1.Name = "Path1";
            this.Path1.Size = new System.Drawing.Size(238, 20);
            this.Path1.TabIndex = 0;
            this.Path1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Path1_KeyDown);
            // 
            // driveList1
            // 
            this.driveList1.FormattingEnabled = true;
            this.driveList1.Location = new System.Drawing.Point(12, 12);
            this.driveList1.Name = "driveList1";
            this.driveList1.Size = new System.Drawing.Size(34, 21);
            this.driveList1.TabIndex = 13;
            this.driveList1.SelectedIndexChanged += new System.EventHandler(this.driveList1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 499);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 711);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.driveList1);
            this.Controls.Add(this.Path1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path1;
        private System.Windows.Forms.ComboBox driveList1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}

