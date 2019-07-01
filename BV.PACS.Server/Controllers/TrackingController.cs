﻿using System.Threading.Tasks;
using BV.PACS.Server.Filters;
using BV.PACS.Server.Services;
using BV.PACS.Shared.Models;
using BV.PACS.Shared.Models.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace BV.PACS.Server.Controllers
{
    [Route("api/[controller]")]
    public class TrackingController : Controller
    {
        private readonly TrackingDbService _trackingDbService;

        public TrackingController(TrackingDbService trackingDbService)
        {
            _trackingDbService = trackingDbService;
        }

        [PacsExceptionFilter]
        [HttpPost("[action]")]
        public async Task<SourceTrackingDto> GetSource([FromBody] TrackingParameter parameter)
        {
            return await _trackingDbService.GetSourceTracking(parameter);
        }

        [PacsExceptionFilter]
        [HttpPost("[action]")]
        public async Task<MaterialTrackingDto> GetMaterial([FromBody] TrackingParameter parameter)
        {
            return await _trackingDbService.GetMaterialTracking(parameter);
        }

        [PacsExceptionFilter]
        [HttpPost("[action]")]
        public async Task<AliquotTrackingDto> GetAliquot([FromBody] TrackingParameter parameter)
        {
            return await _trackingDbService.GetAliquotTracking(parameter);
        }

        [PacsExceptionFilter]
        [HttpPost("[action]")]
        public async Task<TestTrackingDto> GetTest([FromBody] TrackingParameter parameter)
        {
            return await _trackingDbService.GetTestTracking(parameter);
        }
    }
}