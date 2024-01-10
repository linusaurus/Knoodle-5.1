using System;
using System.Collections.Generic;
using System.ComponentModel;
using DataLayer.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ServiceLayer.DTO
{
    public class JobDTO : INotifyPropertyChanged
    {

        private int _jobID;
        private string _jobName;
        private string _jobDescrption;
        private DateTime _start_ts;

        private List<ProductDto> products;

        public event PropertyChangedEventHandler PropertyChanged;

        public JobDTO()
        {
            products = new List<ProductDto>();
        }

        public List<ProductDto> Products
        { 
            get { return products; }
            set { products = value;OnPropertyChange(); }
        }

        public int jobID
        {
            get { return _jobID; } 
            set
            {
                _jobID = value;
                OnPropertyChange();
            }
            
        }
          
         public string jobname 
        {
            get { return _jobName; }
            set { _jobName = value;OnPropertyChange(); }
        }

        public string jobdesc 
        {
            get { return _jobDescrption; }
            set { _jobDescrption = value; OnPropertyChange(); }
        }
            
            
         public DateTime start_ts 
        {
            get { return _start_ts; }
            set { _start_ts = value; OnPropertyChange(); }
        }

        

         protected void OnPropertyChange([CallerMemberName] string name = null)
         {
                 PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
         }
    }
}
