﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BV.PACS.Shared.Models;
using BV.PACS.Shared.Models.Parameters;
using Dapper;

namespace BV.PACS.Server.Services
{
    public class TrackingDbService : DbService
    {
        public async Task<SourceTrackingDto> GetSourceTracking(TrackingParameter parameter)
        {
            var sqlParameter = new
            {
                LanguageID = parameter.Language,
                idfSource = parameter.Id
            };
            return await GetTracking<SourceTrackingDto>(sqlParameter, "dbo.spSource_SelectDetail");
        }

        public async Task<MaterialTrackingDto> GetMaterialTracking(TrackingParameter parameter)
        {
            var sqlParameter = new
            {
                LanguageID = parameter.Language,
                idfMaterial = parameter.Id
            };
            return await GetTracking<MaterialTrackingDto>(sqlParameter, "dbo.spStrainPassport_SelectDetail");
        }

        public async Task<AliquotTrackingDto> GetAliquotTracking(TrackingParameter parameter)
        {
            var sqlParameter = new
            {
                LanguageID = parameter.Language,
                idfContainer = parameter.Id
            };
            return await GetTracking<AliquotTrackingDto>(sqlParameter, "dbo.spVial_SelectDetail");
        }

        public async Task<TestTrackingDto> GetTestTracking(TrackingParameter parameter)
        {
            var sqlParameter = new
            {
                LanguageID = parameter.Language,
                idfTest = parameter.Id
            };
            return await GetTracking<TestTrackingDto>(sqlParameter, "dbo.spTest_SelectDetail");
        }

        private async Task<T> GetTracking<T>(object sqlParameter, string spName)
        {
            using (var connection = new SqlConnection(_builder.ConnectionString))
            {
                var result = await connection.QueryMultipleAsync(spName,
                    sqlParameter,
                    commandType: CommandType.StoredProcedure);
                var tracking = result.ReadSingleOrDefault<T>();
                //todo: implement reading of custom fields
                //var customFields = result.Read();
                return tracking;
            }
        }


        public async Task<IEnumerable<MaterialGridDto>> GetSourceMaterials(GridParameter parameter)
        {
            return await GetSourceGridItems<MaterialGridDto>(parameter, "dbo.spSource_Materials");
        }


        private async Task<IEnumerable<T>> GetSourceGridItems<T>(GridParameter parameter, string spName)
        {
            using (var connection = new SqlConnection(_builder.ConnectionString))
            {
                var result = await connection.QueryAsync<T>(spName,
                    new
                    {
                        LanguageID = parameter.Language,
                        idfSource = parameter.Id
                    },
                    commandType: CommandType.StoredProcedure);

                return result;
            }
        }
    }
}