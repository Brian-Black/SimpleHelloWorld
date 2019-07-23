namespace SimpleHelloWorldTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SimpleHelloWorld.Logic;
    using SimpleHelloWorld.Models;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHandleMessage()
        {
            var messageLogic = new MessageLogic();
            var message = new Message();
            message.message = "This is my unit test Message";

            messageLogic.HandleMessage(message);
            
        }
    }
}
