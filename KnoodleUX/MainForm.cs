using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameWorks;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.DTO;
using ServiceLayer.Mappers;
using KnoodleUX.UXControls;
using CutlistEngine;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System.Collections.ObjectModel;
using FastReport;
using FastReport.Data;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using ServiceLayer.Service;
using Neodynamic.SDK.Printing;
using System.Xml.Linq;

namespace KnoodleUX
{
    public partial class MainForm : Form
    {
        //----Services-------------------------------
        private readonly MosaicContext ctx;
        ServiceLayer.ProductService _productService;
        JobService _jobService;
        PartsService partsService;
        //-------------------------------------------

        // Binds the event handler DrawOnTab to the DrawItem event 
        // through the DrawItemEventHandler delegate.

        Job _selectedJob;
        // This is the primary active object -----------------------------
        JobListDto _SelectedJobDTO;
        ProductDto _selectedProductDto = new ProductDto();
        SubAssemblyDTO _selectedSubAssemblyDTO = new SubAssemblyDTO();

        bool _loading = true;
        public static int _counter = 0;
        private List<ProductDto> _products;
        ProductMapper productMapper = new ProductMapper();
        JobMapper jobMapper = new JobMapper();

        BindingSource bsProducts = new BindingSource();
        BindingSource bsSubassemlies = new BindingSource();

        List<FrameWorks.AssemblyBase> internalUnits = new List<FrameWorks.AssemblyBase>();

        private Rectangle tabArea;
        private RectangleF tabTextArea;
        //--------------------------------------
        //----------------XXX-------------------
        //--------------------------------------
        Timer timerOpenCapture = new Timer();

        public MainForm()
        {
            InitializeComponent();
            ctx = new MosaicContext(Properties.Settings.Default.MosiacConnection);
            #region Serializer
            // XML Serielazer Code ------
            //ProductModel model = new ProductModel
            //{

            //    ProductID = 1467,
            //    ProductionDate = DateTime.Now,
            //    ArchDescription = "Window 12 | Her Closet Unit2",
            //    UnitID = 1,
            //    UnitName = "Test",
            //    W = 45.60m,
            //    D = 8.25m,
            //    H = 93.25m,
            //    Delivered = false,
            //    DeliveryDate = DateTime.Now,
            //    JobID = 487

            //};

            //StreamWriter tr = new StreamWriter(@"C:\temp\out.xml");
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductModel));
            //xmlSerializer.Serialize(tr, model);
            #endregion

            ThermalLabel.LicenseOwner = "Richard Young";
            ThermalLabel.LicenseKey = "RALJ9V89HNTFJMHZWRMH6MFP82AXAXDTX3ZXUESKXRFLXAZ346GQ";
            

            UIactions.BuildJobOrderListView(lvJobOrders);

            _productService = new ProductService(ctx);
            _jobService = new JobService(ctx);
            // ---------------set binding source to grids-------------
            dgProductGrid.DataSource = bsProducts;
            dgSubAssemblies.DataSource = bsSubassemlies;
            //--------------------Flesh out the Grids ----------------

            UIactions.BuildProductGrid(this.dgProductGrid);
            UIactions.BuildSubAssemblyGrid(dgSubAssemblies);
            // UIactions.BuildRecipeGrid(dgvRecipeGrid);
            dgSubAssemblies.CellClick += DgSubAssemblies_CellClick; ;

            //---------------------Wire Events------------------------

            bsProducts.AddingNew += BsProducts_AddingNew;
            bsProducts.ListChanged += BsProduct_ListChanged;
            bsSubassemlies.AddingNew += BsSubassemlies_AddingNew;
            bsSubassemlies.ListChanged += BsSubassemlies_ListChanged;

            lvJobOrders.MouseDoubleClick += LvJobOrders_MouseDoubleClick;
            tabMainTabControl.MouseClick += TabMainTabControl_MouseClick;
            //---------------------------------------------------------------------

            if (KnoodleUX.Properties.Settings.Default.LastSelectedJob != default)
            {
                _selectedJob = _jobService.GetDeepJob(KnoodleUX.Properties.Settings.Default.LastSelectedJob);
                // Populate the Product-Subassemlby graph ---
                LoadProducts(_selectedJob.jobID);
                KnoodleUX.Program.ActiveJob = _selectedJob;
                LoadJobOrders(_selectedJob.jobID);
                this.Text = $"Knoodle Parametric - Current Job = {_selectedJob.jobname} = {_selectedJob.jobID.ToString()}";

            }

            //---Load the Parts into memory as dictionary------------
            partsService = new PartsService(ctx);
            PartDictionary.PartLookup = partsService.PartItems();
            this.tsPartLoadedStatus.Text = $"{PartDictionary.PartLookup.Count} - Parts Loaded";
            //-------------------------------------------------------
            // Tune the TabControl Basic Parameters
            tabMainTabControl.SizeMode = TabSizeMode.Fixed;
            tabMainTabControl.ItemSize = new Size(110, 21);
            tabMainTabControl.Location = new Point(25, 25);
            tabArea = tabMainTabControl.GetTabRect(0);
            tabTextArea = (RectangleF)tabMainTabControl.GetTabRect(0);
            _loading = true;
            LoadJobPicker();


            cboJobsPicker.SelectedIndex = cboJobsPicker.FindString(_selectedJob.jobname.ToString());
        }

        private void DgSubAssemblies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dv = (DataGridView)sender;

            if (e.ColumnIndex == 3)
            {
                ClassNameFinder classNameFinder = new ClassNameFinder();
                if (classNameFinder.ShowDialog() == DialogResult.OK)
                {
                    ((SubAssemblyDTO)bsSubassemlies.Current).MakeFile = classNameFinder.SelectedClass;
                    dv.Refresh();
                }
            };
        }


        #region UI Handlers
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))

            {

                SaveJob();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }


        private void TabMainTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = tabControl.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = tabControl.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tabControl.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    tabControl.TabPages.Remove(tabPage);
                }
            }
        }

        private void LvJobOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = lvJobOrders.SelectedItems;
            int po = int.Parse(hit[0].Text);
            // PurchaseOrderControl poControl = new PurchaseOrderControl(ctx);
            //TabPage poPage = new TabPage(po.ToString());

            // poPage.Controls.Add(poControl);
            // tabMainTabControl.TabPages.Add(poPage);
            // tabMainTabControl.SelectedTab = poPage;
        }

        private void BsSubassemlies_ListChanged(object sender, ListChangedEventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            if (e.ListChangedType == ListChangedType.ItemChanged)
            { UIactions.CheckForDirtyState(e, this.btnSaveChanges); }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                { UIactions.CheckForDirtyState(e, this.btnSaveChanges); }
            }

        }

        private void BsSubassemlies_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (_selectedProductDto != null)
            {
                e.NewObject = new SubAssemblyDTO
                {
                    ProductID = _selectedProductDto.ProductID,
                    SubAssemblyName = "New Sub....",
                    W = decimal.Zero,
                    H = decimal.Zero,
                    D = decimal.Zero,

                };

            }
        }

        private void BsProduct_ListChanged(object sender, ListChangedEventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                UIactions.CheckForDirtyState(e, this.btnSaveChanges);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                UIactions.CheckForDirtyState(e, this.btnSaveChanges);

                bsProducts.EndEdit();

            }
        }

        private void BsProducts_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (_products.Any())
            {
                int w = _products.Max(d => d.UnitID);
                e.NewObject = new ProductDto
                {
                    JobID = _selectedJob.jobID,
                    ArchDescription = "New Product ....",
                    NIC = false,
                    Make = true,
                    W = decimal.Zero,
                    H = decimal.Zero,
                    D = decimal.Zero,
                    UnitID = w + 1
                };
            }
            else
            {
                e.NewObject = new ProductDto
                {
                    JobID = _selectedJob.jobID,
                    ArchDescription = "New Product ....",
                    NIC = false,
                    Make = true,
                    W = decimal.Zero,
                    H = decimal.Zero,
                    D = decimal.Zero,
                    UnitID = 1
                };
            }
        }

        private void LoadJobsList(ComboBox cbo)
        {

        }

        private void LoadJobPicker()
        {
            cboJobsPicker.DataSource = _jobService.RecentJobs();
            cboJobsPicker.DisplayMember = "JobName";
            cboJobsPicker.ValueMember = "JobID";
            _loading = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {



        }

        /// <summary>
        /// Save the Product Hyarchies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveJob();
        }

        private void SaveJob()
        {
            UIactions.IsDirty = false;
            UIactions.ToogleButtonStyle(UIactions.IsDirty, btnSaveChanges);

            _productService.AddOrUpdate(_SelectedJobDTO);
            LoadProducts(_selectedJob.jobID);
        }
        #region Grid Selectors

        private void dgProducts_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dv.DataSource, dv.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                    _selectedProductDto = (ProductDto)bm.Current;
                }
            }
        }
        #endregion

        private void LoadProducts(int jobID)
        {
            try
            {
                _selectedJob = _jobService.GetDeepJob(_selectedJob.jobID);
                _SelectedJobDTO = new JobListDto();
                jobMapper.Map(_selectedJob, _SelectedJobDTO);
                _products = _SelectedJobDTO.Products;

                bsProducts.DataSource = _products;
                //dgProductGrid.DataSource = bsProducts;
                // -- Prepare binding for child objects ---
                bsSubassemlies.DataSource = bsProducts;
                bsSubassemlies.DataMember = "SubAssemblies";
                dgSubAssemblies.DataSource = bsSubassemlies;

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void cboJobsPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loading)
            {
                ComboBox cb = (ComboBox)sender;
                if (cb.DataSource != null)
                {
                    int key = ((JobListDto)cb.SelectedItem).JobID;
                    _selectedJob = _jobService.GetDeepJob(key);

                    if (_selectedJob != null)
                    {
                        KnoodleUX.Properties.Settings.Default.LastSelectedJob = _selectedJob.jobID;
                        KnoodleUX.Properties.Settings.Default.Save();
                        LoadProducts(_selectedJob.jobID);
                        this.Text = $"{_SelectedJobDTO.JobID.ToString()} - {_selectedJob.jobname}";
                        // Load the Job Order in the Side-Bar
                        LoadJobOrders(_selectedJob.jobID);
                    }
                }
            }

        }

        private void dgProductGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
        private void MainForm_Activated(object sender, EventArgs e)
        {
            cboJobsPicker.SelectedIndex = cboJobsPicker.FindString(_selectedJob.jobname.ToString());
            _loading = false;
        }

        private void LoadJobOrders(int jobID)
        {
            lvJobOrders.Items.Clear();
            var result = _productService.JobOrders(_selectedJob.jobID);

            foreach (var item in result)
            {
                lvJobOrders.Items.Add(new ListViewItem(new string[] { item.PurchaseOrderID.ToString(), item.OrderDate, item.SupplierName }));
            }
        }

        private Point _imageLocation = new Point(24, 4);
        private Point _imgHitArea = new Point(12, 2);

        private void tabMainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tb = (TabControl)sender;
            Image img = new Bitmap(KnoodleUX.Properties.Resources._8kuxe);
            Rectangle r = e.Bounds;
            r = this.tabMainTabControl.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Font f = this.Font;
            string title = this.tabMainTabControl.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

            if (e.Index > 1)
            {
                e.Graphics.DrawImage(img, new Point(r.X + (this.tabMainTabControl.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
            }


        }

        private void tsProductTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsbAddProduct":
                    bsProducts.AddNew();


                    break;
                case "tsbDeleteProduct":

                    bsProducts.RemoveCurrent();
                    break;

                default:
                    break;
            }
        }
        // Build ----------------------------------------
        private void tsBuildProducts_Click(object sender, EventArgs e)
        {
            internalUnits.Clear();
            //loop through products list and build Product models
            foreach (var item in _products)
            {
                if (item.Make)
                {
                    Unit b = new Unit(item);

                    foreach (var sub in item.SubAssemblies)
                    {
                        SubAssemblyBase s = SubAssemblyBase.FactoryNew(sub);
                        b.AddSubAssembly(s);
                        s.Build();

                    }
                    //Populate list of processed Units
                    internalUnits.Add(b);
                }

            }

            DB.FillBuildTree(tvBuildTree, internalUnits);
        }

        private async void tsSaveOutput_Click(object sender, EventArgs e)
        {
            if (internalUnits.Count > 0)
            {
                // Spin up the File based MySqlite database base on the selected JobID ---
                using (CutlistEngine.CutlistDBContext ctx = await DBFactory.GetDbContext(_selectedJob.jobID.ToString()))
                {
                    // Clear the DB
                    await ctx.Database.ExecuteSqlRawAsync("DELETE FROM CutListProducts");
                    // or just delete the file --

                    foreach (var pd in internalUnits)
                    {
                        foreach (var sub in pd.SubAssemblies)
                        {
                            _counter = 0;
                            foreach (var prt in sub.ComponentParts)
                            {
                                CutListProduct cut = new CutListProduct
                                {
                                    PartGroupTypeClass = prt.ComponentGroupType,
                                    Markup = prt.MarkUp,
                                    PartID = prt.Source.PartID,
                                    SubAssemblyName = sub.Name,
                                    SubAssemblyArea = sub.Area,
                                    SubAssemblyWidth = sub.SubAssemblyWidth,
                                    SubAssemblyHieght = sub.SubAssemblyHieght,
                                    PartSourceDescription = prt.Source.MaterialDescription,
                                    SubAssemblyID = sub.SubAssemblyID,
                                    ProductID = sub.ProductID,
                                    ProductArea = pd.Area,
                                    ProductName = sub.Parent.UnitName,
                                    ProductWidth = sub.Parent.UnitWidth,
                                    ProductHeight = sub.Parent.UnitHeight,
                                    JobId = _selectedJob.jobID,
                                    Jobname = _selectedJob.jobname,
                                    FunctionalPartCost = prt.CalculatedCost,
                                    FunctionName = prt.FunctionalName,
                                    PartIdentifier = pd.ProductID.ToString() + "." + sub.SubAssemblyID.ToString() + "." + _counter++.ToString(),
                                    UnitCost = prt.UnitPrice,
                                    Qnty = prt.Qnty,
                                    W = prt.ComponentWidth,
                                    L = prt.ComponentLength,
                                    T = prt.ComponentThick,
                                    UnitOfMeasure = prt.UnitOfMeasureName,
                                    Tax = prt.CalculatedCost * 0.78m,
                                    Waste = prt.CalculatedCost * prt.Waste

                                };

                                ctx.CutListProducts.Add(cut);
                            }

                        }

                    }
                    await ctx.SaveChangesAsync();
                }
            }
        }

        private void tvBuildTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string sel = e.Node.Tag.GetType().BaseType.ToString();


            switch (sel)
            {
                case "FrameWorks.SubAssemblyBase":
                    {
                        FrameWorks.SubAssemblyBase selectedPart = (FrameWorks.SubAssemblyBase)e.Node.Tag;
                        this.partPropertyGrid.SelectedObject = selectedPart;
                        break;
                    }
                case "FrameWorks.AssemblyBase":
                    {
                        FrameWorks.AssemblyBase selectedPart = (FrameWorks.AssemblyBase)e.Node.Tag;
                        this.partPropertyGrid.SelectedObject = selectedPart;
                        break;
                    }
                case "System.Object":
                    {

                        FrameWorks.ComponentPart selectedPart = (FrameWorks.ComponentPart)e.Node.Tag;
                        this.partPropertyGrid.SelectedObject = selectedPart;
                        break;
                    }
                case "FrameWorks.ComponentPart":
                    {

                        FrameWorks.ComponentPart selectedPart = (FrameWorks.ComponentPart)e.Node.Tag;
                        this.partPropertyGrid.SelectedObject = selectedPart;
                        break;
                    }



                default:
                    break;
            }


        }
        // Condense the output parts and display 
        private async void tsShowRecipe_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT SUM(Qnty), Round(SUM(Length), 2) AS [Total Length], UnitCost, UnitOfMeasure, PartSourceDescription, ProductID, SUm(Qnty) * UnitCost AS Price FROM CutlistProducts GROUP BY PartID, UnitCost";
            string sql = "Select * FROM CutListProducts";

            using (CutlistEngine.CutlistDBContext ctx = await DBFactory.GetDbContext(_selectedJob.jobID.ToString()))
            {

                List<CutListProduct> crud = ctx.CutListProducts.ToList();
                dgvOutputGrid.DataSource = crud;
                tabMainTabControl.SelectedTab = tabMainTabControl.TabPages[2];

            }
        }

        private async Task<IEnumerable<CutListProduct>> GetJobCutlistItems()
        {
            //string sql = "SELECT SUM(Qnty), Round(SUM(Length), 2) AS [Total Length], UnitCost, UnitOfMeasure, PartSourceDescription, ProductID, SUm(Qnty) * UnitCost AS Price FROM CutlistProducts GROUP BY PartID, UnitCost";
            string sql = "Select * FROM CutListProducts";

            using (CutlistEngine.CutlistDBContext ctx = await DBFactory.GetDbContext(_selectedJob.jobID.ToString()))
            {
                return ctx.CutListProducts.ToList();
            }
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            FastReport.Report report = new FastReport.Report();
            FastReport.Data.SQLiteDataConnection reportConnection = new FastReport.Data.SQLiteDataConnection();
            string jobid = _selectedJob.jobID.ToString();
            reportConnection.ConnectionString = $"datasource = C:\\DB\\{jobid}.db";

            report.Load($"{Application.StartupPath}/JobAnalysis.frx");
            report.Dictionary.Connections[0].ConnectionString = reportConnection.ConnectionString;

            report.Show();
        }

        private void stbPartListReport_Click(object sender, EventArgs e)
        {
            FastReport.Report report = new FastReport.Report();
            FastReport.Data.SQLiteDataConnection reportConnection = new FastReport.Data.SQLiteDataConnection();
            string jobid = _selectedJob.jobID.ToString();
            reportConnection.ConnectionString = $"datasource = C:\\DB\\{jobid}.db";


            report.Load($"{Application.StartupPath}/PartList.frx");
            report.Dictionary.Connections[0].ConnectionString = reportConnection.ConnectionString;

            report.Show();
        }

        private async void tsbOptimize_Click(object sender, EventArgs e)
        {

            TabPage tabOptimizer = new TabPage("Optimizer");
            OptimizerControl control = new OptimizerControl(await GetJobCutlistItems(), _selectedJob);
            tabOptimizer.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            tabMainTabControl.TabPages.Add(tabOptimizer);
            tabMainTabControl.SelectedTab = tabOptimizer;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (splconMain.Panel1Collapsed == false)
            {
                splconMain.Panel1Collapsed = true;
                pictureBox1.Image = KnoodleUX.Properties.Resources.arrow_forward;
                pictureBox1.BackColor = System.Drawing.Color.LightGray;
            }
            else if (splconMain.Panel1Collapsed == true)
            {
                splconMain.Panel1Collapsed = false;

                pictureBox1.Image = KnoodleUX.Properties.Resources.arrow_back;
                pictureBox1.BackColor = System.Drawing.Color.LightBlue;

            }

        }
        /// <summary>
        /// Print Product Labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbLabels_Click(object sender, EventArgs e)
        {
            ThermalLabel.LicenseOwner = "Richard Young-Ultimate Edition-Developer License";
            ThermalLabel.LicenseKey = "RALJ9V89HNTFJMHZWRMH6MFP82AXAXDTX3ZXUESKXRFLXAZ346GQ";
            int PiD;
            bool printAsImage = false;

            foreach (DataGridViewRow row in dgProductGrid.SelectedRows)
            {

                PiD = ((ProductDto)row.DataBoundItem).ProductID;
                System.IO.File.WriteAllText(@"C:\temp\OUT.xml", LabelService.ProductLabelData(PiD));
                var ds = new DataSet();
                ds.ReadXml(@"C:\Temp\OUT.xml");

                ThermalLabel label = LabelService.GenerateProductLabel(ds);
                label.DataSource = ds;
                PrinterSettings XmlData;

                var fileName = Path.Combine(Environment.GetFolderPath(
                                  Environment.SpecialFolder.ApplicationData), "GK420t.xml");
                // if the settings file doesn't exist-re-create them
                if (!File.Exists(fileName))
                {
                    //Display Print Job dialog...           
                    PrintJobDialog frmPrintJob = new PrintJobDialog();
                    if (frmPrintJob.ShowDialog() == DialogResult.OK)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(PrinterSettings));
                        using (TextWriter writer = new StreamWriter(fileName))
                        {
                            serializer.Serialize(writer, frmPrintJob.PrinterSettings);
                        }
                    }
                }

                //Pull the settings from XML file --
                XmlSerializer deserializer = new XmlSerializer(typeof(PrinterSettings));
                TextReader reader = new StreamReader(fileName);
                object obj = deserializer.Deserialize(reader);
                XmlData = (PrinterSettings)obj;
                reader.Close();

                if (printAsImage)
                { 
                    using (PrintJob pj = new PrintJob())
                    {
                        pj.Copies = 1; // set copies
                        pj.PrintOrientation = PrintOrientation.Portrait; //set orientation
                        pj.ThermalLabel = label;
                        pj.ExportToImage(label, @"C\:temp\image.jpg", new ImageSettings(ImageFormat.Jpeg), 300);
                    }
                }
                if (!printAsImage)
                {
                    using (WindowsPrintJob pj = new WindowsPrintJob(XmlData))
                    {
                        pj.Copies = 1; // set copies
                        pj.PrintOrientation = PrintOrientation.Portrait; //set orientation
                        pj.ThermalLabel = label;
                        pj.PrintAsGraphic(label);
                    }
                }
            }

        }       
    }

}
