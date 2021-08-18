using PartTracking.Context.Models.DTO;
using PartTracking.Context.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartTracking.Service.Repository
{
    public interface ITrackingRepository : IGenericRepository<PartMaster>
    {
        PartTrackingData GetPartOrdersData(int partMasterId);
    }
}
