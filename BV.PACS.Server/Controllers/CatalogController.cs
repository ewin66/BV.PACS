﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BV.PACS.Server.Services;
using BV.PACS.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV.PACS.Server.Controllers
{
    [Route("api/[controller]")]
    public class CatalogController : Controller
    {
        private readonly CatalogDbService _dbService;

        public CatalogController(CatalogDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<SourceCatalogDto>> GetSources([FromBody] AggregatedConditionDto condition)
        {
            return await _dbService.GetSources(condition);
        }

        [HttpPost("[action]")]
        public int GetSourcesRecordCount([FromBody] AggregatedConditionDto condition)
        {
            return _dbService.GetSourcesRecordCount(condition);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<MaterialCatalogDto>> GetMaterials([FromBody] AggregatedConditionDto condition)
        {
            return await _dbService.GetMaterials(condition);
        }

        [HttpPost("[action]")]
        public int GetMaterialsRecordCount([FromBody] AggregatedConditionDto condition)
        {
            return _dbService.GetMaterialsRecordCount(condition);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<AliquotCatalogDto>> GetAliquots([FromBody] AggregatedConditionDto condition)
        {
            return await _dbService.GetAliquots(condition);
        }

        [HttpPost("[action]")]
        public int GetAliquotsRecordCount([FromBody] AggregatedConditionDto condition)
        {
            return _dbService.GetAliquotsRecordCount(condition);
        }

        [HttpPost("[action]")]
        public async Task<IEnumerable<TestCatalogDto>> GetTests([FromBody] AggregatedConditionDto condition)
        {
            return await _dbService.GetTests(condition);
        }

        [HttpPost("[action]")]
        public int GetTestsRecordCount([FromBody] AggregatedConditionDto condition)
        {
            return _dbService.GetTestsRecordCount(condition);
        }
    }
}