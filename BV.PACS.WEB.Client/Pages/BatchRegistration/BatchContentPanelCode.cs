﻿using System;
using BV.PACS.WEB.Client.Pages.BatchRegistration;
using BV.PACS.WEB.Client.Shared.Base;
using BV.PACS.WEB.Client.Shared.ViewModels;
using BatchContentPanel = BV.PACS.WEB.Client.I18nText.BatchContentPanel;

namespace BV.PACS.WEB.Client.Materials
{
    public class BatchContentPanelCode : TranslatablePanel<BatchContentPanel>
    {
        protected BatchContentGridPanel _gridPanel;
        protected BatchContentTemplatePanel _templatePanel;

        protected void HandleValidSubmit(BatchTemplateViewModel model)
        {
            Console.WriteLine("OnValidSubmit");
            _gridPanel.HandleValidSubmit(model);
            StateHasChanged();
        }
    }
}