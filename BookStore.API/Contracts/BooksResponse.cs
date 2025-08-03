namespace BookStore.API.Contracts
{
    public record BooksResponse(
        Guid ID,
        string Title,
        string Description,
        decimal Price);
}
