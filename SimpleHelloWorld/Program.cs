namespace SimpleHelloWorld
{
    using Logic;
    using Models;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Message beginningMessage = new Message();
            beginningMessage.message = "Hello World!";
            beginningMessage.receivedTime = DateTime.Now;

            var messageLogic = new MessageLogic();
            messageLogic.HandleMessage(beginningMessage);
        }
    }
}
