namespace BookShop
{
    internal class Book
    {
        #region Properties
        public string BookName { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public bool isBorrowed { get; set; } = false;
        public static int TotalBooksBorrowed { get; set; } = 0;
        public int BooksFoundTotal = 0;
        public List<Book> booksInBookshop = new List<Book>();

        #endregion

        #region Methods
        public void DisplayAllBooks(List<Book> booksInBookshop)
        {
            Console.Clear();
            ShowHeader();

            Console.WriteLine("Books available:\n");
            foreach (var book in booksInBookshop)
            {
                Console.WriteLine(
                    $"Book Title:\t{book.BookName}\n" +
                    $"Author:\t\t{book.Author}\n" +
                    $"Category:\t{book.Category}\n" +
                    $"Borrowed:\t{book.isBorrowed}\n");
            }
            Console.WriteLine("\nPress Enter to go back to main menu.");
            Console.ReadLine();
        }

        // Add new book to the bookshop
        public List<Book> AddNewBook(List<Book> booksInBookshop)
        {
            bool IsToAddNewBook = true;
            do
            {
                Console.Clear();
                ShowHeader();

                string bookName = string.Empty;
                string author = string.Empty;
                string category = string.Empty;

                do
                {
                    Console.Clear();
                    ShowHeader();
                    Console.WriteLine("Add new book menu\n");
                    Console.Write("Book Title: ");
                    bookName = Console.ReadLine();

                    if (string.IsNullOrEmpty(bookName))
                    {
                        Console.WriteLine("Book Title cannot be empty!");
                        Console.ReadKey();
                    }
                }
                while (String.IsNullOrEmpty(bookName));

                Console.Write("Author Name: ");
                author = Console.ReadLine();
                Console.Write("Category: ");
                category = Console.ReadLine();

                booksInBookshop.Add
                   (
                   new Book
                   {
                       BookName = bookName,
                       Author = author,
                       Category = category
                   }
                   );
                Console.WriteLine($"\nBook {bookName} was added successfully to the bookshop!\n");

                // Check if the user needs to add another book
                Console.Write("Add another book? (y/n): ");
                string userAnswer = Console.ReadLine();
                if (userAnswer.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    break;
                }
            }
            while (IsToAddNewBook);

            return booksInBookshop;
        }

        public void SearchBooks(List<Book> booksInBookshop)
        // Search for a particular book provided by the user input
        {
            Console.Clear();
            ShowHeader();

            // Creating a new list which will contain all matched search input
            List<Book> searchMatch = new List<Book>();
            string searchResult = string.Empty;

            Console.WriteLine("Search books menu\n");

            Console.Write("Enter book name: ");
            string searchedBook = Console.ReadLine();
            Console.Clear();

            foreach (var book in booksInBookshop)
            {
                if (book.BookName.Equals(searchedBook, StringComparison.OrdinalIgnoreCase) || book.BookName.Contains(searchedBook, StringComparison.OrdinalIgnoreCase))
                {
                    BooksFoundTotal++;
                    searchMatch.Add(
                        new Book { BookName = book.BookName, Author = book.Author, Category = book.Category }
                        );
                }
            }
            if (searchMatch.Count() < 1)
            {
                Console.WriteLine($"\nBook {searchedBook} could not be found in the bookshop.");
            }
            else
            {
                Console.WriteLine($"{BooksFoundTotal} book(s) found!\n");
                foreach (var item in searchMatch)
                {
                    Console.WriteLine($"\nBook Title: {item.BookName}\n" +
                        $"Book Author: {item.Author}\n" +
                        $"Category: {item.Category}\n"
                        );
                }
            }

        }
        public string BorrowBook(List<Book> booksInBookshopList)
        // Borrow from books booksInBookshop list
        {
            string borrowResult = string.Empty;

            Console.Clear();
            ShowHeader();

            Console.WriteLine("\nBorrow Book menu\n");
            string bookToBorrow = string.Empty;

            do
            // Check string is not empty or null
            {
                Console.Clear();
                ShowHeader();
                Console.WriteLine("\nBorrow Book menu\n");

                Console.Write("Enter book name: ");
                bookToBorrow = Console.ReadLine();

                if (string.IsNullOrEmpty(bookToBorrow))
                {
                    Console.WriteLine("Book name cannot be empty!");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            while (string.IsNullOrEmpty(bookToBorrow));

            // Check if book name provided by the user exists and is available in the bookshop
            foreach (var book in booksInBookshopList)
            {
                if (book.BookName.Equals(bookToBorrow, StringComparison.OrdinalIgnoreCase) && book.isBorrowed == false)
                {
                    book.isBorrowed = true;
                    TotalBooksBorrowed++;
                    Console.WriteLine(TotalBooksBorrowed);
                    return borrowResult = $"{bookToBorrow} was successfully borrowed. Happy reading!\n";
                }
                else if (book.BookName.Equals(bookToBorrow, StringComparison.OrdinalIgnoreCase) && book.isBorrowed == true)
                {
                    return borrowResult = $"{bookToBorrow} is currently not available and has been borrowed by another user.";
                }
                else if (!book.BookName.Equals(bookToBorrow, StringComparison.OrdinalIgnoreCase))
                {
                    borrowResult = $"{bookToBorrow} name was not found in the bookshop system.";
                }
            }
            return borrowResult;
        }

        public string ReturnBook(List<Book> booksInBookshopList)
        // Return back a book the user was borrowing
        {
            string returnResult = string.Empty;

            Console.Clear();
            ShowHeader();

            Console.WriteLine("\nReturn a Book menu\n");
            string bookToReturn = string.Empty;

            do
            // Check string is not empty or null
            {
                Console.Clear();
                ShowHeader();
                Console.WriteLine("\nReturn a Book menu\n");

                Console.Write("Enter book name: ");
                bookToReturn = Console.ReadLine();

                if (string.IsNullOrEmpty(bookToReturn))
                {
                    Console.WriteLine("Book name cannot be empty!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (string.IsNullOrEmpty(bookToReturn));

            // Check if book name provided by the user exists and is available in the bookshop
            foreach (var book in booksInBookshopList)
            {
                if (book.BookName.Equals(bookToReturn, StringComparison.OrdinalIgnoreCase) && book.isBorrowed == true)
                {
                    book.isBorrowed = false;
                    return returnResult = $"{bookToReturn} was successfully returned to the bookshop. Thank you!\n";
                }
                else if (!book.BookName.Equals(bookToReturn, StringComparison.OrdinalIgnoreCase))
                {
                    returnResult = $"{bookToReturn} name was not found in the bookshop system.";
                }
            }
            return returnResult;
        }
        public void ShowBooksInBookshop(List<Book> booksInBookshop)
        {
            Console.Clear();
            ShowHeader();

            Console.WriteLine("Books available in Store\n");

            foreach (var book in booksInBookshop)
            {
                if (book.isBorrowed == false)
                    Console.WriteLine(
                        $"Book Title:\t{book.BookName}\n" +
                        $"Author:\t\t{book.Author}\n" +
                        $"Category:\t{book.Category}\n" +
                        $"Borrowed:\t{book.isBorrowed}\n");
            }
        }
        public void ShowBorrowedBooks(List<Book> booksInBookshop)
        {
            Console.Clear();
            ShowHeader();

            Console.WriteLine("Borrowed Books\n");

            foreach (var book in booksInBookshop)
            {
                if (book.isBorrowed == true)
                    Console.WriteLine(
                        $"Book Title:\t{book.BookName}\n" +
                        $"Author:\t\t{book.Author}\n" +
                        $"Category:\t{book.Category}\n" +
                        $"Borrowed:\t{book.isBorrowed}\n");
            }
        }

        public int ShowBorrowingTotal(Book book)
        {
            return TotalBooksBorrowed;
        }

        public void ShowHeader()
        {
            //  Console.Clear();
            Console.WriteLine("         =================== The Cyber Bookshop ===================\n");
        }
        public void ReturnToMain()
        {
            Console.WriteLine("\n\n\n\n\nPress Enter to return to main menu");
            Console.ReadKey();
        }
        #endregion
    }
}
