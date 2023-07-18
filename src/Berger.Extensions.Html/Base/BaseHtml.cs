namespace Berger.Extensions.Html
{
    public class BaseHtml
    {
        #region Properties
        public HtmlType HtmlType { get; set; }
        public string Href { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Identifier { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetType(HtmlType type)
        {
            this.HtmlType = type;
        }
        public void SetHref(string link)
        {
            this.Href = link;
        }
        public void SetIdentifier(string identifier)
        {
            this.Identifier = identifier;
        }
        public void SetClass(string classValue)
        {
            this.Class = classValue;
        }
        #endregion
    }
}