namespace KnoodleUX.UXControls
{
    partial class OptimizerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptimizerControl));
            this.tsOptimizeToolBar = new System.Windows.Forms.ToolStrip();
            this.tsRemoveFilter = new System.Windows.Forms.ToolStripButton();
            this.tscboPartIDFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOptimize = new System.Windows.Forms.ToolStripButton();
            this.theTextBoxStatus = new System.Windows.Forms.ToolStripTextBox();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgCutListGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbExitNextGreedyFit = new System.Windows.Forms.CheckBox();
            this.tsOptimizeToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCutListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsOptimizeToolBar
            // 
            this.tsOptimizeToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRemoveFilter,
            this.tscboPartIDFilter,
            this.toolStripSeparator1,
            this.tsbOptimize,
            this.theTextBoxStatus,
            this.tsProgressBar,
            this.tsStatusLabel,
            this.toolStripLabel1});
            this.tsOptimizeToolBar.Location = new System.Drawing.Point(10, 10);
            this.tsOptimizeToolBar.Name = "tsOptimizeToolBar";
            this.tsOptimizeToolBar.Padding = new System.Windows.Forms.Padding(0, 0, 1, 8);
            this.tsOptimizeToolBar.Size = new System.Drawing.Size(1121, 33);
            this.tsOptimizeToolBar.TabIndex = 1;
            this.tsOptimizeToolBar.Text = "toolStrip1";
            this.tsOptimizeToolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsOptimizeToolBar_ItemClicked);
            // 
            // tsRemoveFilter
            // 
            this.tsRemoveFilter.AutoSize = false;
            this.tsRemoveFilter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsRemoveFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRemoveFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsRemoveFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsRemoveFilter.Image")));
            this.tsRemoveFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemoveFilter.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsRemoveFilter.Name = "tsRemoveFilter";
            this.tsRemoveFilter.Size = new System.Drawing.Size(100, 22);
            this.tsRemoveFilter.Text = "Clear Filter";
            // 
            // tscboPartIDFilter
            // 
            this.tscboPartIDFilter.Margin = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.tscboPartIDFilter.Name = "tscboPartIDFilter";
            this.tscboPartIDFilter.Size = new System.Drawing.Size(100, 25);
            this.tscboPartIDFilter.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOptimize
            // 
            this.tsbOptimize.AutoSize = false;
            this.tsbOptimize.BackColor = System.Drawing.SystemColors.Highlight;
            this.tsbOptimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOptimize.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tsbOptimize.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptimize.Image")));
            this.tsbOptimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptimize.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tsbOptimize.Name = "tsbOptimize";
            this.tsbOptimize.Size = new System.Drawing.Size(75, 22);
            this.tsbOptimize.Text = "Optimize";
            // 
            // theTextBoxStatus
            // 
            this.theTextBoxStatus.Margin = new System.Windows.Forms.Padding(12, 0, 1, 0);
            this.theTextBoxStatus.Name = "theTextBoxStatus";
            this.theTextBoxStatus.Size = new System.Drawing.Size(70, 25);
            this.theTextBoxStatus.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsProgressBar.Margin = new System.Windows.Forms.Padding(1, 2, 6, 1);
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(160, 22);
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(39, 22);
            this.tsStatusLabel.Text = "Status";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Stock Size";
            // 
            // dgCutListGrid
            // 
            this.dgCutListGrid.AllowUserToAddRows = false;
            this.dgCutListGrid.AllowUserToDeleteRows = false;
            this.dgCutListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCutListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCutListGrid.Location = new System.Drawing.Point(10, 83);
            this.dgCutListGrid.Name = "dgCutListGrid";
            this.dgCutListGrid.ReadOnly = true;
            this.dgCutListGrid.RowTemplate.Height = 25;
            this.dgCutListGrid.Size = new System.Drawing.Size(1121, 414);
            this.dgCutListGrid.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbExitNextGreedyFit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 34);
            this.panel1.TabIndex = 3;
            // 
            // ckbExitNextGreedyFit
            // 
            this.ckbExitNextGreedyFit.AutoSize = true;
            this.ckbExitNextGreedyFit.Location = new System.Drawing.Point(15, 7);
            this.ckbExitNextGreedyFit.Name = "ckbExitNextGreedyFit";
            this.ckbExitNextGreedyFit.Size = new System.Drawing.Size(174, 19);
            this.ckbExitNextGreedyFit.TabIndex = 0;
            this.ckbExitNextGreedyFit.Text = "High Resolution Calculation";
            this.ckbExitNextGreedyFit.UseVisualStyleBackColor = true;
            // 
            // OptimizerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgCutListGrid);
            this.Controls.Add(this.tsOptimizeToolBar);
            this.Name = "OptimizerControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1141, 507);
            this.tsOptimizeToolBar.ResumeLayout(false);
            this.tsOptimizeToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCutListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsOptimizeToolBar;
        private System.Windows.Forms.ToolStripButton tsRemoveFilter;
        private System.Windows.Forms.ToolStripComboBox tscboPartIDFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbOptimize;
        private System.Windows.Forms.DataGridView dgCutListGrid;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.ToolStripTextBox theTextBoxStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel tsStatusLabel;
        private System.Windows.Forms.CheckBox ckbExitNextGreedyFit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
