namespace BV.PACS.WEB.Client.I18nText
{
    public partial class BatchContentTemplatePanel : global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage, global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextLateBinding
    {
        string global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage.FallBackLanguage => "en-US";

        public string this[string key] => global::Toolbelt.Blazor.I18nText.I18nTextExtensions.GetFieldValue(this, key);

        /// <summary>"Aliquots"</summary>
        public string Aliquots;

        /// <summary>"Aliquot Template"</summary>
        public string AliquotTemplate;

        /// <summary>"Generate"</summary>
        public string Generate;

        /// <summary>"Materials"</summary>
        public string Materials;

        /// <summary>"Material Template"</summary>
        public string MaterialTemplate;

        /// <summary>"Sources"</summary>
        public string Sources;

        /// <summary>"Source Template"</summary>
        public string SourceTemplate;
    }
}