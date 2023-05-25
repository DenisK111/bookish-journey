using BookishJourney.Models.Entities.Common;

namespace BookishJourney.Models.Entities;

public class Book : IDeletableEntity
{
    // ReSharper disable once InconsistentNaming
     public string ISBN13 { get; set; } = null!;

     public string Name { get; set; } = null!;

     public string? Summary { get; set; } = null!;

     public int? PublicationYear { get; set; } = null!;

     public decimal Price { get; set; }

     public BookType BookType { get; set; }

     public string? ImageUrl { get; set; } = null!;

     public int Stock { get; set; }

     public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
     public ICollection<User> FavouritedBy { get; set; } = new HashSet<User>();
     public HashSet<Category> Categories { get; set; } = new ();

     public DateTime CreatedOn { get; set; }
     public DateTime LastModifiedOn { get; set; }
     public bool IsDeleted { get; set; }
}




