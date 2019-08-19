namespace BV.PACS.WEB.Client.I18nText
{
    public partial class AliquotTrackingPanel : global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage, global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextLateBinding
    {
        string global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage.FallBackLanguage => "en-US";

        public string this[string key] => global::Toolbelt.Blazor.I18nText.I18nTextExtensions.GetFieldValue(this, key);

        /// <summary>"Aliquot ID"</summary>
        public string AliquotBarcode;

        /// <summary>"Creation Date"</summary>
        public string AliquotCreationDate;

        /// <summary>"Notes"</summary>
        public string AliquotNote;

        /// <summary>"Parent Barcode"</summary>
        public string AliquotParentBarcode;

        /// <summary>"Aliquot Status"</summary>
        public string AliquotStatus;

        /// <summary>"Template"</summary>
        public string AliquotTemplateName;

        /// <summary>"Derivative Type"</summary>
        public string DerivativeType;

        /// <summary>"Location Path"</summary>
        public string LocationPath;

        /// <summary>"Material ID"</summary>
        public string MaterialBarcode;

        /// <summary>"Material Type"</summary>
        public string MaterialType;

        /// <summary>"Passage"</summary>
        public string Passage;

        /// <summary>"Source Type"</summary>
        public string SourceType;

        /// <summary>"Volume"</summary>
        public string Volume;

        /// <summary>"Volume Unit"</summary>
        public string VolumeUnitName;

        /// <summary>"Weight"</summary>
        public string Weight;

        /// <summary>"Weight Unit"</summary>
        public string WeightUnitName;
    }
}
