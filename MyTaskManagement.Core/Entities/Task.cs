namespace MyTaskManagement.Core.Entities
{
    public class Task : AuditableEntityBase
    {
        public Task(string title, User createdBy)
        {
            this.Title = title;
            this.CreatedOn = DateTime.UtcNow;
            this.CreatedBy = createdBy;
            this.LastUpdatedOn = DateTime.UtcNow;
            this.LastUpdatedBy = createdBy;
            this.Status = Enums.TaskStatus.New;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Enums.TaskStatus Status { get; set; }
    }
}
