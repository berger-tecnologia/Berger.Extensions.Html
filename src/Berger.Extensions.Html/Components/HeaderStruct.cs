using Berger.Extensions.Html.Elements;

namespace Berger.Extensions.Html
{
    public class HeaderStruct : BaseMenu
    {
        #region Constructors
        public HeaderStruct()
        {
        }
        #endregion

        #region Properties
        public string Module { get; set; } = string.Empty;
        public DateTime? Date { get; set; }
        public bool Search { get; set; } = false;
        public List<HtmlElement> Buttons { get; set; } = new List<HtmlElement>();
        #endregion

        #region Methods
        public void SetModule(string module)
        {
            this.Module = module;
        }
        public void SetDate(DateTime? date)
        {
            this.Date = date;
        }
        public void SetSearch(bool search)
        {
            this.Search = search;
        }
        #endregion
    }
}