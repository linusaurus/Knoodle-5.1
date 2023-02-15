
namespace KnoodleUX
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stsMainStatus = new System.Windows.Forms.StatusStrip();
            this.tsPartLoadedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splconMain = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpJobOrders = new System.Windows.Forms.TabPage();
            this.lvJobOrders = new System.Windows.Forms.ListView();
            this.tbpDeliveries = new System.Windows.Forms.TabPage();
            this.spDeliveries = new System.Windows.Forms.SplitContainer();
            this.lbDelivery = new System.Windows.Forms.ListBox();
            this.tabMainTabControl = new System.Windows.Forms.TabControl();
            this.tabInputTable = new System.Windows.Forms.TabPage();
            this.spcMainTabControl = new System.Windows.Forms.SplitContainer();
            this.dgProductGrid = new System.Windows.Forms.DataGridView();
            this.tsProductTools = new System.Windows.Forms.ToolStrip();
            this.tsBuildProducts = new System.Windows.Forms.ToolStripButton();
            this.tsSaveOutput = new System.Windows.Forms.ToolStripButton();
            this.tsShowRecipe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddProduct = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteProduct = new System.Windows.Forms.ToolStripButton();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.stbPartListReport = new System.Windows.Forms.ToolStripButton();
            this.tsbOptimize = new System.Windows.Forms.ToolStripButton();
            this.dgSubAssemblies = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSubAssemblyLabel = new System.Windows.Forms.ToolStripLabel();
            this.tabInspector = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvBuildTree = new System.Windows.Forms.TreeView();
            this.partPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.tbRecipe = new System.Windows.Forms.TabPage();
            this.dgvOutputGrid = new System.Windows.Forms.DataGridView();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboJobsPicker = new System.Windows.Forms.ComboBox();
            this.btnInvertSelection = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.stsMainStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splconMain)).BeginInit();
            this.splconMain.Panel1.SuspendLayout();
            this.splconMain.Panel2.SuspendLayout();
            this.splconMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpJobOrders.SuspendLayout();
            this.tbpDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDeliveries)).BeginInit();
            this.spDeliveries.Panel2.SuspendLayout();
            this.spDeliveries.SuspendLayout();
            this.tabMainTabControl.SuspendLayout();
            this.tabInputTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainTabControl)).BeginInit();
            this.spcMainTabControl.Panel1.SuspendLayout();
            this.spcMainTabControl.Panel2.SuspendLayout();
            this.spcMainTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductGrid)).BeginInit();
            this.tsProductTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubAssemblies)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabInspector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputGrid)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stsMainStatus
            // 
            this.stsMainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPartLoadedStatus});
            this.stsMainStatus.Location = new System.Drawing.Point(10, 672);
            this.stsMainStatus.Name = "stsMainStatus";
            this.stsMainStatus.Size = new System.Drawing.Size(1287, 22);
            this.stsMainStatus.TabIndex = 1;
            this.stsMainStatus.Text = "statusStrip1";
            // 
            // tsPartLoadedStatus
            // 
            this.tsPartLoadedStatus.Name = "tsPartLoadedStatus";
            this.tsPartLoadedStatus.Size = new System.Drawing.Size(118, 17);
            this.tsPartLoadedStatus.Text = "toolStripStatusLabel1";
            // 
            // splconMain
            // 
            this.splconMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splconMain.Location = new System.Drawing.Point(10, 110);
            this.splconMain.Margin = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.splconMain.Name = "splconMain";
            // 
            // splconMain.Panel1
            // 
            this.splconMain.Panel1.Controls.Add(this.tabControl1);
            this.splconMain.Panel1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            // 
            // splconMain.Panel2
            // 
            this.splconMain.Panel2.Controls.Add(this.tabMainTabControl);
            this.splconMain.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splconMain.Size = new System.Drawing.Size(1287, 562);
            this.splconMain.SplitterDistance = 345;
            this.splconMain.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpJobOrders);
            this.tabControl1.Controls.Add(this.tbpDeliveries);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpJobOrders
            // 
            this.tbpJobOrders.Controls.Add(this.lvJobOrders);
            this.tbpJobOrders.Location = new System.Drawing.Point(4, 24);
            this.tbpJobOrders.Name = "tbpJobOrders";
            this.tbpJobOrders.Padding = new System.Windows.Forms.Padding(6);
            this.tbpJobOrders.Size = new System.Drawing.Size(331, 522);
            this.tbpJobOrders.TabIndex = 0;
            this.tbpJobOrders.Text = "Job Orders";
            this.tbpJobOrders.UseVisualStyleBackColor = true;
            // 
            // lvJobOrders
            // 
            this.lvJobOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvJobOrders.Location = new System.Drawing.Point(6, 6);
            this.lvJobOrders.Name = "lvJobOrders";
            this.lvJobOrders.Size = new System.Drawing.Size(319, 510);
            this.lvJobOrders.TabIndex = 0;
            this.lvJobOrders.UseCompatibleStateImageBehavior = false;
            // 
            // tbpDeliveries
            // 
            this.tbpDeliveries.Controls.Add(this.spDeliveries);
            this.tbpDeliveries.Location = new System.Drawing.Point(4, 24);
            this.tbpDeliveries.Name = "tbpDeliveries";
            this.tbpDeliveries.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeliveries.Size = new System.Drawing.Size(331, 522);
            this.tbpDeliveries.TabIndex = 1;
            this.tbpDeliveries.Text = "Deliveries";
            this.tbpDeliveries.UseVisualStyleBackColor = true;
            // 
            // spDeliveries
            // 
            this.spDeliveries.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.spDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spDeliveries.Location = new System.Drawing.Point(3, 3);
            this.spDeliveries.Name = "spDeliveries";
            this.spDeliveries.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spDeliveries.Panel2
            // 
            this.spDeliveries.Panel2.Controls.Add(this.lbDelivery);
            this.spDeliveries.Size = new System.Drawing.Size(325, 516);
            this.spDeliveries.SplitterDistance = 108;
            this.spDeliveries.TabIndex = 0;
            // 
            // lbDelivery
            // 
            this.lbDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDelivery.FormattingEnabled = true;
            this.lbDelivery.ItemHeight = 15;
            this.lbDelivery.Location = new System.Drawing.Point(0, 0);
            this.lbDelivery.Name = "lbDelivery";
            this.lbDelivery.Size = new System.Drawing.Size(325, 404);
            this.lbDelivery.TabIndex = 0;
            // 
            // tabMainTabControl
            // 
            this.tabMainTabControl.Controls.Add(this.tabInputTable);
            this.tabMainTabControl.Controls.Add(this.tabInspector);
            this.tabMainTabControl.Controls.Add(this.tbRecipe);
            this.tabMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMainTabControl.Location = new System.Drawing.Point(6, 6);
            this.tabMainTabControl.Name = "tabMainTabControl";
            this.tabMainTabControl.SelectedIndex = 0;
            this.tabMainTabControl.Size = new System.Drawing.Size(926, 550);
            this.tabMainTabControl.TabIndex = 0;
            this.tabMainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMainTabControl_DrawItem);
            // 
            // tabInputTable
            // 
            this.tabInputTable.Controls.Add(this.spcMainTabControl);
            this.tabInputTable.Location = new System.Drawing.Point(4, 24);
            this.tabInputTable.Name = "tabInputTable";
            this.tabInputTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabInputTable.Size = new System.Drawing.Size(918, 522);
            this.tabInputTable.TabIndex = 0;
            this.tabInputTable.Text = "Input Data";
            this.tabInputTable.UseVisualStyleBackColor = true;
            // 
            // spcMainTabControl
            // 
            this.spcMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMainTabControl.Location = new System.Drawing.Point(3, 3);
            this.spcMainTabControl.Name = "spcMainTabControl";
            this.spcMainTabControl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMainTabControl.Panel1
            // 
            this.spcMainTabControl.Panel1.Controls.Add(this.dgProductGrid);
            this.spcMainTabControl.Panel1.Controls.Add(this.tsProductTools);
            // 
            // spcMainTabControl.Panel2
            // 
            this.spcMainTabControl.Panel2.Controls.Add(this.dgSubAssemblies);
            this.spcMainTabControl.Panel2.Controls.Add(this.toolStrip1);
            this.spcMainTabControl.Size = new System.Drawing.Size(912, 516);
            this.spcMainTabControl.SplitterDistance = 307;
            this.spcMainTabControl.TabIndex = 0;
            // 
            // dgProductGrid
            // 
            this.dgProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductGrid.Location = new System.Drawing.Point(0, 37);
            this.dgProductGrid.Name = "dgProductGrid";
            this.dgProductGrid.RowTemplate.Height = 25;
            this.dgProductGrid.Size = new System.Drawing.Size(912, 270);
            this.dgProductGrid.TabIndex = 0;
            this.dgProductGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductGrid_CellContentClick);
            this.dgProductGrid.SelectionChanged += new System.EventHandler(this.dgProducts_SelectionChanged);
            // 
            // tsProductTools
            // 
            this.tsProductTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBuildProducts,
            this.tsSaveOutput,
            this.tsShowRecipe,
            this.toolStripSeparator1,
            this.tsbAddProduct,
            this.tsbDeleteProduct,
            this.tsbReport,
            this.stbPartListReport,
            this.tsbOptimize});
            this.tsProductTools.Location = new System.Drawing.Point(0, 0);
            this.tsProductTools.Name = "tsProductTools";
            this.tsProductTools.Padding = new System.Windows.Forms.Padding(3);
            this.tsProductTools.Size = new System.Drawing.Size(912, 37);
            this.tsProductTools.TabIndex = 1;
            this.tsProductTools.Text = "toolStrip1";
            this.tsProductTools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsProductTools_ItemClicked);
            // 
            // tsBuildProducts
            // 
            this.tsBuildProducts.BackColor = System.Drawing.Color.Black;
            this.tsBuildProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBuildProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsBuildProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsBuildProducts.Image")));
            this.tsBuildProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuildProducts.Name = "tsBuildProducts";
            this.tsBuildProducts.Size = new System.Drawing.Size(100, 28);
            this.tsBuildProducts.Text = "Build Assemblies";
            this.tsBuildProducts.Click += new System.EventHandler(this.tsBuildProducts_Click);
            // 
            // tsSaveOutput
            // 
            this.tsSaveOutput.BackColor = System.Drawing.Color.Moccasin;
            this.tsSaveOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSaveOutput.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveOutput.Image")));
            this.tsSaveOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveOutput.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsSaveOutput.Name = "tsSaveOutput";
            this.tsSaveOutput.Size = new System.Drawing.Size(76, 28);
            this.tsSaveOutput.Text = "Save Output";
            this.tsSaveOutput.Click += new System.EventHandler(this.tsSaveOutput_Click);
            // 
            // tsShowRecipe
            // 
            this.tsShowRecipe.BackColor = System.Drawing.Color.Tan;
            this.tsShowRecipe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsShowRecipe.Image = ((System.Drawing.Image)(resources.GetObject("tsShowRecipe.Image")));
            this.tsShowRecipe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsShowRecipe.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsShowRecipe.Name = "tsShowRecipe";
            this.tsShowRecipe.Size = new System.Drawing.Size(81, 28);
            this.tsShowRecipe.Text = "Show Output";
            this.tsShowRecipe.ToolTipText = "Generate Output";
            this.tsShowRecipe.Click += new System.EventHandler(this.tsShowRecipe_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbAddProduct
            // 
            this.tsbAddProduct.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAddProduct.BackColor = System.Drawing.Color.LightCyan;
            this.tsbAddProduct.CheckOnClick = true;
            this.tsbAddProduct.Image = global::KnoodleUX.Properties.Resources.twotone_add_box_black_24dp;
            this.tsbAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbAddProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddProduct.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.tsbAddProduct.Name = "tsbAddProduct";
            this.tsbAddProduct.Size = new System.Drawing.Size(102, 28);
            this.tsbAddProduct.Text = "Add Product";
            // 
            // tsbDeleteProduct
            // 
            this.tsbDeleteProduct.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDeleteProduct.BackColor = System.Drawing.Color.Linen;
            this.tsbDeleteProduct.Image = global::KnoodleUX.Properties.Resources.twotone_remove_circle_black_24dp;
            this.tsbDeleteProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteProduct.Name = "tsbDeleteProduct";
            this.tsbDeleteProduct.Size = new System.Drawing.Size(113, 28);
            this.tsbDeleteProduct.Text = "Delete Product";
            // 
            // tsbReport
            // 
            this.tsbReport.AutoSize = false;
            this.tsbReport.BackColor = System.Drawing.Color.LightSalmon;
            this.tsbReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbReport.Image")));
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(66, 28);
            this.tsbReport.Text = "Report";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
            // 
            // stbPartListReport
            // 
            this.stbPartListReport.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.stbPartListReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stbPartListReport.Image = ((System.Drawing.Image)(resources.GetObject("stbPartListReport.Image")));
            this.stbPartListReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbPartListReport.Margin = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.stbPartListReport.Name = "stbPartListReport";
            this.stbPartListReport.Size = new System.Drawing.Size(88, 27);
            this.stbPartListReport.Text = "PartList Report";
            this.stbPartListReport.Click += new System.EventHandler(this.stbPartListReport_Click);
            // 
            // tsbOptimize
            // 
            this.tsbOptimize.BackColor = System.Drawing.Color.PowderBlue;
            this.tsbOptimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOptimize.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tsbOptimize.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptimize.Image")));
            this.tsbOptimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptimize.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbOptimize.Name = "tsbOptimize";
            this.tsbOptimize.Size = new System.Drawing.Size(59, 28);
            this.tsbOptimize.Text = "Optimize";
            this.tsbOptimize.Click += new System.EventHandler(this.tsbOptimize_Click);
            // 
            // dgSubAssemblies
            // 
            this.dgSubAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSubAssemblies.Location = new System.Drawing.Point(0, 25);
            this.dgSubAssemblies.Name = "dgSubAssemblies";
            this.dgSubAssemblies.RowTemplate.Height = 25;
            this.dgSubAssemblies.Size = new System.Drawing.Size(912, 180);
            this.dgSubAssemblies.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSubAssemblyLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(912, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSubAssemblyLabel
            // 
            this.tsSubAssemblyLabel.Name = "tsSubAssemblyLabel";
            this.tsSubAssemblyLabel.Size = new System.Drawing.Size(86, 22);
            this.tsSubAssemblyLabel.Text = "SubAssemblies";
            // 
            // tabInspector
            // 
            this.tabInspector.Controls.Add(this.splitContainer1);
            this.tabInspector.Location = new System.Drawing.Point(4, 24);
            this.tabInspector.Name = "tabInspector";
            this.tabInspector.Padding = new System.Windows.Forms.Padding(6);
            this.tabInspector.Size = new System.Drawing.Size(918, 522);
            this.tabInspector.TabIndex = 1;
            this.tabInspector.Text = "Inspector";
            this.tabInspector.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvBuildTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.partPropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(906, 510);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvBuildTree
            // 
            this.tvBuildTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBuildTree.Location = new System.Drawing.Point(0, 0);
            this.tvBuildTree.Name = "tvBuildTree";
            this.tvBuildTree.Size = new System.Drawing.Size(301, 510);
            this.tvBuildTree.TabIndex = 0;
            this.tvBuildTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBuildTree_AfterSelect);
            // 
            // partPropertyGrid
            // 
            this.partPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.partPropertyGrid.Name = "partPropertyGrid";
            this.partPropertyGrid.Size = new System.Drawing.Size(601, 510);
            this.partPropertyGrid.TabIndex = 0;
            // 
            // tbRecipe
            // 
            this.tbRecipe.Controls.Add(this.dgvOutputGrid);
            this.tbRecipe.Location = new System.Drawing.Point(4, 24);
            this.tbRecipe.Name = "tbRecipe";
            this.tbRecipe.Padding = new System.Windows.Forms.Padding(6);
            this.tbRecipe.Size = new System.Drawing.Size(918, 522);
            this.tbRecipe.TabIndex = 2;
            this.tbRecipe.Text = "Output";
            this.tbRecipe.UseVisualStyleBackColor = true;
            // 
            // dgvOutputGrid
            // 
            this.dgvOutputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutputGrid.Location = new System.Drawing.Point(6, 6);
            this.dgvOutputGrid.Name = "dgvOutputGrid";
            this.dgvOutputGrid.RowTemplate.Height = 25;
            this.dgvOutputGrid.Size = new System.Drawing.Size(906, 510);
            this.dgvOutputGrid.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.pictureBox1);
            this.buttonsPanel.Controls.Add(this.cboJobsPicker);
            this.buttonsPanel.Controls.Add(this.btnInvertSelection);
            this.buttonsPanel.Controls.Add(this.btnClearAll);
            this.buttonsPanel.Controls.Add(this.btnSelectAll);
            this.buttonsPanel.Controls.Add(this.btnSaveChanges);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel.Location = new System.Drawing.Point(10, 10);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1287, 100);
            this.buttonsPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KnoodleUX.Properties.Resources.arrow_back;
            this.pictureBox1.Location = new System.Drawing.Point(10, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboJobsPicker
            // 
            this.cboJobsPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboJobsPicker.FormattingEnabled = true;
            this.cboJobsPicker.Location = new System.Drawing.Point(980, 12);
            this.cboJobsPicker.Name = "cboJobsPicker";
            this.cboJobsPicker.Size = new System.Drawing.Size(294, 23);
            this.cboJobsPicker.TabIndex = 2;
            this.cboJobsPicker.SelectedIndexChanged += new System.EventHandler(this.cboJobsPicker_SelectedIndexChanged);
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvertSelection.Location = new System.Drawing.Point(1169, 65);
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.Size = new System.Drawing.Size(106, 23);
            this.btnInvertSelection.TabIndex = 1;
            this.btnInvertSelection.Text = "Invert Selection";
            this.btnInvertSelection.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Location = new System.Drawing.Point(1088, 65);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Location = new System.Drawing.Point(980, 65);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(102, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Location = new System.Drawing.Point(10, 12);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(126, 34);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1307, 704);
            this.Controls.Add(this.splconMain);
            this.Controls.Add(this.stsMainStatus);
            this.Controls.Add(this.buttonsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Knoodle Parametric";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.stsMainStatus.ResumeLayout(false);
            this.stsMainStatus.PerformLayout();
            this.splconMain.Panel1.ResumeLayout(false);
            this.splconMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splconMain)).EndInit();
            this.splconMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpJobOrders.ResumeLayout(false);
            this.tbpDeliveries.ResumeLayout(false);
            this.spDeliveries.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spDeliveries)).EndInit();
            this.spDeliveries.ResumeLayout(false);
            this.tabMainTabControl.ResumeLayout(false);
            this.tabInputTable.ResumeLayout(false);
            this.spcMainTabControl.Panel1.ResumeLayout(false);
            this.spcMainTabControl.Panel1.PerformLayout();
            this.spcMainTabControl.Panel2.ResumeLayout(false);
            this.spcMainTabControl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainTabControl)).EndInit();
            this.spcMainTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductGrid)).EndInit();
            this.tsProductTools.ResumeLayout(false);
            this.tsProductTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubAssemblies)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabInspector.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputGrid)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsMainStatus;
        private System.Windows.Forms.SplitContainer splconMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpJobOrders;
        private System.Windows.Forms.TabPage tbpDeliveries;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button btnInvertSelection;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.TabControl tabMainTabControl;
        private System.Windows.Forms.TabPage tabInputTable;
        private System.Windows.Forms.SplitContainer spcMainTabControl;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.ToolStrip tsProductTools;
        private System.Windows.Forms.ToolStripButton tsBuildProducts;
        private System.Windows.Forms.DataGridView dgSubAssemblies;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsSubAssemblyLabel;
        private System.Windows.Forms.TabPage tabInspector;
        private System.Windows.Forms.ToolStripButton tsSaveOutput;
        private System.Windows.Forms.ComboBox cboJobsPicker;
        private System.Windows.Forms.DataGridView dgProductGrid;
        private System.Windows.Forms.ListView lvJobOrders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddProduct;
        private System.Windows.Forms.ToolStripButton tsbDeleteProduct;
        private System.Windows.Forms.SplitContainer spDeliveries;
        private System.Windows.Forms.ListBox lbDelivery;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvBuildTree;
        private System.Windows.Forms.PropertyGrid partPropertyGrid;
        private System.Windows.Forms.ToolStripButton tsShowRecipe;
        private System.Windows.Forms.ToolStripStatusLabel tsPartLoadedStatus;
        private System.Windows.Forms.TabPage tbRecipe;
        private System.Windows.Forms.DataGridView dgvOutputGrid;
        private System.Windows.Forms.ToolStripButton tsbReport;
        private System.Windows.Forms.ToolStripButton stbPartListReport;
        private System.Windows.Forms.ToolStripButton tsbOptimize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

