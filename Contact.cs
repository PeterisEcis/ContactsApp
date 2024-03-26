using System;

namespace ContactsApp
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName => $"{FirstName} {LastName}";
        public DateTime? Birthday { get; set; }
        public string PhonePrefix { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
    }
}
