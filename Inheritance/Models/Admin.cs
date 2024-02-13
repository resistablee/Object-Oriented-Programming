using Inheritance.Models.Base;

namespace Inheritance.Models
{
    public class Admin : BasicBaseEntity, IAuthenticatedEntity
    {
        // Special
        public string NameSurname { get; set; }

        // Authenticated
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
