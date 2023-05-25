namespace BookishJourney.Models.Entities.Common;

public interface IAuditEntity
{
    public DateTime CreatedOn { get; set; }
    
    public DateTime LastModifiedOn { get; set; }
}