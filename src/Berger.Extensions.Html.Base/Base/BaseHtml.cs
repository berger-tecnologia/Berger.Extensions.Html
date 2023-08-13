namespace Berger.Extensions.Html.Elements
{
    public class BaseHtml
    {
        #region Constructors
        public BaseHtml()
        {
        }
        public BaseHtml(HtmlType type)
        {
            HtmlType = type;
        }
        #endregion

        #region Properties
        public HtmlType HtmlType { get; set; }
        public string Href { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
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
        public void SetId(string id)
        {
            this.Id = id;
        }
        public void SetClass(string classValue)
        {
            this.Class = classValue;
        }
        #endregion
    }
}