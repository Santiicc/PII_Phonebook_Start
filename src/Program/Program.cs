﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact Yo = new Contact ("Yo", "094060133", "milagros@gmail.com");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(Yo);

            // Agregar contactos a la lista
            phonebook.AddContacto(new Contact("santiago", "098454534", "santiago@gmail.com"));

            // Enviar un correo a algunos contactos
            Message message = new Message("Yo", "santiago", "Hola, ¿cómo estás?");
            IMessageChannel channel = new WhatsAppChannel();
            phonebook.Enviar(Yo, message, channel);
        
            // Enviar un WhatsApp a algunos contactos


            // Enviar un SMS a algunos contactos

        }
    }
}

