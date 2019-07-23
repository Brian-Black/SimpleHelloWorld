
namespace SimpleHelloWorld
{
    using System;
    using Models;

    public class MessageDalc : DataAccessLayer
    {
        public void ArchiveMessage(Message message)
        {
            Console.WriteLine(ConnectionString);
            
            //TODO: Make DB connection
        }
    }
}
