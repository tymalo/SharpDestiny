namespace SharpDestiny.Common
{
    public class DisplayText : System.Attribute
    {
        public DisplayText(string text) 
        {
            Text = text;
        }
        public string Text { get; set; }
    }
}
