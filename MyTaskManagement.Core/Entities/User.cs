namespace MyTaskManagement.Core.Entities
{
    public class User : AuditableEntityBase
    {
        public User(string name, string email, User createdBy)
        {
            this.Name = name;
            this.Email = email;
            this.CreatedBy = createdBy;
            this.CreatedOn = DateTime.UtcNow;
            this.LastUpdatedBy = createdBy;
            this.LastUpdatedOn = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
    }
}
