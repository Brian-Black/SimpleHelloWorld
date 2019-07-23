using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHelloWorld.Models
{
    public class Message
    {
        public string message { get; set; }

        public DateTime receivedTime { get; set; }

        public Message()
        {
        }

        public Message(string newMessage)
        {
            message = newMessage;
        }
    }
}
