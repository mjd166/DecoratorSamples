using MessageDecorator;

IMessage simpleMessage = new SimpleMessage("Hello world.");

Console.WriteLine(simpleMessage);

IMessage ecnyptedmssg= new EncryptedMessage(simpleMessage);

Console.WriteLine(ecnyptedmssg.GetContent());


IMessage htmlMessage = new HtmlMessage(simpleMessage);

Console.WriteLine(htmlMessage.GetContent());


///combination of decorators
IMessage fancyMessage = new HtmlMessage(new EncryptedMessage(simpleMessage));
Console.WriteLine(fancyMessage.GetContent());