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
          
            if (part_ != null)
            {
                data.PartMasterId = part_.PartMasterId;
                data.Part = part_.PartName + " [ " + part_.PartCode + " ] ";
                data.Quantity = (int)(part_.Quantity == null ? 0 : part_.Quantity);
                
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

        public OrderTrackingData GetPartReceivingData(int orderMasterId)
        {
            OrderTrackingData data = new OrderTrackingData();
            data.ReceivingData = new List<ReceivingTrackingData>();

            var _order = _context.OrderMaster.Include(x=>x.ReceivePart).Where(x => x.OrderMasterId == orderMasterId).FirstOrDefault();
            if (_order != null)
            {
                data.OrderMasterId = _order.OrderMasterId;
                data.OrderDate = (DateTime)_order.OrderDate;
                data.OrderQuantity = (int) _order.OrderQuantity;
                data.ReceivedQuantity = 0;

                var _receiving = _order.ReceivePart;
                if(_receiving!=null && _receiving.Count() > 0)
                {
                    foreach(var _receivingData in _receiving)
                    {
                        data.ReceivingData.Add(new ReceivingTrackingData()
                        {
                              ReceiveDate = _receivingData.ReceiveDate,
                               ReceiveQuantity = _receivingData.ReceiveQuantity,
                                ReceivePartId = _receivingData.ReceivePartId
                        });
                        data.ReceivedQuantity += _receivingData.ReceiveQuantity;
                    }                    
                }
            }
            return data;
        }
    }
}
