namespace BV.PACS.WEB.Client.I18nText
{
    public partial class BatchRegistrationPanel : global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage, global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextLateBinding
    {
        string global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage.FallBackLanguage => "en-US";

        public string this[string key] => global::Toolbelt.Blazor.I18nText.I18nTextExtensions.GetFieldValue(this, key);

        /// <summary>"Approved By"</summary>
        public string ApprovedBy;

        /// <summary>"Delivered By"</summary>
        public string DeliveredBy;

        /// <summary>"Delivered From"</summary>
        public string DeliveredFrom;

        /// <summary>"Department"</summary>
        public string Department;

        /// <summary>"Notes"</summary>
        public string Notes;

        /// <summary>"Performed By"</summary>
        public string PerformedBy;

        /// <summary>"Registration Date"</summary>
        public string RegistrationDate;

        /// <summary>"Witnessed By"</summary>
        public string WitnessedBy;
    }
}