using Inheritance.Models.Base;

namespace Inheritance.Models
{
    public class Courses : AdvancedBaseEntity
    {
        public Guid InstructorId { get; set; }
        public string Instructor { get; set; }
        public string Name { get; set; }
    }
}
