namespace Berger.Extensions.Html
{
    public class HtmlComposition
    {
        #region Properties
        public List<CardStruct> Cards { get; set; } = new List<CardStruct>();
        public List<ChartStruct> Charts { get; set; } = new List<ChartStruct>();
        public List<HeaderStruct> Headers { get; set; } = new List<HeaderStruct>();
        #endregion
    }
}