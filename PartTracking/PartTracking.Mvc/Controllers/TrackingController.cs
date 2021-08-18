using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PartTracking.Context.Models.DTO;
using PartTracking.Context.Models.Models;
using PartTracking.Mvc.Models;
using PartTracking.Service.UOfW;
using PartTracking.Service.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PartTracking.Mvc.Controllers
{
    public class TrackingController : Controller
    {
        private readonly ILogger<TrackingController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public List<SelectListItem> PartMasterSelectList{ get; set; }

        public TrackingController(ILogger<TrackingController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            PartMasterSelectList = _unitOfWork.PartMasters.GetPartMasterSelectList();
            ViewBag.Parts = PartMasterSelectList;
            return View();
        }

        [HttpGet]
        public IActionResult GetWarehouseOrdersByPart(int Id)
        {
            PartTrackingData partTrackingData = new PartTrackingData();
            try
            {                
                partTrackingData = _unitOfWork.PartTrackingService.GetPartOrdersData(Id);
                return PartialView("_partOrders", partTrackingData);
            }
            catch(Exception ex)
            {
                TempData["Exception"] = "Exception!";
                return PartialView("_partOrders", partTrackingData);
            }
        }

    }
}
