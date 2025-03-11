namespace MessageDecorator
{
    /// <summary>
    /// Decorator abstract class
    /// </summary>
    public abstract class MessageDecorator : IMessage
    {
        protected IMessage _message;

        protected MessageDecorator(IMessage message)
        {
            _message = message;
        }

        public virtual string GetContent()
        {
           return _message.GetContent();
        }
    }

    public class EncryptedMessage : MessageDecorator
    {
        public EncryptedMessage(IMessage message) : base(message)
        {
        }

        public override string GetContent()
        {
            return $"[Encrypted] {base.GetContent()}"; 
        }
    }
    public class HtmlMessage : MessageDecorator
    {
        public HtmlMessage(IMessage message) : base(message)
        {
        }
        public override string GetContent()
        {
            return $"[Html]{base.GetContent()}"; 
        }
    }
}
