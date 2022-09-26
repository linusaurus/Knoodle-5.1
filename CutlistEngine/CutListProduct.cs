//-------------------------------------------------------------------
//Copyright 2022 Weaselware 
//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
//associated documentation files (the "Software"), to deal in the Software without restriction,
//including without limitation the rights to use, copy, modify, merge, publish, distribute,
//sublicense,and/or sell copies of the Software, and to permit persons to whom the Software
//is furnished to do so, subject to the following conditions:The above copyright notice and
//this permission notice shall be included in all copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
//PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
//FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWAREOR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//-------------------------------------------------------------------

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutlistEngine
{
    public class CutListProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CutlistID { get; set; }
        public int JobId    { get; set; }
        public string? Jobname { get; set; }
        public int ProductID { get; set; }
        public int SubAssemblyID { get; set; }
        public string? SubAssemblyName { get; set; }
        public string? ProductName { get; set; }
        [Column(TypeName = "int32")]
        public int PartID { get; set; }
        public string? UnitOfMeasure { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal UnitCost { get; set; }
        public string? PartSourceDescription { get; set; }
        public string? FunctionName { get; set; }
        public string? PartIdentifier { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Qnty { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Width { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Length { get; set; }
        public string? PartClass { get; set; }
        public decimal FunctionalPartCost { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Waste { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Markup { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Tax { get; set; }

    }
}
