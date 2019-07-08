﻿using System.Net.Http;
using System.Threading.Tasks;
using BV.PACS.Client.Services.Api;
using BV.PACS.Shared.Models;
using BV.PACS.Shared.Models.Parameters;
using Microsoft.AspNetCore.Components;

namespace BV.PACS.Client.Shared.Base
{
    public class TrackingPanel<TModel> : ComponentBase, IPostable where TModel : new()
    {
        [Parameter]
        public int Id { get; set; }


        [Inject]
        protected HttpClient Http { get; set; }

        [Inject]
        protected TrackingService ApiTrackingService { get; set; }

        [Inject]
        protected LookupService ApiLookupService { get; set; }

        public TModel TrackingObject { get; set; }
        protected TemplateLookupItem[] Templates { get; set; }

        public bool HasChanges { get; set; } = true;

        public virtual bool Post()
        {
            ApiTrackingService.PostData(Http, new TrackingPostParameter<TModel>(TrackingObject, BaseSettings.Language))
                .ContinueWith(x => StateHasChanged());
            return true;
        }

        protected override async Task OnInitAsync()
        {
            await GetLookups();
            await GetData();
        }

        protected virtual async Task GetLookups()
        {
            await Task.Run(() => Templates = new TemplateLookupItem[0]);
        }

        protected async Task GetLookups(string lookupType)
        {
            Templates = await ApiLookupService.GetTemplatesLookup(Http, lookupType);
        }

        private async Task GetData()
        {
            TrackingObject = await ApiTrackingService.GetData<TModel>(Http, new TrackingParameter(Id, BaseSettings.Language));
        }
    }
}