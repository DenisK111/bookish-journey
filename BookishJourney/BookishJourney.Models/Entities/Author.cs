using BookishJourney.Models.Entities.Common;

namespace BookishJourney.Models.Entities;

public class Author : IDeletableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public HashSet<Book> Books { get; set; } = new();
    public DateTime CreatedOn { get; set; }
    public DateTime LastModifiedOn { get; set; }
    public bool IsDeleted { get; set; }
}