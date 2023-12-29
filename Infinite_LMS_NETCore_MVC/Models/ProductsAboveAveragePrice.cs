using System;
using System.Collections.Generic;

namespace Infinite_LMS_NETCore_MVC.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
