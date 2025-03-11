namespace MessageDecorator
{

    //main component.
    public interface IMessage
    {
        string GetContent();
    }

    /// <summary>
    /// concrete class of main component
    /// </summary>
    public class SimpleMessage : IMessage
    {
        private string _text;

        public SimpleMessage(string text)
        {
            _text = text;
        }

        public string GetContent()
        {
           return _text;
        }
    }
}
