using Berger.Extensions.Html.Elements;

namespace Berger.Extensions.Html
{
    public class BaseStruct : BaseHtml
    {
        #region Properties
        public Guid ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetTitle(string title)
        {
            this.Title = title;
        }
        public void SetSubtitle(string subtitle)
        {
            this.Subtitle = subtitle;
        }
        public void SetDescription(string description)
        {
            this.Description = description;
        }
        #endregion
    }
}