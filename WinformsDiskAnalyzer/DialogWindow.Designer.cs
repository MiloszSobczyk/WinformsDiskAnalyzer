namespace WinformsDiskAnalyzer
{
    partial class DialogWindow
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
            this.allDrivesButton = new System.Windows.Forms.RadioButton();
            this.individualDrivesButton = new System.Windows.Forms.RadioButton();
            this.diskView = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.totalColumn = new System.Windows.Forms.ColumnHeader();
            this.freeColumn = new System.Windows.Forms.ColumnHeader();
            this.usedTotalColumn = new System.Windows.Forms.ColumnHeader();
            this.usedTotalBarColumn = new System.Windows.Forms.ColumnHeader();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.dialogCancelButton = new System.Windows.Forms.Button();
            this.dialogOkButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // allDrivesButton
            // 
            this.allDrivesButton.AutoSize = true;
            this.allDrivesButton.Location = new System.Drawing.Point(12, 12);
            this.allDrivesButton.Name = "allDrivesButton";
            this.allDrivesButton.Size = new System.Drawing.Size(132, 24);
            this.allDrivesButton.TabIndex = 0;
            this.allDrivesButton.TabStop = true;
            this.allDrivesButton.Text = "All Local Drives";
            this.allDrivesButton.UseVisualStyleBackColor = true;
            // 
            // individualDrivesButton
            // 
            this.individualDrivesButton.AutoSize = true;
            this.individualDrivesButton.Location = new System.Drawing.Point(12, 42);
            this.individualDrivesButton.Name = "individualDrivesButton";
            this.individualDrivesButton.Size = new System.Drawing.Size(140, 24);
            this.individualDrivesButton.TabIndex = 1;
            this.individualDrivesButton.TabStop = true;
            this.individualDrivesButton.Text = "Individual Drives";
            this.individualDrivesButton.UseVisualStyleBackColor = true;
            // 
            // diskView
            // 
            this.diskView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diskView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.totalColumn,
            this.freeColumn,
            this.usedTotalColumn,
            this.usedTotalBarColumn});
            this.diskView.FullRowSelect = true;
            this.diskView.Location = new System.Drawing.Point(12, 72);
            this.diskView.Name = "diskView";
            this.diskView.Size = new System.Drawing.Size(558, 161);
            this.diskView.TabIndex = 2;
            this.diskView.UseCompatibleStateImageBehavior = false;
            this.diskView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // totalColumn
            // 
            this.totalColumn.Text = "Total";
            this.totalColumn.Width = 75;
            // 
            // freeColumn
            // 
            this.freeColumn.Text = "Free";
            this.freeColumn.Width = 75;
            // 
            // usedTotalColumn
            // 
            this.usedTotalColumn.Text = "Used/Total";
            this.usedTotalColumn.Width = 90;
            // 
            // usedTotalBarColumn
            // 
            this.usedTotalBarColumn.Text = "Used/Total";
            this.usedTotalBarColumn.Width = 90;
            // 
            // folderTextBox
            // 
            this.folderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextBox.Location = new System.Drawing.Point(12, 272);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(458, 27);
            this.folderTextBox.TabIndex = 3;
            this.folderTextBox.TextChanged += new System.EventHandler(this.folderTextBox_TextChanged);
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFolderButton.Location = new System.Drawing.Point(476, 272);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(94, 27);
            this.chooseFolderButton.TabIndex = 4;
            this.chooseFolderButton.Text = "...";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // dialogCancelButton
            // 
            this.dialogCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogCancelButton.Location = new System.Drawing.Point(476, 305);
            this.dialogCancelButton.Name = "dialogCancelButton";
            this.dialogCancelButton.Size = new System.Drawing.Size(94, 27);
            this.dialogCancelButton.TabIndex = 5;
            this.dialogCancelButton.Text = "Cancel";
            this.dialogCancelButton.UseVisualStyleBackColor = true;
            this.dialogCancelButton.Click += new System.EventHandler(this.dialogCancelButton_Click);
            // 
            // dialogOkButton
            // 
            this.dialogOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogOkButton.Location = new System.Drawing.Point(376, 305);
            this.dialogOkButton.Name = "dialogOkButton";
            this.dialogOkButton.Size = new System.Drawing.Size(94, 27);
            this.dialogOkButton.TabIndex = 6;
            this.dialogOkButton.Text = "OK";
            this.dialogOkButton.UseVisualStyleBackColor = true;
            this.dialogOkButton.Click += new System.EventHandler(this.dialogOkButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.folderButton.AutoSize = true;
            this.folderButton.Location = new System.Drawing.Point(12, 242);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(86, 24);
            this.folderButton.TabIndex = 7;
            this.folderButton.TabStop = true;
            this.folderButton.Text = "A Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 376);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.dialogOkButton);
            this.Controls.Add(this.dialogCancelButton);
            this.Controls.Add(this.chooseFolderButton);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.diskView);
            this.Controls.Add(this.individualDrivesButton);
            this.Controls.Add(this.allDrivesButton);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "DialogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Disk or Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton allDrivesButton;
        private RadioButton individualDrivesButton;
        private ListView diskView;
        private TextBox folderTextBox;
        private Button chooseFolderButton;
        private Button dialogCancelButton;
        private Button dialogOkButton;
        private RadioButton folderButton;
        private ColumnHeader nameColumn;
        private ColumnHeader totalColumn;
        private ColumnHeader freeColumn;
        private ColumnHeader usedTotalBarColumn;
        private ColumnHeader usedTotalColumn;
    }
}