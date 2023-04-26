namespace WinformsDiskAnalyzer
{
    partial class DiskAnalyzer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.windowMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectButton = new System.Windows.Forms.Button();
            this.folderTreeView = new System.Windows.Forms.TreeView();
            this.controlTab = new System.Windows.Forms.TabControl();
            this.detailsPage = new System.Windows.Forms.TabPage();
            this.fullPathLabel = new System.Windows.Forms.Label();
            this.lastChangeLabel = new System.Windows.Forms.Label();
            this.subdirsLabel = new System.Windows.Forms.Label();
            this.filesLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.chartsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.itemsChartBox = new System.Windows.Forms.PictureBox();
            this.sizesChartBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.itemsCounter = new System.ComponentModel.BackgroundWorker();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.folderProgressBar = new System.Windows.Forms.ProgressBar();
            this.resizeStrip = new System.Windows.Forms.StatusStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.windowMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.controlTab.SuspendLayout();
            this.detailsPage.SuspendLayout();
            this.chartsPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsChartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesChartBox)).BeginInit();
            this.mainTableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowMenu
            // 
            this.windowMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.windowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.windowMenu.Location = new System.Drawing.Point(0, 0);
            this.windowMenu.Name = "windowMenu";
            this.windowMenu.Size = new System.Drawing.Size(800, 28);
            this.windowMenu.TabIndex = 0;
            this.windowMenu.Text = "WindowMenu";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuSelect,
            this.fileMenuCancel,
            this.fileMenuExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShowShortcutKeys = false;
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            // 
            // fileMenuSelect
            // 
            this.fileMenuSelect.Name = "fileMenuSelect";
            this.fileMenuSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileMenuSelect.Size = new System.Drawing.Size(186, 26);
            this.fileMenuSelect.Text = "Select";
            this.fileMenuSelect.Click += new System.EventHandler(this.select_Click);
            // 
            // fileMenuCancel
            // 
            this.fileMenuCancel.Name = "fileMenuCancel";
            this.fileMenuCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.fileMenuCancel.Size = new System.Drawing.Size(186, 26);
            this.fileMenuCancel.Text = "Cancel";
            this.fileMenuCancel.Click += new System.EventHandler(this.fileMenuCancel_Click);
            // 
            // fileMenuExit
            // 
            this.fileMenuExit.Name = "fileMenuExit";
            this.fileMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fileMenuExit.Size = new System.Drawing.Size(186, 26);
            this.fileMenuExit.Text = "Exit";
            this.fileMenuExit.Click += new System.EventHandler(this.fileMenuExit_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuAbout});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpMenu.Size = new System.Drawing.Size(55, 24);
            this.helpMenu.Text = "Help";
            // 
            // helpMenuAbout
            // 
            this.helpMenuAbout.Name = "helpMenuAbout";
            this.helpMenuAbout.Size = new System.Drawing.Size(133, 26);
            this.helpMenuAbout.Text = "About";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.controlTab);
            this.splitContainer.Size = new System.Drawing.Size(794, 405);
            this.splitContainer.SplitterDistance = 347;
            this.splitContainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.selectButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderTreeView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectButton.Location = new System.Drawing.Point(3, 3);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(341, 29);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.select_Click);
            // 
            // folderTreeView
            // 
            this.folderTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTreeView.Location = new System.Drawing.Point(3, 38);
            this.folderTreeView.Name = "folderTreeView";
            this.folderTreeView.Size = new System.Drawing.Size(341, 364);
            this.folderTreeView.TabIndex = 1;
            this.folderTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.folderTreeView_BeforeExpand);
            this.folderTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.folderTreeView_AfterSelect);
            this.folderTreeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.folderTreeView_MouseMove);
            // 
            // controlTab
            // 
            this.controlTab.Controls.Add(this.detailsPage);
            this.controlTab.Controls.Add(this.chartsPage);
            this.controlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlTab.Location = new System.Drawing.Point(0, 0);
            this.controlTab.Name = "controlTab";
            this.controlTab.SelectedIndex = 0;
            this.controlTab.Size = new System.Drawing.Size(443, 405);
            this.controlTab.TabIndex = 0;
            // 
            // detailsPage
            // 
            this.detailsPage.Controls.Add(this.fullPathLabel);
            this.detailsPage.Controls.Add(this.lastChangeLabel);
            this.detailsPage.Controls.Add(this.subdirsLabel);
            this.detailsPage.Controls.Add(this.filesLabel);
            this.detailsPage.Controls.Add(this.itemsLabel);
            this.detailsPage.Controls.Add(this.sizeLabel);
            this.detailsPage.Location = new System.Drawing.Point(4, 29);
            this.detailsPage.Name = "detailsPage";
            this.detailsPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailsPage.Size = new System.Drawing.Size(435, 372);
            this.detailsPage.TabIndex = 0;
            this.detailsPage.Text = "Details";
            this.detailsPage.UseVisualStyleBackColor = true;
            // 
            // fullPathLabel
            // 
            this.fullPathLabel.AutoSize = true;
            this.fullPathLabel.Location = new System.Drawing.Point(6, 9);
            this.fullPathLabel.Name = "fullPathLabel";
            this.fullPathLabel.Size = new System.Drawing.Size(73, 20);
            this.fullPathLabel.TabIndex = 6;
            this.fullPathLabel.Text = "Full path: ";
            // 
            // lastChangeLabel
            // 
            this.lastChangeLabel.AutoSize = true;
            this.lastChangeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastChangeLabel.Location = new System.Drawing.Point(6, 109);
            this.lastChangeLabel.Name = "lastChangeLabel";
            this.lastChangeLabel.Size = new System.Drawing.Size(94, 20);
            this.lastChangeLabel.TabIndex = 5;
            this.lastChangeLabel.Text = "Last change: ";
            // 
            // subdirsLabel
            // 
            this.subdirsLabel.AutoSize = true;
            this.subdirsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subdirsLabel.Location = new System.Drawing.Point(6, 89);
            this.subdirsLabel.Name = "subdirsLabel";
            this.subdirsLabel.Size = new System.Drawing.Size(65, 20);
            this.subdirsLabel.TabIndex = 4;
            this.subdirsLabel.Text = "Subdirs: ";
            // 
            // filesLabel
            // 
            this.filesLabel.AutoSize = true;
            this.filesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filesLabel.Location = new System.Drawing.Point(6, 69);
            this.filesLabel.Name = "filesLabel";
            this.filesLabel.Size = new System.Drawing.Size(45, 20);
            this.filesLabel.TabIndex = 3;
            this.filesLabel.Text = "Files: ";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemsLabel.Location = new System.Drawing.Point(6, 49);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(52, 20);
            this.itemsLabel.TabIndex = 2;
            this.itemsLabel.Text = "Items: ";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeLabel.Location = new System.Drawing.Point(6, 29);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(39, 20);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Size:";
            // 
            // chartsPage
            // 
            this.chartsPage.Controls.Add(this.tableLayoutPanel3);
            this.chartsPage.Location = new System.Drawing.Point(4, 29);
            this.chartsPage.Name = "chartsPage";
            this.chartsPage.Padding = new System.Windows.Forms.Padding(3);
            this.chartsPage.Size = new System.Drawing.Size(435, 372);
            this.chartsPage.TabIndex = 1;
            this.chartsPage.Text = "Charts";
            this.chartsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(429, 366);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46355F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.53645F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.chartComboBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(423, 34);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartComboBox
            // 
            this.chartComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartComboBox.FormattingEnabled = true;
            this.chartComboBox.Items.AddRange(new object[] {
            "Bar chart",
            "Log bar chart",
            "Pie chart"});
            this.chartComboBox.Location = new System.Drawing.Point(140, 3);
            this.chartComboBox.Name = "chartComboBox";
            this.chartComboBox.Size = new System.Drawing.Size(280, 28);
            this.chartComboBox.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.itemsChartBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.sizesChartBox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(423, 320);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // itemsChartBox
            // 
            this.itemsChartBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsChartBox.Location = new System.Drawing.Point(3, 3);
            this.itemsChartBox.Name = "itemsChartBox";
            this.itemsChartBox.Size = new System.Drawing.Size(205, 314);
            this.itemsChartBox.TabIndex = 0;
            this.itemsChartBox.TabStop = false;
            // 
            // sizesChartBox
            // 
            this.sizesChartBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizesChartBox.Location = new System.Drawing.Point(214, 3);
            this.sizesChartBox.Name = "sizesChartBox";
            this.sizesChartBox.Size = new System.Drawing.Size(206, 314);
            this.sizesChartBox.TabIndex = 1;
            this.sizesChartBox.TabStop = false;
            // 
            // itemsCounter
            // 
            this.itemsCounter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.itemsCounter_DoWork);
            this.itemsCounter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.itemsCounter_ProgressChanged);
            this.itemsCounter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.itemsCounter_RunWorkerCompleted);
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.splitContainer, 0, 0);
            this.mainTableLayout.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 28);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayout.Size = new System.Drawing.Size(800, 451);
            this.mainTableLayout.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.folderProgressBar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.resizeStrip, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 414);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // folderProgressBar
            // 
            this.folderProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderProgressBar.Location = new System.Drawing.Point(3, 3);
            this.folderProgressBar.Name = "folderProgressBar";
            this.folderProgressBar.Size = new System.Drawing.Size(194, 28);
            this.folderProgressBar.TabIndex = 0;
            // 
            // resizeStrip
            // 
            this.resizeStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resizeStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.resizeStrip.Location = new System.Drawing.Point(200, 0);
            this.resizeStrip.Name = "resizeStrip";
            this.resizeStrip.Size = new System.Drawing.Size(594, 34);
            this.resizeStrip.TabIndex = 1;
            this.resizeStrip.Text = "statusStrip1";
            // 
            // DiskAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.windowMenu);
            this.MainMenuStrip = this.windowMenu;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "DiskAnalyzer";
            this.Text = "Disk Space Analyzer";
            this.Resize += new System.EventHandler(this.DiskAnalyzer_Resize);
            this.windowMenu.ResumeLayout(false);
            this.windowMenu.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.controlTab.ResumeLayout(false);
            this.detailsPage.ResumeLayout(false);
            this.detailsPage.PerformLayout();
            this.chartsPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsChartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesChartBox)).EndInit();
            this.mainTableLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip windowMenu;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem fileMenuSelect;
        private ToolStripMenuItem fileMenuCancel;
        private ToolStripMenuItem fileMenuExit;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem helpMenuAbout;
        private SplitContainer splitContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Button selectButton;
        private TreeView folderTreeView;
        private TabControl controlTab;
        private TabPage detailsPage;
        private TabPage chartsPage;
        private ToolTip toolTip1;
        private Label lastChangeLabel;
        private Label subdirsLabel;
        private Label filesLabel;
        private Label itemsLabel;
        private System.ComponentModel.BackgroundWorker itemsCounter;
        private TableLayoutPanel mainTableLayout;
        private TableLayoutPanel tableLayoutPanel2;
        private ProgressBar folderProgressBar;
        private StatusStrip resizeStrip;
        private Label sizeLabel;
        private Label fullPathLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private ComboBox chartComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox itemsChartBox;
        private PictureBox sizesChartBox;
    }
}