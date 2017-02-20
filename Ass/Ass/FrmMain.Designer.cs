namespace Ass
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbrSelecrFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cbrSelectFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cbrStart = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.cboEncoding = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeOffset = new System.Windows.Forms.TextBox();
            this.txtTimeArea = new System.Windows.Forms.TextBox();
            this.chkTimeArea = new System.Windows.Forms.CheckBox();
            this.btnClearFile = new System.Windows.Forms.Button();
            this.lblReserve = new System.Windows.Forms.LinkLabel();
            this.lblAll = new System.Windows.Forms.LinkLabel();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbrRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlRules.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbrSelecrFile,
            this.cbrSelectFolder,
            this.cbrStart});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cbrSelecrFile
            // 
            this.cbrSelecrFile.Name = "cbrSelecrFile";
            this.cbrSelecrFile.Size = new System.Drawing.Size(68, 21);
            this.cbrSelecrFile.Text = "添加文件";
            this.cbrSelecrFile.Click += new System.EventHandler(this.cbrSelectFile_Click);
            // 
            // cbrSelectFolder
            // 
            this.cbrSelectFolder.Name = "cbrSelectFolder";
            this.cbrSelectFolder.Size = new System.Drawing.Size(68, 21);
            this.cbrSelectFolder.Text = "添加目录";
            this.cbrSelectFolder.Click += new System.EventHandler(this.cbrSelectFolder_Click);
            // 
            // cbrStart
            // 
            this.cbrStart.Name = "cbrStart";
            this.cbrStart.Size = new System.Drawing.Size(44, 21);
            this.cbrStart.Text = "开始";
            this.cbrStart.Click += new System.EventHandler(this.cbrStart_Click);
            // 
            // pnlRules
            // 
            this.pnlRules.AutoSize = true;
            this.pnlRules.Controls.Add(this.cboEncoding);
            this.pnlRules.Controls.Add(this.label3);
            this.pnlRules.Controls.Add(this.label2);
            this.pnlRules.Controls.Add(this.label1);
            this.pnlRules.Controls.Add(this.txtTimeOffset);
            this.pnlRules.Controls.Add(this.txtTimeArea);
            this.pnlRules.Controls.Add(this.chkTimeArea);
            this.pnlRules.Controls.Add(this.btnClearFile);
            this.pnlRules.Controls.Add(this.lblReserve);
            this.pnlRules.Controls.Add(this.lblAll);
            this.pnlRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRules.Location = new System.Drawing.Point(0, 25);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(666, 56);
            this.pnlRules.TabIndex = 1;
            // 
            // cboEncoding
            // 
            this.cboEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncoding.FormattingEnabled = true;
            this.cboEncoding.Items.AddRange(new object[] {
            "Default",
            "Unicode",
            "UTF8"});
            this.cboEncoding.Location = new System.Drawing.Point(518, 3);
            this.cboEncoding.Name = "cboEncoding";
            this.cboEncoding.Size = new System.Drawing.Size(71, 20);
            this.cboEncoding.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "编码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "时间轴调整";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "毫秒";
            // 
            // txtTimeOffset
            // 
            this.txtTimeOffset.Location = new System.Drawing.Point(91, 3);
            this.txtTimeOffset.Name = "txtTimeOffset";
            this.txtTimeOffset.Size = new System.Drawing.Size(75, 21);
            this.txtTimeOffset.TabIndex = 23;
            // 
            // txtTimeArea
            // 
            this.txtTimeArea.Location = new System.Drawing.Point(336, 3);
            this.txtTimeArea.Name = "txtTimeArea";
            this.txtTimeArea.Size = new System.Drawing.Size(110, 21);
            this.txtTimeArea.TabIndex = 21;
            // 
            // chkTimeArea
            // 
            this.chkTimeArea.AutoSize = true;
            this.chkTimeArea.Location = new System.Drawing.Point(246, 5);
            this.chkTimeArea.Name = "chkTimeArea";
            this.chkTimeArea.Size = new System.Drawing.Size(84, 16);
            this.chkTimeArea.TabIndex = 20;
            this.chkTimeArea.Text = "时间轴区间";
            this.chkTimeArea.UseVisualStyleBackColor = true;
            // 
            // btnClearFile
            // 
            this.btnClearFile.Location = new System.Drawing.Point(91, 30);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(75, 23);
            this.btnClearFile.TabIndex = 19;
            this.btnClearFile.Text = "清空列表";
            this.btnClearFile.UseVisualStyleBackColor = true;
            this.btnClearFile.Click += new System.EventHandler(this.cbrClearFile_Click);
            // 
            // lblReserve
            // 
            this.lblReserve.AutoSize = true;
            this.lblReserve.LinkColor = System.Drawing.Color.Black;
            this.lblReserve.Location = new System.Drawing.Point(46, 35);
            this.lblReserve.Name = "lblReserve";
            this.lblReserve.Size = new System.Drawing.Size(29, 12);
            this.lblReserve.TabIndex = 18;
            this.lblReserve.TabStop = true;
            this.lblReserve.Text = "反选";
            this.lblReserve.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReserve_LinkClicked);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.LinkColor = System.Drawing.Color.Black;
            this.lblAll.Location = new System.Drawing.Point(11, 35);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(29, 12);
            this.lblAll.TabIndex = 17;
            this.lblAll.TabStop = true;
            this.lblAll.Text = "全选";
            this.lblAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAll_LinkClicked);
            // 
            // lvwFiles
            // 
            this.lvwFiles.AllowDrop = true;
            this.lvwFiles.CheckBoxes = true;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.GridLines = true;
            this.lvwFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFiles.Location = new System.Drawing.Point(0, 81);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(666, 421);
            this.lvwFiles.SmallImageList = this.imageList1;
            this.lvwFiles.TabIndex = 2;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragDrop);
            this.lvwFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 550;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "状态";
            this.columnHeader2.Width = 86;
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "ass字幕文件(*.ass)|*.ass";
            this.fileDialog.Multiselect = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "时间轴区间";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbrRemove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // cbrRemove
            // 
            this.cbrRemove.Name = "cbrRemove";
            this.cbrRemove.Size = new System.Drawing.Size(124, 22);
            this.cbrRemove.Text = "移除文件";
            this.cbrRemove.Click += new System.EventHandler(this.cbrRemove_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 18);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 502);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.pnlRules);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Ass字幕";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlRules;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem cbrStart;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.LinkLabel lblAll;
        private System.Windows.Forms.LinkLabel lblReserve;
        private System.Windows.Forms.Button btnClearFile;
        private System.Windows.Forms.ToolStripMenuItem cbrSelecrFile;
        private System.Windows.Forms.ToolStripMenuItem cbrSelectFolder;
        private System.Windows.Forms.CheckBox chkTimeArea;
        private System.Windows.Forms.TextBox txtTimeArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeOffset;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEncoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cbrRemove;
        private System.Windows.Forms.ImageList imageList1;
    }
}

