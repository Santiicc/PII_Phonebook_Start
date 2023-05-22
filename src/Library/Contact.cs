namespace Library
{
    public class Contact
    {
        public Contact(string name, string Phone, string Email)
        {
            this.Name = name;
            
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}