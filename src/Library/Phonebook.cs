using System.Collections.Generic;
using System;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
        public void AddContacto (Contact persona)
        {
            this.persons.Add(persona);
        }

        public void RemoveContacto(Contact persona)
        {
            this.persons.Remove(persona);
        }

        public void Enviar(Contact namex, Message mensaje, IMessageChannel channel)
        {

            foreach (Contact person in this.persons)
            {
                if (person == namex)
                {
                    channel.Send(mensaje);
                    Console.WriteLine("Hola");
                }
                else
                {
                    Console.WriteLine($"{person.Phone} hola");
                }
            }
        }

    }
}