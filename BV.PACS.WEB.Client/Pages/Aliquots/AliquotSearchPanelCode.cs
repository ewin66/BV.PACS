﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BV.PACS.WEB.Client.I18nText;
using BV.PACS.WEB.Client.Shared.Base;
using BV.PACS.WEB.Shared.Models;

namespace BV.PACS.WEB.Client.Aliquots
{
    [FormTemplate(FormTypes.Aliquot)]
    public class AliquotSearchPanelCode : SearchPanel<AliquotSearchPanel>
    {
        protected string AliquotBarcode { get; set; }

        protected string AliquotNotes { get; set; }

        protected override void InitSearchCondition(AggregatedConditionDto cond)
        {
            var dates = new List<DateTime>();
            foreach (var item in cond.ConditionItems)
            {
                switch (item.FieldName)
                {
                    case "strBarcode":
                        AliquotBarcode = item.FieldValue;
                        break;


                    case "datCreationDate":
                        if (DateTime.TryParse(item.FieldValue, out var date))
                        {
                            dates.Add(date);
                        }

                        break;
                    case "idfsCFormTemplateID":
                        Template = Templates?.FirstOrDefault(t => t.Id == item.FieldValue);
                        break;
                }
            }

            if (dates.Count > 0)
            {
                StartDate = dates.Min();
                EndDate = dates.Max();
            }

            StateHasChanged();
        }

        protected override async Task DoSearch()
        {
            var cond = new AggregatedConditionDto();

            cond.AddStandardConditionIfNotEmpty("strBarcode", AliquotBarcode, Operators.LikeOperator);

            cond.AddStandardConditionIfNotEmpty("datCreationDate", StartDateText, Operators.MoreOperator);
            cond.AddStandardConditionIfNotEmpty("datCreationDate", EndDateText, Operators.LessOperator);

            cond.AddStandardConditionIfNotEmpty("idfsCFormTemplateID", Template?.Id, Operators.EqualsOperator);
            //todo: implement the rest

            await InvokeAsync(() => OnSearch?.Invoke(cond));
        }

        protected override void DoClear()
        {
            base.DoClear();

            Template = null;

            AliquotBarcode = string.Empty;
        }
    }
}