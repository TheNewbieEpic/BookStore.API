namespace BookStore.DataAccess.Entites
{
    public class BookEntity
    {
        public Guid ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}


//Тут создается сущность для БД