using System;
using System.Collections.Generic;
namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message);
    }

    public class WhatsAppChannel : IMessageChannel
    {
        public void Send(Message mensaje)
        {
            Console.WriteLine("Enviando mensaje por WhatsApp: " + mensaje.Text);
        }

        
    }
}