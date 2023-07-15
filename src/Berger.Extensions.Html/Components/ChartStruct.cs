namespace Berger.Extensions.Html
{
    public class ChartStruct : BaseMenu
    {
        #region Constructors
        public ChartStruct()
        {
        }
        #endregion

        #region Properties
        public string Color { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetColor(string color)
        {
            this.Color = color;
        }
        #endregion
    }
}