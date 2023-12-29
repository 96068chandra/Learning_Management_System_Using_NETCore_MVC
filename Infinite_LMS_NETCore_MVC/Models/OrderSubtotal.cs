using System;
using System.Collections.Generic;

namespace Infinite_LMS_NETCore_MVC.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
