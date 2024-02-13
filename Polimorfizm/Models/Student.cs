using Polimorfizm.Models.Base;

namespace Polimorfizm.Models
{
    public class Student : BaseEntity
    {
        public int Number { get; set; }
        public string NameSurname { get; set; }
    }
}
