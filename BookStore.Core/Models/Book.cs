
namespace BookStore.Core.Models
{
    public class Book
    {
        public const int MAX_TITLE_LENGTH = 250;
        private Book(Guid id, string title, string description, decimal price)
        {
            ID = id;
            Title = title;
            Description = description;
            Price = price;
        }
        public Guid ID { get; }
        public string Title { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public decimal Price { get; }


        public static (Book Book, string Error) Create(Guid id, string title, string description, decimal price)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
            {
                error = "Заголов не может быть пустым или быть длинней 250 символов";
                return (null,  error);
            }

            var book = new Book(id, title, description, price);

            return (book, error);
        }

    }
}


//КЛАСС ОТВЕЧАЕТ ЗА ЛОГИКУ ДОБАВЛЕНИЯ КНИГ
//СОЗДАЮТСЯ ГЕТЕРЫ И СЕТЕРЫ ИНКАПСУЛИРОВАНЫ, ИХ ЯВНО НЕ ОБЪЯВЛЯЮ, ОНИ ДОБАВЛЯЮТСЯ С ПОМОЩЬЮ КОНСТРУКТОРА
//ТАК ЖЕ РЕАЛИЗОВАНА ОБРАБОТКА ИСКЛЮЧЕНИЯ ПРИ ПУСТОМ ЗАГОЛОВКЕ (TITLE)