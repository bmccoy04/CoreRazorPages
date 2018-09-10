using System;

namespace CoreRazorPages.ComponentBasedUi.Shared.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsCool { get; set; }
    }
}