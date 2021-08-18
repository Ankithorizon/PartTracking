using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using PartTracking.Context.Models.Models;
using PartTracking.Service.Repository;
using PartTracking.Context.Models.DTO;

namespace PartTracking.Service.Service
{
    public class TrackingRepository : GenericRepository<PartMaster>, ITrackingRepository
    {
        public TrackingRepository(PartMgtContext context) : base(context)
        {
        }

        public PartTrackingData GetPartOrdersData(int partMasterId)
        {
            PartTrackingData data = new PartTrackingData();
            data.Orders = new List<OrderTrackingData>();

            var part_ = _context.PartMaster.Include(x=>x.OrderMaster).Where(x => x.PartMasterId == partMasterId).FirstOrDefault();
            data.PartMasterId = part_.PartMasterId;
            data.Part = part_.PartName + " [ " + part_.PartCode + " ] ";
            data.Quantity = (int)(part_.Quantity==null ? 0 : part_.Quantity);
           
            if (part_ != null)
            {
                var orders_ = part_.OrderMaster;
                if(orders_!=null && orders_.Count() > 0)
                {
                    foreach(var order_ in orders_)
                    {
                        data.Orders.Add(new OrderTrackingData()
                        {
                            OrderDate = (DateTime)order_.OrderDate,
                             OrderMasterId = order_.OrderMasterId,
                              OrderQuantity = (int)order_.OrderQuantity,
                               OrderStatus = (int)order_.OrderStatus,
                                RefCode = order_.RefCode
                        });
                    }                    
                }
            }
            return data;
        }
    }
}
