﻿using System;

namespace BV.PACS.Shared.Models
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class FormTemplateAttribute : Attribute
    {
        public string FormType { get; set; }
        public FormTemplateAttribute(string formType)
        {
            FormType = formType;
        }
    }
}