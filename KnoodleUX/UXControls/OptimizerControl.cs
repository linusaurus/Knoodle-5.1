using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CutlistEngine;
using System.Windows.Forms;
using BinPackingCuttingStock;
using ServiceLayer;
using FrameWorks;
using DataLayer.Entity;

namespace KnoodleUX.UXControls
{
    public partial class OptimizerControl : UserControl
    {
        IEnumerable<CutListProduct> _cutList;
        IEnumerable<CutListProduct> partFilteredList;
        
        Job _selectedJob;

        BackgroundWorker worker;
        float sumOfItems;
        public OptimizerControl(IEnumerable<CutListProduct> cutlist,Job selectedJob)
        {
            InitializeComponent();
           _selectedJob= selectedJob;
            _cutList= cutlist;
 
            BuildCutListGridGrid(dgCutListGrid);
            this.dgCutListGrid.DataSource = _cutList;
            LoadPartIDs();
            tscboPartIDFilter.SelectedIndexChanged += ToolStripComboBox1_SelectedIndexChanged;
        }

        

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cbo = (ToolStripComboBox)sender;
          
            if (cbo.SelectedItem != null)
            {
                int result = int.Parse(cbo.SelectedItem.ToString());
                if (result != 0)
                {
                    partFilteredList = _cutList
                       .Where(p => p.PartID == result);
                    this.dgCutListGrid.DataSource = partFilteredList.ToList();
                }
            }
            
        }

        private void LoadPartIDs()
        {
            IEnumerable<CutListProduct> filterList = _cutList
                .GroupBy(part => part.PartID)
                    .Select(group => group.FirstOrDefault());
            foreach(CutListProduct product in filterList) 
            {
                tscboPartIDFilter.Items.Add(product.PartID.ToString());
            }
           
        }

        


        public void BuildCutListGridGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // ID Column --
            DataGridViewTextBoxColumn partID = new DataGridViewTextBoxColumn();
            partID.HeaderText = "PartID";
            partID.DataPropertyName = "PartID";
            partID.Width = 75;

            // Arch Description --
            DataGridViewTextBoxColumn colFunctionName = new DataGridViewTextBoxColumn();
            colFunctionName.HeaderText = "Functional Name";
            colFunctionName.DataPropertyName = "FunctionName";
            colFunctionName.Width = 250;

            // Part Label --
            DataGridViewTextBoxColumn colPartLabel = new DataGridViewTextBoxColumn();
            colPartLabel.HeaderText = "Label";
            colPartLabel.DataPropertyName = "PartIdentifier";
            colPartLabel.Width = 120;

            // Part Source Name --
            DataGridViewTextBoxColumn colPartSourceName = new DataGridViewTextBoxColumn();
            colPartSourceName.DefaultCellStyle = dstyleWrapText;
            colPartSourceName.HeaderText = "Source Description";
            colPartSourceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPartSourceName.DataPropertyName = "PartSourceDescription";
            colPartSourceName.Width = 300;

            // Qnty ----------
            DataGridViewTextBoxColumn colQnty = new DataGridViewTextBoxColumn();
            colQnty.Width = 140;
            colQnty.HeaderText = "Qnty";
            colQnty.DataPropertyName = "Qnty";
            colQnty.DefaultCellStyle = dstyleDecimal;


            // W ----------
            DataGridViewTextBoxColumn colW = new DataGridViewTextBoxColumn();
            colW.Width = 140;
            colW.HeaderText = "W";
            colW.DataPropertyName = "W";
            colW.DefaultCellStyle = dstyleDecimal;
            // D ----------
            DataGridViewTextBoxColumn colD = new DataGridViewTextBoxColumn();
            colD.Width = 140;
            colD.HeaderText = "T";
            colD.DataPropertyName = "T";
            colD.DefaultCellStyle = dstyleDecimal;
            // H ----------
            DataGridViewTextBoxColumn colH = new DataGridViewTextBoxColumn();
            colH.Width = 140;
            colH.HeaderText = "L";
            colH.DataPropertyName = "L";
            colH.DefaultCellStyle = dstyleDecimal;


            //colUnit.DataSource = _partService.Units();
            dg.Columns.AddRange(partID, colFunctionName, colPartLabel, colPartSourceName, colQnty, colW, colD, colH);
        }


        private void tsOptimizeToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsRemoveFilter":
                    this.dgCutListGrid.DataSource = _cutList;
                    tscboPartIDFilter.SelectedIndex = -1;
                    break;
                case "tsbOptimize":
                    if (partFilteredList!=null || partFilteredList.ToList().Count > 0)
                    {
                        if (theTextBoxStatus.Text.Length > 0)
                        {
                            float stockSize;
                            float.TryParse(theTextBoxStatus.Text, out stockSize);
                            Optimize(stockSize);
                        }
                        
                    }
                    break;
                default:
                    break;
            }
        }

        private void Optimize(float stockSize)   
        {
            //public CuttingStock(List<Stock> theStocks, List<Item> theItems,
            //               float theTotalItemsSum, ToolStripLabel theTextBoxStatus,
            //               ToolStripProgressBar theToolStripProgressBar, CheckBox theExitGreedyNextFit)
            string materialName = string.Empty;
            if (!string.IsNullOrEmpty(tscboPartIDFilter.SelectedItem.ToString()))
            {
                int k = int.Parse(tscboPartIDFilter.SelectedItem.ToString());
                materialName = k.ToString() + " - " + PartDictionary.PartLookup[k].MaterialDescription.ToString();
            }
            
            List<BinPackingCuttingStock.Item> theItems = new List<Item>();
            List<BinPackingCuttingStock.Stock> Stocks = new List<Stock>();
            BinPackingCuttingStock.Stock stock = new Stock();
            stock.ConsiderMaxPieces = false;
            stock.Cost = 20.00f;
            stock.MaxPieces = 0;
            stock.Size = stockSize;
            stock.MaterialDescription = materialName;
            Stocks.Add(stock);

            if (partFilteredList!=null && partFilteredList.ToList().Count > 0)
            {
                foreach (CutListProduct outp in partFilteredList.ToList())
                {
                    BinPackingCuttingStock.Item i = new Item();
                    i.Pieces = (uint)outp.Qnty;
                    i.Size = (float)outp.W;
                    i.BarCode = outp.PartIdentifier;
                    
                    theItems.Add(i);
                    sumOfItems += i.Size;
                }
            }


            BinPackingCuttingStock.CuttingStock s = new CuttingStock(Stocks, theItems, sumOfItems, tsStatusLabel, tsProgressBar, ckbExitNextGreedyFit);
            s.Solve(_selectedJob);
        }

     
    }
}
