
namespace Inheritance.Models.Base
{
    internal interface IAuthenticatedEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
