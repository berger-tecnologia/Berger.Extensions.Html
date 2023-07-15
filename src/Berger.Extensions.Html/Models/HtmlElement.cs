namespace Berger.Extensions.Html
{
    public class HtmlElement : BaseHtml
    {
        #region Properties
        public int Order { get; set; } = 0;
        public bool IsModal { get; set; } = false;
        public string Title { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetOrder(int order)
        {
            this.Order = order;
        }
        public void SetAsModal()
        {
            this.IsModal = true;
        }
        public void SetTitle(string title)
        {
            this.Title = title;
        }
        #endregion
    }
}