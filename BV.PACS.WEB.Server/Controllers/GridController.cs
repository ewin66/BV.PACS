﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BV.PACS.WEB.Server.Filters;
using BV.PACS.WEB.Server.Services;
using BV.PACS.WEB.Shared.Models;
using BV.PACS.WEB.Shared.Models.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace BV.PACS.WEB.Server.Controllers
{
    [Route("api/[controller]")]
    [PacsExceptionFilter]
    public class GridController : Controller
    {
        private readonly TrackingDbService _trackingDbService;

        public GridController(TrackingDbService trackingDbService)
        {
            _trackingDbService = trackingDbService;
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<MaterialGridDto>> GetSourceMaterials([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetSourceMaterials(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<SourceDiagnosticsDto>> GetSourceDiagnostics([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetSourceDiagnostics(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<SourceTestGridDto>> GetSourceTests([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetSourceTests(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<AliquotTestGridDto>> GetAliquotTests([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetAliquotTests(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<MaterialAliquotGridDto>> GetMaterialAliquots([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetMaterialAliquots(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<SourceAuditGridDto>> GetSourceAudit([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetSourceAudit(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<MaterialAuditGridDto>> GetMaterialAudit([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetMaterialAudit(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<AliquotAuditGridDto>> GetAliquotAudit([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetAliquotAudit(parameter);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<TestAuditGridDto>> GetTestAudit([FromBody] GridParameter parameter)
        {
            return await _trackingDbService.GetTestAudit(parameter);
        }
    }
}