namespace SimpleHelloWorld.Logic
{
    using System;
    using Models;

    public class MessageLogic
    {
        private MessageDalc messageDalc;

        public MessageLogic()
        {
            messageDalc = new MessageDalc();
        }

        public void HandleMessage(Message message)
        {
            Console.WriteLine(message.message);
            messageDalc.ArchiveMessage(message);
        }

    }
}
