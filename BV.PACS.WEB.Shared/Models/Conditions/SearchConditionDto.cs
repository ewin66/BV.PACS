﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using BV.PACS.WEB.Shared.Utils;

namespace BV.PACS.WEB.Shared.Models
{
    [Serializable]
    [XmlRoot("ConditionRoot")]
    public class SearchConditionDto
    {
        private static readonly Serializer<SearchConditionDto> Serializer = new Serializer<SearchConditionDto>();
        public static SearchConditionDto CreateEmpty => new SearchConditionDto();

        [XmlArray("ConditionList")]
        [XmlArrayItem("Condition")]
        public List<SearchConditionItemDto> Items { get; set; }

        public SearchConditionDto()
        {
            Items = new List<SearchConditionItemDto>();
        }

        public string Serialize()
        {
            return Serializer.Serialize(this);
        }

        public void AddStandardIfNotEmpty(string fieldId, string fieldName, object value, string oper)
        {
            if (!value.IsNullOrEmpty())
            {
                Items.Add(new SearchConditionItemDto(fieldId, fieldName, value.Str(), oper, false));
            }
        }
    }
}