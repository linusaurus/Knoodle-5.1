
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
            stsMainStatus = new System.Windows.Forms.StatusStrip();
            tsPartLoadedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            splconMain = new System.Windows.Forms.SplitContainer();
            tabControl1 = new System.Windows.Forms.TabControl();
            tbpJobOrders = new System.Windows.Forms.TabPage();
            lvJobOrders = new System.Windows.Forms.ListView();
            tbpDeliveries = new System.Windows.Forms.TabPage();
            spDeliveries = new System.Windows.Forms.SplitContainer();
            lbDelivery = new System.Windows.Forms.ListBox();
            tabMainTabControl = new System.Windows.Forms.TabControl();
            tabInputTable = new System.Windows.Forms.TabPage();
            spcMainTabControl = new System.Windows.Forms.SplitContainer();
            dgProductGrid = new System.Windows.Forms.DataGridView();
            tsProductTools = new System.Windows.Forms.ToolStrip();
            tsBuildProducts = new System.Windows.Forms.ToolStripButton();
            tsSaveOutput = new System.Windows.Forms.ToolStripButton();
            tsShowRecipe = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbAddProduct = new System.Windows.Forms.ToolStripButton();
            tsbDeleteProduct = new System.Windows.Forms.ToolStripButton();
            tsbReport = new System.Windows.Forms.ToolStripButton();
            stbPartListReport = new System.Windows.Forms.ToolStripButton();
            tsbOptimize = new System.Windows.Forms.ToolStripButton();
            dgSubAssemblies = new System.Windows.Forms.DataGridView();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsSubAssemblyLabel = new System.Windows.Forms.ToolStripLabel();
            tabInspector = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tvBuildTree = new System.Windows.Forms.TreeView();
            partPropertyGrid = new System.Windows.Forms.PropertyGrid();
            tbRecipe = new System.Windows.Forms.TabPage();
            dgvOutputGrid = new System.Windows.Forms.DataGridView();
            buttonsPanel = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cboJobsPicker = new System.Windows.Forms.ComboBox();
            btnInvertSelection = new System.Windows.Forms.Button();
            btnClearAll = new System.Windows.Forms.Button();
            btnSelectAll = new System.Windows.Forms.Button();
            btnSaveChanges = new System.Windows.Forms.Button();
            tsbLabels = new System.Windows.Forms.ToolStripButton();
            stsMainStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splconMain).BeginInit();
            splconMain.Panel1.SuspendLayout();
            splconMain.Panel2.SuspendLayout();
            splconMain.SuspendLayout();
            tabControl1.SuspendLayout();
            tbpJobOrders.SuspendLayout();
            tbpDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spDeliveries).BeginInit();
            spDeliveries.Panel2.SuspendLayout();
            spDeliveries.SuspendLayout();
            tabMainTabControl.SuspendLayout();
            tabInputTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcMainTabControl).BeginInit();
            spcMainTabControl.Panel1.SuspendLayout();
            spcMainTabControl.Panel2.SuspendLayout();
            spcMainTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductGrid).BeginInit();
            tsProductTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSubAssemblies).BeginInit();
            toolStrip1.SuspendLayout();
            tabInspector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tbRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOutputGrid).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // stsMainStatus
            // 
            stsMainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsPartLoadedStatus });
            stsMainStatus.Location = new System.Drawing.Point(10, 672);
            stsMainStatus.Name = "stsMainStatus";
            stsMainStatus.Size = new System.Drawing.Size(1287, 22);
            stsMainStatus.TabIndex = 1;
            stsMainStatus.Text = "statusStrip1";
            // 
            // tsPartLoadedStatus
            // 
            tsPartLoadedStatus.Name = "tsPartLoadedStatus";
            tsPartLoadedStatus.Size = new System.Drawing.Size(118, 17);
            tsPartLoadedStatus.Text = "toolStripStatusLabel1";
            // 
            // splconMain
            // 
            splconMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splconMain.Location = new System.Drawing.Point(10, 110);
            splconMain.Margin = new System.Windows.Forms.Padding(3, 65, 3, 3);
            splconMain.Name = "splconMain";
            // 
            // splconMain.Panel1
            // 
            splconMain.Panel1.Controls.Add(tabControl1);
            splconMain.Panel1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            // 
            // splconMain.Panel2
            // 
            splconMain.Panel2.Controls.Add(tabMainTabControl);
            splconMain.Panel2.Padding = new System.Windows.Forms.Padding(6);
            splconMain.Size = new System.Drawing.Size(1287, 562);
            splconMain.SplitterDistance = 345;
            splconMain.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpJobOrders);
            tabControl1.Controls.Add(tbpDeliveries);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(6, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(339, 550);
            tabControl1.TabIndex = 0;
            // 
            // tbpJobOrders
            // 
            tbpJobOrders.Controls.Add(lvJobOrders);
            tbpJobOrders.Location = new System.Drawing.Point(4, 24);
            tbpJobOrders.Name = "tbpJobOrders";
            tbpJobOrders.Padding = new System.Windows.Forms.Padding(6);
            tbpJobOrders.Size = new System.Drawing.Size(331, 522);
            tbpJobOrders.TabIndex = 0;
            tbpJobOrders.Text = "Job Orders";
            tbpJobOrders.UseVisualStyleBackColor = true;
            // 
            // lvJobOrders
            // 
            lvJobOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            lvJobOrders.Location = new System.Drawing.Point(6, 6);
            lvJobOrders.Name = "lvJobOrders";
            lvJobOrders.Size = new System.Drawing.Size(319, 510);
            lvJobOrders.TabIndex = 0;
            lvJobOrders.UseCompatibleStateImageBehavior = false;
            // 
            // tbpDeliveries
            // 
            tbpDeliveries.Controls.Add(spDeliveries);
            tbpDeliveries.Location = new System.Drawing.Point(4, 24);
            tbpDeliveries.Name = "tbpDeliveries";
            tbpDeliveries.Padding = new System.Windows.Forms.Padding(3);
            tbpDeliveries.Size = new System.Drawing.Size(331, 522);
            tbpDeliveries.TabIndex = 1;
            tbpDeliveries.Text = "Deliveries";
            tbpDeliveries.UseVisualStyleBackColor = true;
            // 
            // spDeliveries
            // 
            spDeliveries.Cursor = System.Windows.Forms.Cursors.HSplit;
            spDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            spDeliveries.Location = new System.Drawing.Point(3, 3);
            spDeliveries.Name = "spDeliveries";
            spDeliveries.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spDeliveries.Panel2
            // 
            spDeliveries.Panel2.Controls.Add(lbDelivery);
            spDeliveries.Size = new System.Drawing.Size(325, 516);
            spDeliveries.SplitterDistance = 108;
            spDeliveries.TabIndex = 0;
            // 
            // lbDelivery
            // 
            lbDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            lbDelivery.FormattingEnabled = true;
            lbDelivery.ItemHeight = 15;
            lbDelivery.Location = new System.Drawing.Point(0, 0);
            lbDelivery.Name = "lbDelivery";
            lbDelivery.Size = new System.Drawing.Size(325, 404);
            lbDelivery.TabIndex = 0;
            // 
            // tabMainTabControl
            // 
            tabMainTabControl.Controls.Add(tabInputTable);
            tabMainTabControl.Controls.Add(tabInspector);
            tabMainTabControl.Controls.Add(tbRecipe);
            tabMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabMainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabMainTabControl.Location = new System.Drawing.Point(6, 6);
            tabMainTabControl.Name = "tabMainTabControl";
            tabMainTabControl.SelectedIndex = 0;
            tabMainTabControl.Size = new System.Drawing.Size(926, 550);
            tabMainTabControl.TabIndex = 0;
            tabMainTabControl.DrawItem += tabMainTabControl_DrawItem;
            // 
            // tabInputTable
            // 
            tabInputTable.Controls.Add(spcMainTabControl);
            tabInputTable.Location = new System.Drawing.Point(4, 24);
            tabInputTable.Name = "tabInputTable";
            tabInputTable.Padding = new System.Windows.Forms.Padding(3);
            tabInputTable.Size = new System.Drawing.Size(918, 522);
            tabInputTable.TabIndex = 0;
            tabInputTable.Text = "Input Data";
            tabInputTable.UseVisualStyleBackColor = true;
            // 
            // spcMainTabControl
            // 
            spcMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            spcMainTabControl.Location = new System.Drawing.Point(3, 3);
            spcMainTabControl.Name = "spcMainTabControl";
            spcMainTabControl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMainTabControl.Panel1
            // 
            spcMainTabControl.Panel1.Controls.Add(dgProductGrid);
            spcMainTabControl.Panel1.Controls.Add(tsProductTools);
            // 
            // spcMainTabControl.Panel2
            // 
            spcMainTabControl.Panel2.Controls.Add(dgSubAssemblies);
            spcMainTabControl.Panel2.Controls.Add(toolStrip1);
            spcMainTabControl.Size = new System.Drawing.Size(912, 516);
            spcMainTabControl.SplitterDistance = 307;
            spcMainTabControl.TabIndex = 0;
            // 
            // dgProductGrid
            // 
            dgProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            dgProductGrid.Location = new System.Drawing.Point(0, 37);
            dgProductGrid.Name = "dgProductGrid";
            dgProductGrid.RowTemplate.Height = 25;
            dgProductGrid.Size = new System.Drawing.Size(912, 270);
            dgProductGrid.TabIndex = 0;
            dgProductGrid.CellContentClick += dgProductGrid_CellContentClick;
            dgProductGrid.SelectionChanged += dgProducts_SelectionChanged;
            // 
            // tsProductTools
            // 
            tsProductTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsBuildProducts, tsSaveOutput, tsShowRecipe, toolStripSeparator1, tsbAddProduct, tsbDeleteProduct, tsbReport, stbPartListReport, tsbOptimize, tsbLabels });
            tsProductTools.Location = new System.Drawing.Point(0, 0);
            tsProductTools.Name = "tsProductTools";
            tsProductTools.Padding = new System.Windows.Forms.Padding(3);
            tsProductTools.Size = new System.Drawing.Size(912, 37);
            tsProductTools.TabIndex = 1;
            tsProductTools.Text = "toolStrip1";
            tsProductTools.ItemClicked += tsProductTools_ItemClicked;
            // 
            // tsBuildProducts
            // 
            tsBuildProducts.BackColor = System.Drawing.Color.Black;
            tsBuildProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsBuildProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tsBuildProducts.Image = (System.Drawing.Image)resources.GetObject("tsBuildProducts.Image");
            tsBuildProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBuildProducts.Name = "tsBuildProducts";
            tsBuildProducts.Size = new System.Drawing.Size(100, 28);
            tsBuildProducts.Text = "Build Assemblies";
            tsBuildProducts.Click += tsBuildProducts_Click;
            // 
            // tsSaveOutput
            // 
            tsSaveOutput.BackColor = System.Drawing.Color.Moccasin;
            tsSaveOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsSaveOutput.Image = (System.Drawing.Image)resources.GetObject("tsSaveOutput.Image");
            tsSaveOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSaveOutput.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            tsSaveOutput.Name = "tsSaveOutput";
            tsSaveOutput.Size = new System.Drawing.Size(76, 28);
            tsSaveOutput.Text = "Save Output";
            tsSaveOutput.Click += tsSaveOutput_Click;
            // 
            // tsShowRecipe
            // 
            tsShowRecipe.BackColor = System.Drawing.Color.Tan;
            tsShowRecipe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsShowRecipe.Image = (System.Drawing.Image)resources.GetObject("tsShowRecipe.Image");
            tsShowRecipe.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsShowRecipe.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            tsShowRecipe.Name = "tsShowRecipe";
            tsShowRecipe.Size = new System.Drawing.Size(81, 28);
            tsShowRecipe.Text = "Show Output";
            tsShowRecipe.ToolTipText = "Generate Output";
            tsShowRecipe.Click += tsShowRecipe_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbAddProduct
            // 
            tsbAddProduct.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbAddProduct.BackColor = System.Drawing.Color.LightCyan;
            tsbAddProduct.CheckOnClick = true;
            tsbAddProduct.Image = Properties.Resources.twotone_add_box_black_24dp;
            tsbAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tsbAddProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsbAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbAddProduct.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            tsbAddProduct.Name = "tsbAddProduct";
            tsbAddProduct.Size = new System.Drawing.Size(102, 28);
            tsbAddProduct.Text = "Add Product";
            // 
            // tsbDeleteProduct
            // 
            tsbDeleteProduct.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbDeleteProduct.BackColor = System.Drawing.Color.Linen;
            tsbDeleteProduct.Image = Properties.Resources.twotone_remove_circle_black_24dp;
            tsbDeleteProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsbDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDeleteProduct.Name = "tsbDeleteProduct";
            tsbDeleteProduct.Size = new System.Drawing.Size(113, 28);
            tsbDeleteProduct.Text = "Delete Product";
            // 
            // tsbReport
            // 
            tsbReport.AutoSize = false;
            tsbReport.BackColor = System.Drawing.Color.LightSalmon;
            tsbReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbReport.Image = (System.Drawing.Image)resources.GetObject("tsbReport.Image");
            tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbReport.Name = "tsbReport";
            tsbReport.Size = new System.Drawing.Size(66, 28);
            tsbReport.Text = "Report";
            tsbReport.Click += tsbReport_Click;
            // 
            // stbPartListReport
            // 
            stbPartListReport.BackColor = System.Drawing.Color.DarkSeaGreen;
            stbPartListReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            stbPartListReport.Image = (System.Drawing.Image)resources.GetObject("stbPartListReport.Image");
            stbPartListReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            stbPartListReport.Margin = new System.Windows.Forms.Padding(4, 2, 0, 2);
            stbPartListReport.Name = "stbPartListReport";
            stbPartListReport.Size = new System.Drawing.Size(88, 27);
            stbPartListReport.Text = "PartList Report";
            stbPartListReport.Click += stbPartListReport_Click;
            // 
            // tsbOptimize
            // 
            tsbOptimize.BackColor = System.Drawing.Color.PowderBlue;
            tsbOptimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbOptimize.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            tsbOptimize.Image = (System.Drawing.Image)resources.GetObject("tsbOptimize.Image");
            tsbOptimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbOptimize.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            tsbOptimize.Name = "tsbOptimize";
            tsbOptimize.Size = new System.Drawing.Size(59, 28);
            tsbOptimize.Text = "Optimize";
            tsbOptimize.Click += tsbOptimize_Click;
            // 
            // dgSubAssemblies
            // 
            dgSubAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            dgSubAssemblies.Location = new System.Drawing.Point(0, 25);
            dgSubAssemblies.Name = "dgSubAssemblies";
            dgSubAssemblies.RowTemplate.Height = 25;
            dgSubAssemblies.Size = new System.Drawing.Size(912, 180);
            dgSubAssemblies.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsSubAssemblyLabel });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(912, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsSubAssemblyLabel
            // 
            tsSubAssemblyLabel.Name = "tsSubAssemblyLabel";
            tsSubAssemblyLabel.Size = new System.Drawing.Size(86, 22);
            tsSubAssemblyLabel.Text = "SubAssemblies";
            // 
            // tabInspector
            // 
            tabInspector.Controls.Add(splitContainer1);
            tabInspector.Location = new System.Drawing.Point(4, 24);
            tabInspector.Name = "tabInspector";
            tabInspector.Padding = new System.Windows.Forms.Padding(6);
            tabInspector.Size = new System.Drawing.Size(918, 522);
            tabInspector.TabIndex = 1;
            tabInspector.Text = "Inspector";
            tabInspector.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(6, 6);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvBuildTree);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(partPropertyGrid);
            splitContainer1.Size = new System.Drawing.Size(906, 510);
            splitContainer1.SplitterDistance = 301;
            splitContainer1.TabIndex = 0;
            // 
            // tvBuildTree
            // 
            tvBuildTree.Dock = System.Windows.Forms.DockStyle.Fill;
            tvBuildTree.Location = new System.Drawing.Point(0, 0);
            tvBuildTree.Name = "tvBuildTree";
            tvBuildTree.Size = new System.Drawing.Size(301, 510);
            tvBuildTree.TabIndex = 0;
            tvBuildTree.AfterSelect += tvBuildTree_AfterSelect;
            // 
            // partPropertyGrid
            // 
            partPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            partPropertyGrid.Location = new System.Drawing.Point(0, 0);
            partPropertyGrid.Name = "partPropertyGrid";
            partPropertyGrid.Size = new System.Drawing.Size(601, 510);
            partPropertyGrid.TabIndex = 0;
            // 
            // tbRecipe
            // 
            tbRecipe.Controls.Add(dgvOutputGrid);
            tbRecipe.Location = new System.Drawing.Point(4, 24);
            tbRecipe.Name = "tbRecipe";
            tbRecipe.Padding = new System.Windows.Forms.Padding(6);
            tbRecipe.Size = new System.Drawing.Size(918, 522);
            tbRecipe.TabIndex = 2;
            tbRecipe.Text = "Output";
            tbRecipe.UseVisualStyleBackColor = true;
            // 
            // dgvOutputGrid
            // 
            dgvOutputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutputGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOutputGrid.Location = new System.Drawing.Point(6, 6);
            dgvOutputGrid.Name = "dgvOutputGrid";
            dgvOutputGrid.RowTemplate.Height = 25;
            dgvOutputGrid.Size = new System.Drawing.Size(906, 510);
            dgvOutputGrid.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(pictureBox1);
            buttonsPanel.Controls.Add(cboJobsPicker);
            buttonsPanel.Controls.Add(btnInvertSelection);
            buttonsPanel.Controls.Add(btnClearAll);
            buttonsPanel.Controls.Add(btnSelectAll);
            buttonsPanel.Controls.Add(btnSaveChanges);
            buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            buttonsPanel.Location = new System.Drawing.Point(10, 10);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new System.Drawing.Size(1287, 100);
            buttonsPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow_back;
            pictureBox1.Location = new System.Drawing.Point(10, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(26, 23);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cboJobsPicker
            // 
            cboJobsPicker.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboJobsPicker.FormattingEnabled = true;
            cboJobsPicker.Location = new System.Drawing.Point(980, 12);
            cboJobsPicker.Name = "cboJobsPicker";
            cboJobsPicker.Size = new System.Drawing.Size(294, 23);
            cboJobsPicker.TabIndex = 2;
            cboJobsPicker.SelectedIndexChanged += cboJobsPicker_SelectedIndexChanged;
            // 
            // btnInvertSelection
            // 
            btnInvertSelection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnInvertSelection.Location = new System.Drawing.Point(1169, 65);
            btnInvertSelection.Name = "btnInvertSelection";
            btnInvertSelection.Size = new System.Drawing.Size(106, 23);
            btnInvertSelection.TabIndex = 1;
            btnInvertSelection.Text = "Invert Selection";
            btnInvertSelection.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClearAll.Location = new System.Drawing.Point(1088, 65);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new System.Drawing.Size(75, 23);
            btnClearAll.TabIndex = 1;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelectAll.Location = new System.Drawing.Point(980, 65);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new System.Drawing.Size(102, 23);
            btnSelectAll.TabIndex = 1;
            btnSelectAll.Text = "Select All";
            btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveChanges.Location = new System.Drawing.Point(10, 12);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new System.Drawing.Size(126, 34);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // tsbLabels
            // 
            tsbLabels.BackColor = System.Drawing.Color.LightGray;
            tsbLabels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbLabels.Image = (System.Drawing.Image)resources.GetObject("tsbLabels.Image");
            tsbLabels.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbLabels.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            tsbLabels.Name = "tsbLabels";
            tsbLabels.Size = new System.Drawing.Size(89, 28);
            tsbLabels.Text = "Product Labels";
            tsbLabels.Click += tsbLabels_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1307, 704);
            Controls.Add(splconMain);
            Controls.Add(stsMainStatus);
            Controls.Add(buttonsPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Padding = new System.Windows.Forms.Padding(10);
            Text = "Knoodle Parametric";
            Activated += MainForm_Activated;
            Load += MainForm_Load;
            stsMainStatus.ResumeLayout(false);
            stsMainStatus.PerformLayout();
            splconMain.Panel1.ResumeLayout(false);
            splconMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splconMain).EndInit();
            splconMain.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tbpJobOrders.ResumeLayout(false);
            tbpDeliveries.ResumeLayout(false);
            spDeliveries.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spDeliveries).EndInit();
            spDeliveries.ResumeLayout(false);
            tabMainTabControl.ResumeLayout(false);
            tabInputTable.ResumeLayout(false);
            spcMainTabControl.Panel1.ResumeLayout(false);
            spcMainTabControl.Panel1.PerformLayout();
            spcMainTabControl.Panel2.ResumeLayout(false);
            spcMainTabControl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spcMainTabControl).EndInit();
            spcMainTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductGrid).EndInit();
            tsProductTools.ResumeLayout(false);
            tsProductTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSubAssemblies).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabInspector.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tbRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOutputGrid).EndInit();
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tsbLabels;
    }
}

