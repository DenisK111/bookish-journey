namespace BookishJourney.Models.Entities.Common;

public interface IDeletableEntity : IAuditEntity
{
    bool IsDeleted { get; set; }    
}