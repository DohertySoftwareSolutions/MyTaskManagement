#nullable disable

namespace MyTaskManagement.Core.Entities
{
    public abstract class AuditableEntityBase
    {
        public User CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public User LastUpdatedBy{ get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
