﻿using BV.PACS.WEB.Shared.Models;

namespace BV.PACS.WEB.Client.Shared
{
    public class CatalogState
    {
        private readonly AggregatedConditionDto _condition = new AggregatedConditionDto();
        private AggregatedConditionDto _lastSearchPanelCondition = new AggregatedConditionDto();
        public bool SearchPanelCollapsed { get; set; } = true;

        public AggregatedConditionDto Condition => SearchPanelCollapsed 
            ? _condition 
            : _lastSearchPanelCondition;

        public string SearchPanelCssClass => SearchPanelCollapsed 
            ? "collapse" 
            : "col-sm-3 alert alert-primary background-white";

        public string GridPanelCssClass => SearchPanelCollapsed
            ? "col-sm-12 alert alert-primary background-white"
            : "col-sm-9 alert alert-primary background-white";

        public string ShowHideSearchPanelCaption => SearchPanelCollapsed 
            ? "Show Search Panel" 
            : "Hide Search Panel";


        public void SetSearchPanelCondition(AggregatedConditionDto cond)
        {
            _lastSearchPanelCondition = cond;
        }

        public void SearchPanelToggle()
        {
            SearchPanelCollapsed = !SearchPanelCollapsed;
        }
    }
}