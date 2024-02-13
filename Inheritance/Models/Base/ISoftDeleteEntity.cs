
namespace Inheritance.Models.Base
{
    internal interface ISoftDeleteEntity
    {
        public bool IsDeleted { get; set; }
    }
}
