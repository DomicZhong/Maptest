namespace MapTest01
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInCtrlIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtendCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splcMapLegend = new System.Windows.Forms.SplitContainer();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.map1 = new DotSpatial.Controls.Map();
            this.splcDataOperation = new System.Windows.Forms.SplitContainer();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.btnFilterByPopulation = new System.Windows.Forms.Button();
            this.btnViewAttributes = new System.Windows.Forms.Button();
            this.btnRandomColors = new System.Windows.Forms.Button();
            this.btnFilterByPopState = new System.Windows.Forms.Button();
            this.btnFilterByStateName = new System.Windows.Forms.Button();
            this.btnDisplayStateName = new System.Windows.Forms.Button();
            this.dgvAttributeTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).BeginInit();
            this.splcMapLegend.Panel1.SuspendLayout();
            this.splcMapLegend.Panel2.SuspendLayout();
            this.splcMapLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).BeginInit();
            this.splcDataOperation.Panel1.SuspendLayout();
            this.splcDataOperation.Panel2.SuspendLayout();
            this.splcDataOperation.SuspendLayout();
            this.gbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMapToolStripMenuItem,
            this.clearMapCtrlCToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadMapToolStripMenuItem.Text = "&Load Map ";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // clearMapCtrlCToolStripMenuItem
            // 
            this.clearMapCtrlCToolStripMenuItem.Name = "clearMapCtrlCToolStripMenuItem";
            this.clearMapCtrlCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearMapCtrlCToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clearMapCtrlCToolStripMenuItem.Text = "&Clear Map ";
            this.clearMapCtrlCToolStripMenuItem.Click += new System.EventHandler(this.clearMapCtrlCToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "&Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mapOptionsToolStripMenuItem
            // 
            this.mapOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInCtrlIToolStripMenuItem,
            this.zoomOutCtrlOToolStripMenuItem,
            this.zoomExtendCtrlZToolStripMenuItem});
            this.mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem";
            this.mapOptionsToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.mapOptionsToolStripMenuItem.Text = "&Map Options";
            // 
            // zoomInCtrlIToolStripMenuItem
            // 
            this.zoomInCtrlIToolStripMenuItem.Name = "zoomInCtrlIToolStripMenuItem";
            this.zoomInCtrlIToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.zoomInCtrlIToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.zoomInCtrlIToolStripMenuItem.Text = "Zoom &In ";
            this.zoomInCtrlIToolStripMenuItem.Click += new System.EventHandler(this.zoomInCtrlIToolStripMenuItem_Click);
            // 
            // zoomOutCtrlOToolStripMenuItem
            // 
            this.zoomOutCtrlOToolStripMenuItem.Name = "zoomOutCtrlOToolStripMenuItem";
            this.zoomOutCtrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.zoomOutCtrlOToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.zoomOutCtrlOToolStripMenuItem.Text = "Zoom &Out";
            this.zoomOutCtrlOToolStripMenuItem.Click += new System.EventHandler(this.zoomOutCtrlOToolStripMenuItem_Click);
            // 
            // zoomExtendCtrlZToolStripMenuItem
            // 
            this.zoomExtendCtrlZToolStripMenuItem.Name = "zoomExtendCtrlZToolStripMenuItem";
            this.zoomExtendCtrlZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.zoomExtendCtrlZToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.zoomExtendCtrlZToolStripMenuItem.Text = "Zoom &Extent";
            this.zoomExtendCtrlZToolStripMenuItem.Click += new System.EventHandler(this.zoomExtendCtrlZToolStripMenuItem_Click);
            // 
            // splcMapLegend
            // 
            this.splcMapLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.splcMapLegend.Location = new System.Drawing.Point(0, 25);
            this.splcMapLegend.Name = "splcMapLegend";
            // 
            // splcMapLegend.Panel1
            // 
            this.splcMapLegend.Panel1.Controls.Add(this.legend1);
            // 
            // splcMapLegend.Panel2
            // 
            this.splcMapLegend.Panel2.Controls.Add(this.map1);
            this.splcMapLegend.Size = new System.Drawing.Size(817, 278);
            this.splcMapLegend.SplitterDistance = 272;
            this.splcMapLegend.TabIndex = 1;
            this.splcMapLegend.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splcMapLegend_SplitterMoved);
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 272, 278);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(272, 278);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = this.legend1;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(541, 278);
            this.map1.TabIndex = 0;
            // 
            // splcDataOperation
            // 
            this.splcDataOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcDataOperation.Location = new System.Drawing.Point(0, 303);
            this.splcDataOperation.Name = "splcDataOperation";
            this.splcDataOperation.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcDataOperation.Panel1
            // 
            this.splcDataOperation.Panel1.Controls.Add(this.gbOperations);
            this.splcDataOperation.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splcDataOperation.Panel2
            // 
            this.splcDataOperation.Panel2.Controls.Add(this.dgvAttributeTable);
            this.splcDataOperation.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splcDataOperation.Size = new System.Drawing.Size(817, 182);
            this.splcDataOperation.SplitterDistance = 153;
            this.splcDataOperation.TabIndex = 2;
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.txtPopulation);
            this.gbOperations.Controls.Add(this.lblTitle);
            this.gbOperations.Controls.Add(this.lblPopulation);
            this.gbOperations.Controls.Add(this.btnFilterByPopulation);
            this.gbOperations.Controls.Add(this.btnViewAttributes);
            this.gbOperations.Controls.Add(this.btnRandomColors);
            this.gbOperations.Controls.Add(this.btnFilterByPopState);
            this.gbOperations.Controls.Add(this.btnFilterByStateName);
            this.gbOperations.Controls.Add(this.btnDisplayStateName);
            this.gbOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperations.Location = new System.Drawing.Point(0, 0);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(817, 153);
            this.gbOperations.TabIndex = 0;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(483, 90);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(83, 21);
            this.txtPopulation.TabIndex = 8;
            this.txtPopulation.TextChanged += new System.EventHandler(this.txtPopulation_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(3, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 12);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Attribute Table";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(244, 95);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(233, 12);
            this.lblPopulation.TabIndex = 6;
            this.lblPopulation.Text = "Enter the amount of population in 1990";
            this.lblPopulation.Click += new System.EventHandler(this.lblPopulation_Click);
            // 
            // btnFilterByPopulation
            // 
            this.btnFilterByPopulation.Location = new System.Drawing.Point(592, 84);
            this.btnFilterByPopulation.Name = "btnFilterByPopulation";
            this.btnFilterByPopulation.Size = new System.Drawing.Size(213, 31);
            this.btnFilterByPopulation.TabIndex = 5;
            this.btnFilterByPopulation.Text = "Filter by amount of &population";
            this.btnFilterByPopulation.UseVisualStyleBackColor = true;
            this.btnFilterByPopulation.Click += new System.EventHandler(this.btnFilterByPopulation_Click);
            // 
            // btnViewAttributes
            // 
            this.btnViewAttributes.Location = new System.Drawing.Point(667, 32);
            this.btnViewAttributes.Name = "btnViewAttributes";
            this.btnViewAttributes.Size = new System.Drawing.Size(138, 37);
            this.btnViewAttributes.TabIndex = 4;
            this.btnViewAttributes.Text = "View &Attributes";
            this.btnViewAttributes.UseVisualStyleBackColor = true;
            this.btnViewAttributes.Click += new System.EventHandler(this.btnViewAttributes_Click);
            // 
            // btnRandomColors
            // 
            this.btnRandomColors.Location = new System.Drawing.Point(12, 86);
            this.btnRandomColors.Name = "btnRandomColors";
            this.btnRandomColors.Size = new System.Drawing.Size(215, 31);
            this.btnRandomColors.TabIndex = 3;
            this.btnRandomColors.Text = "&Random colors based on State Name";
            this.btnRandomColors.UseVisualStyleBackColor = true;
            this.btnRandomColors.Click += new System.EventHandler(this.btnRandomColors_Click);
            // 
            // btnFilterByPopState
            // 
            this.btnFilterByPopState.Location = new System.Drawing.Point(373, 32);
            this.btnFilterByPopState.Name = "btnFilterByPopState";
            this.btnFilterByPopState.Size = new System.Drawing.Size(240, 37);
            this.btnFilterByPopState.TabIndex = 2;
            this.btnFilterByPopState.Text = "Filter by &Population and State Name";
            this.btnFilterByPopState.UseVisualStyleBackColor = true;
            this.btnFilterByPopState.Click += new System.EventHandler(this.btnFilterByPopState_Click);
            // 
            // btnFilterByStateName
            // 
            this.btnFilterByStateName.Location = new System.Drawing.Point(190, 32);
            this.btnFilterByStateName.Name = "btnFilterByStateName";
            this.btnFilterByStateName.Size = new System.Drawing.Size(142, 37);
            this.btnFilterByStateName.TabIndex = 1;
            this.btnFilterByStateName.Text = "Filter by &State Name";
            this.btnFilterByStateName.UseVisualStyleBackColor = true;
            this.btnFilterByStateName.Click += new System.EventHandler(this.btnFilterByStateName_Click);
            // 
            // btnDisplayStateName
            // 
            this.btnDisplayStateName.Location = new System.Drawing.Point(12, 32);
            this.btnDisplayStateName.Name = "btnDisplayStateName";
            this.btnDisplayStateName.Size = new System.Drawing.Size(131, 37);
            this.btnDisplayStateName.TabIndex = 0;
            this.btnDisplayStateName.Text = "&Display State Name";
            this.btnDisplayStateName.UseVisualStyleBackColor = true;
            this.btnDisplayStateName.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAttributeTable
            // 
            this.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttributeTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAttributeTable.Name = "dgvAttributeTable";
            this.dgvAttributeTable.RowTemplate.Height = 23;
            this.dgvAttributeTable.Size = new System.Drawing.Size(817, 25);
            this.dgvAttributeTable.TabIndex = 0;
            this.dgvAttributeTable.SelectionChanged += new System.EventHandler(this.dgvAttributeTable_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 485);
            this.Controls.Add(this.splcDataOperation);
            this.Controls.Add(this.splcMapLegend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splcMapLegend.Panel1.ResumeLayout(false);
            this.splcMapLegend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).EndInit();
            this.splcMapLegend.ResumeLayout(false);
            this.splcDataOperation.Panel1.ResumeLayout(false);
            this.splcDataOperation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).EndInit();
            this.splcDataOperation.ResumeLayout(false);
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInCtrlIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomExtendCtrlZToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splcMapLegend;
        private DotSpatial.Controls.Legend legend1;
        private System.Windows.Forms.SplitContainer splcDataOperation;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnDisplayStateName;
        private System.Windows.Forms.DataGridView dgvAttributeTable;
        private System.Windows.Forms.Button btnFilterByPopulation;
        private System.Windows.Forms.Button btnViewAttributes;
        private System.Windows.Forms.Button btnRandomColors;
        private System.Windows.Forms.Button btnFilterByPopState;
        private System.Windows.Forms.Button btnFilterByStateName;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPopulation;
    }
}

