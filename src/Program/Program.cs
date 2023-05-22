using System;
using Library;

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
            phonebook.AddContacto(new Contact("santiago", "097353647", "santiago@gmail.com"));
            phonebook.AddContacto(new Contact("pedro", "093678945", "pedro@gmail.com"));
            phonebook.AddContacto(new Contact("milagros", "094678599", "milagros@gmail.com"));
            
            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
