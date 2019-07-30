namespace BV.PACS.WEB.Client.I18nText
{
    public partial class TestSearchPanel : global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage, global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextLateBinding
    {
        string global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage.FallBackLanguage => "en-US";

        public string this[string key] => global::Toolbelt.Blazor.I18nText.I18nTextExtensions.GetFieldValue(this, key);

        /// <summary>"Clear"</summary>
        public string Clear;

        /// <summary>"Search"</summary>
        public string Search;

        /// <summary>"Test ID"</summary>
        public string TestBarcode;

        /// <summary>"Registration Date (from)"</summary>
        public string TestRegistrationDateFrom;

        /// <summary>"Registration Date (to)"</summary>
        public string TestRegistrationDateTo;

        /// <summary>"Test Template"</summary>
        public string TestTemplateName;
    }
}
