using Inheritance.Models.Base;

namespace Inheritance.Models
{
    public class Student : AdvancedBaseEntity, IAuthenticatedEntity
    {
        // Special
        public string NameSurname { get; set; }
        public int Number { get; set; }

        // Authenticated
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
