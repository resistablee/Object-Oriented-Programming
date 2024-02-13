namespace Inheritance.Models.Base
{
    public class AdvancedBaseEntity : BasicBaseEntity, IAuditableEntity, ISoftDeleteEntity
    {
        // Auditable
        public Guid CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedOn { get; set; }

        // SoftDelete
        public bool IsDeleted { get; set; }
    }
}
