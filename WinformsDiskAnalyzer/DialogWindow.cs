using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsDiskAnalyzer
{
    public partial class DialogWindow : Form
    {
        List<string> directories = new List<string>();
        public DialogWindow(List<string> directories)
        {
            InitializeComponent();
            Initialize();
            this.directories = directories;
        }
        public void Initialize()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            int i = 0;
            foreach(var drive in drives)
            {
                string name = drive.Name;
                long total = drive.TotalSize;
                double free = drive.TotalFreeSpace;

                ListViewItem newItem = new ListViewItem(new string[]
                {
                    name,
                    $"{DiskAnalyzer.formatSize(total)}",
                    $"{DiskAnalyzer.formatSize(free)}",
                    $"{((total - free) / total * 100):0.00}%"
                });
                diskView.Items.Add(newItem);

                ProgressBar bar = new ProgressBar();
                bar.Visible = true;
                bar.Location = new Point(diskView.Margin.Left + diskView.Location.X + 3,
                    diskView.Margin.Top + diskView.Location.Y + 3 + 24);
                bar.Location = new Point(bar.Location.X + 295, bar.Location.Y + 20 * i++);
                bar.Value = (int)((total - free) / total * 100);
                bar.Size = new Size(diskView.Columns[4].Width, 20);
                this.Controls.Add(bar);
                bar.BringToFront();
            }
            folderTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            folderTextBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
        }
        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    folderTextBox.Text = fbd.SelectedPath;
            }
        }

        private void dialogCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dialogOkButton_Click(object sender, EventArgs e)
        {
            if (individualDrivesButton.Checked)
                foreach (ListViewItem item in diskView.SelectedItems)
                    directories.Add(item.SubItems[0].Text);
            else if (allDrivesButton.Checked)
                foreach (ListViewItem item in diskView.Items)
                    directories.Add(item.SubItems[0].Text);
            else if (folderButton.Checked)
                directories.Add($"{folderTextBox.Text}\\");

            Close();
        }
        private void folderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists($"{folderTextBox.Text}\\"))
            {
                folderTextBox.ForeColor = Color.Black;
                dialogOkButton.Enabled = true;
            }
            else
            {
                folderTextBox.ForeColor = Color.Red;
                dialogOkButton.Enabled = false;
            }
        }

    }
}
