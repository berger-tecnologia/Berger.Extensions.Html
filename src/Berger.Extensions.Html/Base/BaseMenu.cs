namespace Berger.Extensions.Html
{
    public class BaseMenu : BaseStruct
    {
        #region Properties
        public List<HtmlElement> Menus { get; set; } = new List<HtmlElement>();
        #endregion

        #region Methods
        public void SetMenus(List<HtmlElement> menus)
        {
            this.Menus = menus;
        }
        #endregion
    }
}