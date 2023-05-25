using BookishJourney.Infra;
using BookishJourney.Models.Entities.Common;
using CSharpFunctionalExtensions;

namespace BookishJourney.Models.Entities;

public record Purchase
{ 
       private Purchase() {}
       
       public Guid PurchaseId { get; private init; }

       public HashSet<BookPurchase> BooksPurchased { get; private init; } = new();
       
       public decimal RRP { get; private init; }
       
       public decimal DiscountPercent { get; private init; }
       
       public decimal PricePaid { get; private init; }
       
       public Guid UserId { get; private init; }

       public DateTime CreatedOn { get; private init; }
       

       public static Result<Purchase,Exception> Create(HashSet<BookPurchase> bookPurchases, decimal rrp, decimal discountPercent,
              decimal pricePaid, Guid userId) =>
              EnsureInvariants(bookPurchases, rrp, discountPercent, pricePaid, userId)
                     .Bind<Purchase,Exception>(() => new Purchase
                     {
                            PurchaseId = Guid.NewGuid(),
                            BooksPurchased = bookPurchases,
                            RRP = rrp,
                            DiscountPercent = discountPercent,
                            PricePaid = pricePaid,
                            UserId = userId,
                            CreatedOn = DateTime.UtcNow,
                     });

       private static UnitResult<Exception> EnsureInvariants(HashSet<BookPurchase> bookPurchases, decimal rrp, decimal discountPercent,
              decimal pricePaid, Guid userId)
       {
              var price = bookPurchases.Sum(x => x.Quantity * x.Book.Price);
              return price == rrp && (price - (price * discountPercent)) == pricePaid
                     ? UnitResult.Success<Exception>()
                     : UnitResult.Failure(InvalidPurchaseDataException.Create(userId, bookPurchases.Select(bp => (bp.Quantity,bp.Book.ISBN13)), rrp, price,
                            discountPercent, pricePaid) as Exception);
       }
}

public record BookPurchase(int Quantity, Book Book);
