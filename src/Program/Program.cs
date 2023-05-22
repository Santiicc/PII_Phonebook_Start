using System;
using Library;
using System.Collections.Generic;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact Yo = new Contact("yo", "098984563", "hola@gmail.com");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(Yo);

            // Agregar contactos a la lista
            phonebook.AddContacto(new Contact("santiago", "093607913", "santiago@gmail.com"));
            phonebook.AddContacto(new Contact("pedro", "093678945", "pedro@gmail.com"));
            phonebook.AddContacto(new Contact("milagros", "094678599", "milagros@gmail.com"));
            
            // Enviar un correo a algunos contactos
            var whatsApp = new WhatsAppApi();
            

            
            // Enviar un WhatsApp a algunos contactos
            string sid = whatsApp.Send("+598093607913", "Hey there! I'm using WhatsAppUCU");
            
            // Enviar un SMS a algunos contactos
        }
    }
}
