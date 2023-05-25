using BookishJourney.Models.Entities.Common;

namespace BookishJourney.Models.Entities;

public class User : IDeletableEntity
{
    public Guid Id { get; set; }
    public string HashedPassword { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public HashSet<Book> FavouriteBooks { get; set; } = new();
    public HashSet<Author> FavouriteAuthors { get; set; } = new();
    public DateTime CreatedOn { get; set; }
    public DateTime LastModifiedOn { get; set; }
    public bool IsDeleted { get; set; }
}