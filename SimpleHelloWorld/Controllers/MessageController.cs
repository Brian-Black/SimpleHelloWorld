namespace SimpleHelloWorld
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Models;
    using SimpleHelloWorld.Logic;

    public class MessageController : ApiController
    {

        public IHttpActionResult HandleMessage(string message)
        {
            var messageLogic = new MessageLogic();
            messageLogic.HandleMessage(new Message(message));
            return Ok();
        }
    }
}
