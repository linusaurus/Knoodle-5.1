using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FrameWorks;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Mappers;


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

        Job _selectedJob;
        // This is the primary active object
        JobListDto _SelectedJobDTO;
        ProductDto _selectedProductDto;
        bool _loading = true;
        private List<ProductDto> _products;
        ProductMapper productMapper = new ProductMapper();
        JobMapper jobMapper = new JobMapper();

        BindingSource bsProducts = new BindingSource();
        BindingSource bsSubassemlies = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            ctx = new MosaicContext();
            _productService = new ProductService(ctx);
            _jobService = new JobService(ctx);

            dgProductGrid.DataSource = bsProducts;
            dgSubAssemblies.DataSource = bsSubassemlies;

            bsProducts = new BindingSource();
            UIactions.BuildProductGrid(this.dgProductGrid);
            UIactions.BuildProductGrid(dgSubAssemblies);

            //---------------------Wire Events------------------------

            bsProducts.AddingNew += BsProducts_AddingNew;
            bsProducts.ListChanged += BsProducts_ListChanged;
            bsSubassemlies.AddingNew += BsSubassemlies_AddingNew;

            if (KnoodleUX.Properties.Settings.Default.LastSelectedJob != default)
            {
                _selectedJob = _jobService.GetDeepJob(KnoodleUX.Properties.Settings.Default.LastSelectedJob);
                LoadProducts(_selectedJob.jobID);
                this.Text = "Current Job " +  _selectedJob.jobID.ToString();
            }

            // Load the Parts into memory as dictionary--
            partsService = new PartsService();
            //partsService.LoadParts();
            //foreach (var p in partsService.Parts)
            //{
            //    SourceMaterial mat = new SourceMaterial() { ItemID = p.Key };
            //    mat.ItemID = p.Key;
            //    mat.MarkUp = p.Value.MarkUp.GetValueOrDefault();
            //    mat.MaterialDescription = p.Value.ItemDescription;
            //    mat.MaterialName = p.Value.ItemName;
            //    mat.UOM = p.Value.UnitOfMeasureID.GetValueOrDefault();
            //    mat.Waste = p.Value.Waste.GetValueOrDefault();
            //    mat.Weight = p.Value.Weight.GetValueOrDefault();

            //    PartDictionary.PartSource.Add(mat.ItemID, mat);
            //}

            //bsProducts.DataSource = _productService.GetProducts(1308);
            ////bsProduct.DataSource = _ctx.Products.ToList();
            //bsProducts.ListChanged += BsProduct_ListChanged;
            //this.dgProducts.DataSource = bsProducts;

        }

        private void BsSubassemlies_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (_selectedProductDto != null)
            {
                e.NewObject = new SubAssemblyDTO
                {
                    ProductID = 0,
                    SubAssemblyName = "New Subassembly....",
                    W = decimal.Zero,
                    H = decimal.Zero,
                    D = decimal.Zero,
                    d = decimal.Zero
                };
            }
        }

        private void BsProducts_ListChanged(object sender, ListChangedEventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                // ISDirty set ot true;


                // ctx.SaveChanges();
            };
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboJobsPicker.DataSource = _jobService.RecentJobs();
            cboJobsPicker.DisplayMember = "JobName";
            cboJobsPicker.ValueMember = "JobID";

            cboJobsPicker.SelectedValue = _SelectedJobDTO.JobID;
        }

        private void BsProduct_ListChanged(object sender, ListChangedEventArgs e)
        { UIactions.CheckForDirtyState(e, this.btnSaveChanges);
        }
           

       
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UIactions.IsDirty = false;
            UIactions.ToogleButtonStyle(UIactions.IsDirty, btnSaveChanges);         
        }

        private void dgProducts_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dv.DataSource, dv.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                   // _selectedProductDTO = (ProductDto)bm.Current;
                   // dgSubAssemblies.DataSource = _selectedProductDTO.SubAssemblies.ToList();
                }
            }
        }

        private void LoadProducts(int jobID)
        {
            try
            {
                _selectedJob = _jobService.GetDeepJob(_selectedJob.jobID);
                _SelectedJobDTO = new JobListDto();
                jobMapper.Map(_selectedJob, _SelectedJobDTO);
                _products = _SelectedJobDTO.Products;
                bsProducts.DataSource = _products;
                dgProductGrid.DataSource = bsProducts;
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
                        this.Text = _SelectedJobDTO.JobID.ToString();
                    }
                }
            }
        }
    }
}
