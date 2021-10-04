
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
            this.splconMain = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpJobOrders = new System.Windows.Forms.TabPage();
            this.tbpDeliveries = new System.Windows.Forms.TabPage();
            this.tabMainTabControl = new System.Windows.Forms.TabControl();
            this.tabInputTable = new System.Windows.Forms.TabPage();
            this.spcMainTabControl = new System.Windows.Forms.SplitContainer();
            this.dgProductGrid = new System.Windows.Forms.DataGridView();
            this.tsProductTools = new System.Windows.Forms.ToolStrip();
            this.tsBuildProducts = new System.Windows.Forms.ToolStripButton();
            this.tsSaveOutput = new System.Windows.Forms.ToolStripButton();
            this.dgSubAssemblies = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSubAssemblyLabel = new System.Windows.Forms.ToolStripLabel();
            this.tabInspector = new System.Windows.Forms.TabPage();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cboJobsPicker = new System.Windows.Forms.ComboBox();
            this.btnInvertSelection = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splconMain)).BeginInit();
            this.splconMain.Panel1.SuspendLayout();
            this.splconMain.Panel2.SuspendLayout();
            this.splconMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsMainStatus
            // 
            this.stsMainStatus.Location = new System.Drawing.Point(10, 726);
            this.stsMainStatus.Name = "stsMainStatus";
            this.stsMainStatus.Size = new System.Drawing.Size(1134, 22);
            this.stsMainStatus.TabIndex = 1;
            this.stsMainStatus.Text = "statusStrip1";
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
            this.splconMain.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splconMain.Panel2
            // 
            this.splconMain.Panel2.Controls.Add(this.tabMainTabControl);
            this.splconMain.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splconMain.Size = new System.Drawing.Size(1134, 616);
            this.splconMain.SplitterDistance = 305;
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
            this.tabControl1.Size = new System.Drawing.Size(293, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpJobOrders
            // 
            this.tbpJobOrders.Location = new System.Drawing.Point(4, 24);
            this.tbpJobOrders.Name = "tbpJobOrders";
            this.tbpJobOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tbpJobOrders.Size = new System.Drawing.Size(285, 576);
            this.tbpJobOrders.TabIndex = 0;
            this.tbpJobOrders.Text = "Job Orders";
            this.tbpJobOrders.UseVisualStyleBackColor = true;
            // 
            // tbpDeliveries
            // 
            this.tbpDeliveries.Location = new System.Drawing.Point(4, 24);
            this.tbpDeliveries.Name = "tbpDeliveries";
            this.tbpDeliveries.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeliveries.Size = new System.Drawing.Size(285, 576);
            this.tbpDeliveries.TabIndex = 1;
            this.tbpDeliveries.Text = "Deliveries";
            this.tbpDeliveries.UseVisualStyleBackColor = true;
            // 
            // tabMainTabControl
            // 
            this.tabMainTabControl.Controls.Add(this.tabInputTable);
            this.tabMainTabControl.Controls.Add(this.tabInspector);
            this.tabMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainTabControl.Location = new System.Drawing.Point(6, 6);
            this.tabMainTabControl.Name = "tabMainTabControl";
            this.tabMainTabControl.SelectedIndex = 0;
            this.tabMainTabControl.Size = new System.Drawing.Size(813, 604);
            this.tabMainTabControl.TabIndex = 0;
            // 
            // tabInputTable
            // 
            this.tabInputTable.Controls.Add(this.spcMainTabControl);
            this.tabInputTable.Location = new System.Drawing.Point(4, 24);
            this.tabInputTable.Name = "tabInputTable";
            this.tabInputTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabInputTable.Size = new System.Drawing.Size(805, 576);
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
            this.spcMainTabControl.Size = new System.Drawing.Size(799, 570);
            this.spcMainTabControl.SplitterDistance = 340;
            this.spcMainTabControl.TabIndex = 0;
            // 
            // dgProductGrid
            // 
            this.dgProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductGrid.Location = new System.Drawing.Point(0, 28);
            this.dgProductGrid.Name = "dgProductGrid";
            this.dgProductGrid.RowTemplate.Height = 25;
            this.dgProductGrid.Size = new System.Drawing.Size(799, 312);
            this.dgProductGrid.TabIndex = 0;
            this.dgProductGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductGrid_CellContentClick);
            this.dgProductGrid.SelectionChanged += new System.EventHandler(this.dgProducts_SelectionChanged);
            // 
            // tsProductTools
            // 
            this.tsProductTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBuildProducts,
            this.tsSaveOutput});
            this.tsProductTools.Location = new System.Drawing.Point(0, 0);
            this.tsProductTools.Name = "tsProductTools";
            this.tsProductTools.Padding = new System.Windows.Forms.Padding(3);
            this.tsProductTools.Size = new System.Drawing.Size(799, 28);
            this.tsProductTools.TabIndex = 1;
            this.tsProductTools.Text = "toolStrip1";
            // 
            // tsBuildProducts
            // 
            this.tsBuildProducts.BackColor = System.Drawing.Color.Gainsboro;
            this.tsBuildProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBuildProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsBuildProducts.Image")));
            this.tsBuildProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuildProducts.Name = "tsBuildProducts";
            this.tsBuildProducts.Size = new System.Drawing.Size(100, 19);
            this.tsBuildProducts.Text = "Build Assemblies";
            // 
            // tsSaveOutput
            // 
            this.tsSaveOutput.BackColor = System.Drawing.Color.Moccasin;
            this.tsSaveOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSaveOutput.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveOutput.Image")));
            this.tsSaveOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveOutput.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsSaveOutput.Name = "tsSaveOutput";
            this.tsSaveOutput.Size = new System.Drawing.Size(76, 19);
            this.tsSaveOutput.Text = "Save Output";
            // 
            // dgSubAssemblies
            // 
            this.dgSubAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSubAssemblies.Location = new System.Drawing.Point(0, 25);
            this.dgSubAssemblies.Name = "dgSubAssemblies";
            this.dgSubAssemblies.RowTemplate.Height = 25;
            this.dgSubAssemblies.Size = new System.Drawing.Size(799, 201);
            this.dgSubAssemblies.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSubAssemblyLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
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
            this.tabInspector.Location = new System.Drawing.Point(4, 24);
            this.tabInspector.Name = "tabInspector";
            this.tabInspector.Padding = new System.Windows.Forms.Padding(3);
            this.tabInspector.Size = new System.Drawing.Size(805, 576);
            this.tabInspector.TabIndex = 1;
            this.tabInspector.Text = "Inspector";
            this.tabInspector.UseVisualStyleBackColor = true;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cboJobsPicker);
            this.buttonsPanel.Controls.Add(this.btnInvertSelection);
            this.buttonsPanel.Controls.Add(this.btnClearAll);
            this.buttonsPanel.Controls.Add(this.btnSelectAll);
            this.buttonsPanel.Controls.Add(this.btnSaveChanges);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel.Location = new System.Drawing.Point(10, 10);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1134, 100);
            this.buttonsPanel.TabIndex = 3;
            // 
            // cboJobsPicker
            // 
            this.cboJobsPicker.FormattingEnabled = true;
            this.cboJobsPicker.Location = new System.Drawing.Point(317, 19);
            this.cboJobsPicker.Name = "cboJobsPicker";
            this.cboJobsPicker.Size = new System.Drawing.Size(297, 23);
            this.cboJobsPicker.TabIndex = 2;
            this.cboJobsPicker.SelectedIndexChanged += new System.EventHandler(this.cboJobsPicker_SelectedIndexChanged);
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvertSelection.Location = new System.Drawing.Point(1016, 65);
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.Size = new System.Drawing.Size(106, 23);
            this.btnInvertSelection.TabIndex = 1;
            this.btnInvertSelection.Text = "Invert Selection";
            this.btnInvertSelection.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Location = new System.Drawing.Point(935, 65);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Location = new System.Drawing.Point(827, 65);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(102, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Location = new System.Drawing.Point(12, 12);
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
            this.ClientSize = new System.Drawing.Size(1154, 758);
            this.Controls.Add(this.splconMain);
            this.Controls.Add(this.stsMainStatus);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Knoodle Parametric";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splconMain.Panel1.ResumeLayout(false);
            this.splconMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splconMain)).EndInit();
            this.splconMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
            this.buttonsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSaveChanges;
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
    }
}

