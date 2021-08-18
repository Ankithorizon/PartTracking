using System;
using System.Collections.Generic;
using System.Text;

namespace PartTracking.Context.Models.DTO
{
    public class PartTrackingData
    {
        public int PartMasterId { get; set; }
        public string Part { get; set; }
        public int Quantity { get; set; }
        public List<PartOrders> Orders { get; set; }
    }

    public class PartOrders
    {
        public int OrderMasterId { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public string RefCode { get; set; }
    }
}
