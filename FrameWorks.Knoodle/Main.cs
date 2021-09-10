﻿#region Copyright (c) 2021 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2014 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FrameWorks;
using System.Linq;

namespace Weaselware.Knoodle
{
    public partial class Main : Form
    {
           
        //----Services-------------------------------
        private readonly ProductionContext ctx;
        ProductService _unitsService;
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
        
        

        public Main()
        {
            InitializeComponent();
            dgProductGrid.AutoGenerateColumns = false;
            dgSubAssemblies.AutoGenerateColumns = false;
            ctx = new ProductionContext();
            _unitsService  = new ProductService(ctx);
            _jobService = new JobService(ctx);

            dgProductGrid.DataSource = bsProducts;
            dgSubAssemblies.DataSource = bsSubassemlies;
            // ----------------Wire Events------------------
            this.Activated += Main_Activated;
            bsProducts.AddingNew += BsProducts_AddingNew;
            bsProducts.ListChanged += BsProducts_ListChanged;

            bsSubassemlies.AddingNew += BsSubassemlies_AddingNew;
            if (Knoodle.Properties.Settings.Default.LastSelectedJob != default)
            {
                _selectedJob = _jobService.GetDeepJob(Knoodle.Properties.Settings.Default.LastSelectedJob);
                LoadProducts(_selectedJob.JobID);
                this.label3.Text = _selectedJob.JobID.ToString();
            }
           
            // Load the Parts into memory as dictionary--
            partsService = new PartsService();
            partsService.LoadParts();
            foreach (var p in partsService.Parts)
            {
                SourceMaterial mat = new SourceMaterial() {ItemID=p.Key };
                mat.ItemID = p.Key;
                mat.MarkUp = p.Value.MarkUp.GetValueOrDefault();
                mat.MaterialDescription = p.Value.ItemDescription;
                mat.MaterialName = p.Value.ItemName;
                mat.SupplierID = p.Value.SupplierID.GetValueOrDefault();
                mat.UOM = p.Value.UID.GetValueOrDefault();
                mat.Waste = p.Value.Waste.GetValueOrDefault();
                mat.Weight = p.Value.Weight.GetValueOrDefault();
               
                PartDictionary.PartSource.Add(mat.ItemID, mat);
            }

           
            int k = PartDictionary.PartSource.Count();
            this.toolStripStatusLabel1.Text = String.Format("Parts Loaded : {0}",k.ToString());

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

        private void Main_Activated(object sender, EventArgs e)
        {
          
        }

        private void BsProducts_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (_products.Any())
            {
                int w = _products.Max(d => d.UnitID);
                e.NewObject = new ProductDto
                {
                    JobID = _selectedJob.JobID,
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
                    JobID = _selectedJob.JobID,
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

        private void Form1_Load(object sender, EventArgs e)
        {          
            cbxJobsList.DataSource = _jobService.RecentJobs();
            cbxJobsList.DisplayMember = "JobName";
            cbxJobsList.ValueMember = "JobID";
            
            cbxJobsList.SelectedValue = _SelectedJobDTO.JobID;
           
        }

        private void cbxJobsList_SelectedIndexChanged(object sender, EventArgs e)
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
                       Knoodle.Properties.Settings.Default.LastSelectedJob = _selectedJob.JobID;
                       Knoodle.Properties.Settings.Default.Save();
                       LoadProducts(_selectedJob.JobID);
                       label3.Text = _SelectedJobDTO.JobID.ToString();
                    }              
                }
             }
        }

        private void dgProductGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProductGrid.DataSource != null)
            {
                if (dgProductGrid.SelectedRows.Count > 0)
                {
                    _selectedProductDto = (ProductDto)dgProductGrid.CurrentRow.DataBoundItem;
                    if (_selectedProductDto != null)
                    {
                       
                        bsSubassemlies.DataSource = _selectedProductDto.SubAssemblies;
                        dgSubAssemblies.DataSource = bsSubassemlies;
                    }

                }
            }
        }

        private void LoadProducts(int jobID)
        {                                       
            try
            {
                _selectedJob = _jobService.GetDeepJob(_selectedJob.JobID);
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
        // Save the DTO
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {


            _unitsService.AddOrUpdate(_products);
            ctx.SaveChanges();
            LoadProducts(_selectedJob.JobID);
        }

        /// <summary>
        /// Build BOM Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuild_Click(object sender, EventArgs e)
        {
            // Implement the loop to proccess the job-products list
            foreach (var productDTO in _products)
            {
                //productDTO.ArchDescription;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

  

        private void buildTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
                //string sel = e.Node.Tag.GetType().BaseType.ToString() ;
               

                //switch (sel)
                //{
                //    case "FrameWorks.SubAssemblyBase":
                //        {
                //            FrameWorks.SubAssemblyBase selectedPart = (FrameWorks.SubAssemblyBase)e.Node.Tag;
                //            this.partPropertyGrid.SelectedObject = selectedPart;
                //            break;
                //        }
                //    case "FrameWorks.AssemblyBase":
                //       {
                //           FrameWorks.AssemblyBase selectedPart = (FrameWorks.AssemblyBase)e.Node.Tag;
                //           this.partPropertyGrid.SelectedObject = selectedPart;
                //            break;
                //       }
                //   case "System.Object":
                //        {
                          
                //            FrameWorks.Part selectedPart = (FrameWorks.Part)e.Node.Tag;
                //            this.partPropertyGrid.SelectedObject = selectedPart;
                //            break;
                //        }
                //    case "FrameWorks.Part":
                //        {

                //            FrameWorks.LPart selectedPart = (FrameWorks.LPart)e.Node.Tag;
                //            this.partPropertyGrid.SelectedObject = selectedPart;
                //            break;
                //        }
                   

                        
                //   default:
                //        break;
                //}


        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            ////if (buildUnits != null &&  buildUnits.Count > 0)
            ////{
            //   // this.dataGridView3.DataSource = Db.Write(buildUnits);
            //    BusinessObjects.OutputCollection colOutParts = new BusinessObjects.OutputCollection();
            //    BusinessObjects.OutputQuery qry = new BusinessObjects.OutputQuery();
            //    colOutParts.LoadAll();
            //    this.dataGridView3.DataSource = colOutParts;
            //    col = colOutParts;
            ////}
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //this.toolStripProgressBar1.Value = 0;
            //worker = new BackgroundWorker();
            //worker.WorkerReportsProgress = true;
            //worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            //worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            //worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            //worker.RunWorkerAsync();
        }


        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.toolStripStatusLabel2.Text = "Write Completed!";
            //this.toolStripProgressBar1.Value = 100;
        }


        //void ansynWrite_Completed(object sender, Db.WriteUnitsCompletedEventArgs e)
        //{
        //    BusinessObjects.OutputCollection col = new BusinessObjects.OutputCollection();
        //col = e.OutPut;
        //    this.dataGridView3.DataSource = col;
        //    MessageBox.Show("Done :" + e.OutPut.Count.ToString() + " Units Completed");
        //}

        private void partPropertyGrid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ClassNameFinder classFinder = new ClassNameFinder();
                if (classFinder.ShowDialog() == DialogResult.OK)
                {
                    dgSubAssemblies.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = classFinder.SelectedClass;
                }

            }
        }
   
        private void buildTree_DoubleClick(object sender, EventArgs e)
        {

            //if (buildTree.SelectedNode.Tag.GetType().BaseType.ToString() =="FrameWorks.SubAssemblyBase")
            //{
            //    FrameWorks.SubAssemblyBase selected = (FrameWorks.SubAssemblyBase)buildTree.SelectedNode.Tag;
            //    PartEditor pedit = new PartEditor(selected);
            //    pedit.Show();
                
            //}
           
        }

      
        private void PartsStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// File Menu Actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //string pick = e.ClickedItem.Name;
            //switch (pick)
            //{
            //    case "tsmsaveFile":
            //        {
            //            bs.EndEdit();
            //            this.incomingUnits.Save();
            //            break;
            //        }
            //    case "tsmsaveAs":
            //        {
            //            break;
            //        }
            //    case "tsmNewDataFile":
            //        {
            //            break;
            //        }
            //    case "tsmExit":
            //        {
            //            if (((BusinessObjects.UnitCollection)bs.DataSource).IsDirty)
            //            {
            //                if (MessageBox.Show("Save Changes to Database?",
            //                    "Save",
            //                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            //                { 
            //                    bs.EndEdit();
            //                   this.incomingUnits.Save();
            //                   Application.Exit();
            //                }
            //                else { Application.Exit() ; }
            //            }
            //            else
            //            {
            //                Application.Exit();
            //            }
            //            break;
            //        }
            //    default:
            //        break;
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (((BusinessObjects.UnitCollection)bs.DataSource).IsDirty)
            //{
            //    if (MessageBox.Show("Save Changes to Database?",
            //        "Save",MessageBoxButtons.OKCancel)== DialogResult.OK)
            //        {
            //        bs.EndEdit();
            //        this.incomingUnits.Save();
            //        Application.Exit();

            //        }
            //    else { Application.Exit(); }
            //}

        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            //col = new BusinessObjects.OutputCollection();
           
            //string filter = tbOptimizerFilter.Text.Trim();
            //sumOfItems = float.Parse("0.0");
            //int partID;

            //if (int.TryParse(filter, out partID))
            //{
            //    BusinessObjects.OutputQuery qry = new BusinessObjects.OutputQuery();
            //    qry.Select(qry.CutlistID,qry.Qnty, qry.Length, qry.SourceDescription,qry.PartIdentifier);
            //    qry.Where(qry.PartID == partID);
               
            //    col.Load(qry);
            //    this.dgOptimizerItems.DataSource = col;
            //}
            //foreach (BusinessObjects.Output o in col)
            //{
            //    if (o.Length.HasValue) { sumOfItems += (float)o.Length.Value;  }
            //}
            //float totalFeet = sumOfItems / 12.0f ;
            //lbSumofParts.Text = totalFeet.ToString() + " ft";
            ////col = Db.OutParts();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            
            // //public CuttingStock(List<Stock> theStocks, List<Item> theItems,
            // //               float theTotalItemsSum, ToolStripLabel theTextBoxStatus,
            // //               ToolStripProgressBar theToolStripProgressBar, CheckBox theExitGreedyNextFit)
            //string materialName = string.Empty;
            //if (!string.IsNullOrEmpty(tbOptimizerFilter.Text) )
            //{
            //    int k = int.Parse(tbOptimizerFilter.Text.ToString());
            //   materialName = k.ToString() + " - " +  FrameWorks.SourceManager.PartsSource[k].MaterialDescription;
                
            // }
            
            //List<BinPackingCuttingStock.Item> theItems = new List<Item>();
            //List<BinPackingCuttingStock.Stock> Stocks = new List<Stock>();
            //BinPackingCuttingStock.Stock stock = new Stock();
            //stock.ConsiderMaxPieces = false;
            //stock.Cost = 20.00f;
            //stock.MaxPieces = 0;
            //stock.Size = float.Parse(tbStockLength.Text);
            //stock.MaterialDescription = materialName;
            //Stocks.Add(stock);

            //if (col.HasData && col.Count > 0)
            //{
            //    foreach (BusinessObjects.Output outp in col)
            //    {
            //        BinPackingCuttingStock.Item i = new Item();
            //        i.Pieces =(uint) outp.Qnty.Value;
            //        i.Size = (float)outp.Length.Value;
            //        i.BarCode = outp.PartIdentifier;
            //        theItems.Add(i);
            //    }
            //}
                   

            //BinPackingCuttingStock.CuttingStock s = new CuttingStock(Stocks, theItems, sumOfItems, theTextBoxStatus, theToolStripProgressBar, theExitGreedyNextFit);
            //s.Solve();
        }

        private void tabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgProductGrid.Rows)
            {
                row.Cells[7].Value = false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgProductGrid.Rows)
            {
                row.Cells[7].Value = true;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgProductGrid.Rows)
            {
                //Check for null value at cell 6
                if (row.Cells[7].Value != null)
                {

                    if (row.Cells[7].Value.Equals(true))
                    { row.Cells[7].Value = false; }
                    else { row.Cells[7].Value = true; }
                }
            }
        }

        private void unitsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void Main_Shown(object sender, EventArgs e)
        {
            _loading = false;
        }

        #region Tool Bar Actions


        private void MainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsSave":

                    _unitsService.AddOrUpdate(_products);
                    ctx.SaveChanges();
                    LoadProducts(_selectedJob.JobID);

                    break;
                    
                default:
                    break;
            }
        }

        #endregion
        /// <summary>
        /// Build the Products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuild_Click_1(object sender, EventArgs e)
        {
            //Process and Bind the Products in the Inspector
            BindTree( BuildEngine.BuildProducts(_products.Where(m => m.Make == true).ToList()));
         
        }

        private void BindTree(List<ProductDto> products)
        {
            TreeNode rootNode = new TreeNode(_selectedJob.jobname);
            buildTree.Nodes.Add(rootNode);

            foreach (var prd in products)
             {
                TreeNode productNode = new TreeNode(String.Format("{0}-{1}",prd.ProductID,prd.UnitName));
                productNode.Tag = prd;
               

                foreach (var sub in prd.SubAssemblies)
                {
                    TreeNode subNode = new TreeNode(String.Format("[{0}-{1}]-{2} ", sub.ProductID, sub.SubAssemblyID, sub.SubAssemblyName));
                  

                    productNode.Nodes.Add(subNode);
                }

                rootNode.Nodes.Add(productNode);

             }


        }

        private void WriteOutPut()
        {
            using (System.IO.StreamWriter file =
                                         new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            {
               
                //foreach (string line in lines)
                //{
                //    // If the line doesn't contain the word 'Second', write the line to the file.
                //    if (!line.Contains("Second"))
                //    {
                //        file.WriteLine(line);
                //    }
                //}
            }

        }
    }
}


 
        
       


      


