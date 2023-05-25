namespace BookishJourney.Infra;

public sealed class InvalidPurchaseDataException : Exception
{
    private InvalidPurchaseDataException(Guid userId, IEnumerable<(int quantity, string isbn13)> purchases,
        decimal quotedPrice, decimal actualPrice, decimal discountPercent, decimal discountedPrice) : base(
        $"Inconsitent Price Data: User ID:{userId}, itemsToPurchase: {string.Join(Environment.NewLine, purchases.Select(p => $"ISBN:{p.isbn13}, QTY: {p.quantity}"))}, quotedPrice: {quotedPrice}, actualPrice: {actualPrice}, discountPercent: {discountPercent}, disountedPrice: {discountedPrice}") { }

    public static InvalidPurchaseDataException Create(Guid userId, IEnumerable<(int quantity, string isbn13)> purchases,
        decimal quotedPrice, decimal actualPrice, decimal discountPercent, decimal discountedPrice) => new(userId,
        purchases, quotedPrice, actualPrice, discountPercent, discountedPrice);
}