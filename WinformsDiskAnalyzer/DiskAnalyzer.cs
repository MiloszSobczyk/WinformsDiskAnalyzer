using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using static System.Net.WebRequestMethods;

namespace WinformsDiskAnalyzer
{
    public partial class DiskAnalyzer : Form
    {
        public List<string> directories { get; set; }
        public long size = 0;
        public int filesCount = 0;
        public int subdirsCount = 0;
        string path = string.Empty;
        Dictionary<string, long> sizes = new Dictionary<string, long>();
        Dictionary<string, long> items = new Dictionary<string, long>();
        private Bitmap chartItems;
        private Bitmap chartSizes;

        public DiskAnalyzer()
        {
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
            itemsCounter.WorkerSupportsCancellation = true;
            itemsCounter.WorkerReportsProgress = true;
            fileMenu.ShortcutKeys |= Keys.Alt | Keys.I;
            fileMenu.ShortcutKeys |= Keys.Alt | Keys.A;
            directories = new List<string>() { "C:\\" };
            chartComboBox.SelectedItem = "Bar chart";
            chartItems = new Bitmap(itemsChartBox.Size.Width, itemsChartBox.Size.Height);
            itemsChartBox.Image = chartItems;
            chartSizes = new Bitmap(sizesChartBox.Size.Width, sizesChartBox.Size.Height);
            sizesChartBox.Image = chartSizes;

            InitializeTreeNodes();
        }

            private const int maxValue = 5;
        private (string, long)[] getChartData(Dictionary<string, long> data)
        {
            (string, long)[] result = new (string, long)[10];

            return result;
        }
        private void drawBarChart() { }
        public void InitializeTreeNodes()
        {
            folderTreeView.Nodes.Clear();
            for (int i = 0; i < directories.Count; ++i)
            {
                folderTreeView.Nodes.Add(directories[i]);
                loadSubdirectories(directories[i], folderTreeView.Nodes[i]);
            }
        }
        private void select_Click(object sender, EventArgs e)
        {
            this.directories.Clear();
            using (DialogWindow dialogWindow = new DialogWindow(this.directories))
            {
                dialogWindow.ShowDialog();
                InitializeTreeNodes();
            }
        }
        private void fileMenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void folderTreeView_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode node = this.folderTreeView.GetNodeAt(e.X, e.Y);

            if (node != null && node.Tag != null && 
                node.Tag.ToString() != this.toolTip1.GetToolTip(this.folderTreeView))
                    this.toolTip1.SetToolTip(this.folderTreeView, node.Tag.ToString());
            else this.toolTip1.SetToolTip(this.folderTreeView, "");
        }
        private void folderTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode mainNode = e.Node;
            if (mainNode == null) return;

            foreach (TreeNode node in mainNode.Nodes)
                loadSubdirectories($"{node.FullPath}", node);
        }
        private void folderTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (itemsCounter.IsBusy) itemsCounter.CancelAsync();

            folderProgressBar.Value = 0;
            if(new DirectoryInfo(e.Node.FullPath).Exists)
            {
                itemsCounter.RunWorkerAsync(new DirectoryInfo(e.Node.FullPath));
                return;
            }
            //else if(e.Node.FullPath.EndsWith("\\<Files>"))
            //{
            //    long size = 0;
            //    DateTime lastWriteTime = DateTime.MinValue;
            //    string[] files = Directory.GetFiles(e.Node.FullPath.Replace("\\<Files>", ""));
            //    foreach (string fileTemp in files)
            //    {
            //        FileInfo fileInfo = new FileInfo(fileTemp);
            //        size += fileInfo.Length;
            //        lastWriteTime = (lastWriteTime > fileInfo.LastWriteTime) ? lastWriteTime : fileInfo.LastWriteTime;
                    
            //    }
            //    fullPathLabel.Text = $"File path: {e.Node.FullPath.Replace("\\<Files>", "")}";
            //    sizeLabel.Text = $"Size: {formatSize(size)}";
            //    filesLabel.Text = $"Files: {files.Length}";
            //    itemsLabel.Text = $"Items: {files.Length}";
            //    subdirsLabel.Text = "Subdirs: 0";
            //    lastChangeLabel.Text = $"Last change: {lastWriteTime.ToString()}";
            //}

            FileInfo file = new FileInfo(e.Node.FullPath.Replace("\\<Files>", ""));
            clearLabels();
            fullPathLabel.Text = $"File path: {file.FullName}";
            sizeLabel.Text = $"Size: {formatSize(file.Length)}";
            filesLabel.Text = "Files: 1";
            itemsLabel.Text = "Items: 1";
            subdirsLabel.Text = "Subdirs: 1";
            lastChangeLabel.Text = $"Last change: {file.LastWriteTime.ToString()}";
        }
        private void fileMenuCancel_Click(object sender, EventArgs e)
        {
            if (itemsCounter.IsBusy) itemsCounter.CancelAsync();
        }
        private void itemsCounter_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DirectoryInfo? dir = e.Argument as DirectoryInfo;
            if(dir == null || !dir.Exists)
            {
                e.Cancel = true;
                return;
            }

            (string fullPath, long items, long files,
                long subdirs, long size, string lastWriteTime)
                result = ("", 0, 0, 0, 0, "None");
            result.fullPath = dir.FullName;
            result.lastWriteTime = dir.LastWriteTime.ToString();

            sizes = new Dictionary<string, long>();
            items = new Dictionary<string, long>();

            try
            {
                counterWork(dir, ref result, ref sizes, ref items);
            }
            catch(OperationCanceledException)
            {
                e.Cancel = true;
                return;
            }
            result.items = result.files + result.subdirs;
            itemsCounter.ReportProgress(100);
            e.Result = result;
        }
        private void itemsCounter_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled || e.Error != null)
            {
                folderProgressBar.Value = 0;
                clearLabels();
                return;
            }
            var result = ((string fullPath, long items, long files,
                long subdirs, long size, string lastWriteTime)) e.Result;

            fullPathLabel.Text = $"Full path: {result.fullPath}";
            subdirsLabel.Text = $"Subdirs: {result.subdirs.ToString()}";
            itemsLabel.Text = $"Items: {result.items.ToString()}";
            filesLabel.Text = $"Files: {result.files.ToString()}";
            sizeLabel.Text = $"Size: {formatSize(result.size)}";
            lastChangeLabel.Text = $"Last change: {result.lastWriteTime}";
            drawBarChart();
        }
        private void itemsCounter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            folderProgressBar.Value = e.ProgressPercentage;
        }
        public void counterWork(DirectoryInfo dir, ref (string fullPath, long items, long files,
            long subdirs, long size, string lastWriteTime) result, ref Dictionary<string, long> sizes, 
            ref Dictionary<string, long> items, bool firstLevel = true)
        {
            IEnumerable<FileInfo>? files = null;
            IEnumerable<DirectoryInfo>? dirs = null;
            try
            {
                dirs = dir.GetDirectories();
                files = dir.GetFiles();
            }
            catch { }

            if(files != null)
            {
                result.files += files.Count();
                foreach (var file in files)
                {
                    result.size += file.Length;
                    if (!items.ContainsKey(file.Extension)) items[file.Extension] = 0;
                    if (!sizes.ContainsKey(file.Extension)) sizes[file.Extension] = 0; 
                    items[file.Extension]++;
                    sizes[file.Extension] += file.Length;
                }
            }

            if(dirs != null)
            {
                int i = 0;
                result.subdirs += dirs.Count();
                foreach(var directory in dirs)
                {
                    if (itemsCounter.CancellationPending)
                        throw new OperationCanceledException();
                    counterWork(directory, ref result, ref sizes, ref items, false);

                    if(firstLevel)
                    {
                        int progress = (int)(1d / dirs.Count() * ++i * 100);
                        itemsCounter.ReportProgress(progress);
                    }
                }
            }
            
        }
        public static string formatSize(double size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (size >= 1024 && order < sizes.Length - 1)
            {
                size /= 1024;
                order++;
            }

            return $"{size:0.0} {sizes[order]}";
        }
        private void loadSubdirectories(string dir, TreeNode node)
        {
            try
            {
                string[] subdirs = Directory.GetDirectories(dir);
                string[] files = Directory.GetFiles(dir);
                foreach (string subdir in subdirs)
                {
                    DirectoryInfo subdirInfo = new DirectoryInfo(subdir);
                    TreeNode newNode = node.Nodes.Add(subdirInfo.Name);
                    newNode.StateImageIndex = 0;
                    newNode.Tag = subdirInfo.FullName;
                }
                if (files.Length >= 3)
                {
                    TreeNode filesNode = node.Nodes.Add("<Files>");
                    foreach (string file in files)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        TreeNode newNode = filesNode.Nodes.Add(fileInfo.Name);
                        newNode.StateImageIndex = 0;
                        newNode.Tag = fileInfo.FullName;
                    }

                }
                else
                    foreach (string file in files)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        TreeNode newNode = node.Nodes.Add(fileInfo.Name);
                        newNode.StateImageIndex = 0;
                        newNode.Tag = fileInfo.FullName;
                    }
            }
            catch { }
        }
        private void clearLabels()
        {
            fullPathLabel.Text = $"Full path: ";
            lastChangeLabel.Text = $"Last change: ";
            sizeLabel.Text = "Size: ";
            itemsLabel.Text = "Items: ";
            subdirsLabel.Text = "Subdirs: ";
            filesLabel.Text = "Files: ";
        }

        private void DiskAnalyzer_Resize(object sender, EventArgs e)
        {
            chartItems = new Bitmap(itemsChartBox.Size.Width, itemsChartBox.Size.Height);
            itemsChartBox.Image = chartItems;
            chartSizes = new Bitmap(sizesChartBox.Size.Width, sizesChartBox.Size.Height);
            sizesChartBox.Image = chartSizes;
            drawBarChart();
        }
    }
}