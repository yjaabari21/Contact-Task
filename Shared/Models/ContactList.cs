using System;
using System.Collections.Generic;

namespace ContactListTask.Server.Models
{
    public partial class ContactList
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
