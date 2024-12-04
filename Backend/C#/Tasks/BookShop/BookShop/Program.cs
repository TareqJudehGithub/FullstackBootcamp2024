using BookShop;

// Instantiating obj from Book class
Book book = new Book();


// Adding "manually" new books to booksInBookshop
book.booksInBookshop.Add(
    new Book { BookName = "HTML Fundamentals", Author = "Tim Berners-Lee", Category = "Web Development", isBorrowed = false }
    );
book.booksInBookshop.Add(
   new Book { BookName = "The CSS Design", Author = "HÃ¥kon Wium Lie", Category = "Web Development", isBorrowed = false }
    );
book.booksInBookshop.Add(
    new Book { BookName = "JavaScript Basics", Author = "Brendan Eich", Category = "Web Development", isBorrowed = false }
    );
book.booksInBookshop.Add(
    new Book { BookName = "SQL Deep Dive", Author = "Donald D. Chamberlin", Category = "Database", isBorrowed = false }
    );
book.booksInBookshop.Add(
    new Book { BookName = "Introduction to C#", Author = "Anders Hejlsberg", Category = "Programming", isBorrowed = true }
    );

bool isRunning = true;

// Console menu
book.ShowHeader();

Console.Write("Welcome to The Cyber Bookshop!\nWhat is your name? ");
string name = Console.ReadLine();
do
{
    Console.Clear();
    book.ShowHeader();

    Console.WriteLine($"Hello, {name}! How can I help you today?\n");

    Console.WriteLine($"[1] List all books");
    Console.WriteLine($"[2] Search bookshop");
    Console.WriteLine($"[3] Add a new book");
    Console.WriteLine($"[4] Borrow a book");
    Console.WriteLine($"[5] Return back a book");
    Console.WriteLine($"[6] Books in Store");
    Console.WriteLine($"[7] Books Borrowed");
    Console.WriteLine($"[8] Total books borrowed");
    Console.WriteLine($"[Q] Exit");

    Console.Write("\nChoose from 1 - 7, or Q to exit: ");
    string userChoice = Console.ReadLine().ToLower();

    switch (userChoice)
    {
        case "1":
            book.DisplayAllBooks(book.booksInBookshop);
            break;
        case "2":
            book.SearchBooks(book.booksInBookshop);
            book.ReturnToMain();
            break;
        case "3":
            book.AddNewBook(book.booksInBookshop);
            break;
        case "4":
            string borrowResult = book.BorrowBook(book.booksInBookshop);
            Console.WriteLine(borrowResult);
            book.ReturnToMain();
            break;
        case "5":
            string returnResult = book.ReturnBook(book.booksInBookshop);
            Console.WriteLine(returnResult);
            book.ReturnToMain();
            break;

        case "6":
            book.ShowBooksInBookshop(book.booksInBookshop);
            book.ReturnToMain();
            break;
        case "7":
            book.ShowBorrowedBooks(book.booksInBookshop);
            book.ReturnToMain();
            break;
        case "8":
            int totalBorrowed = book.ShowBorrowingTotal(book);
            Console.WriteLine($"{name}, you borrowed a total of {totalBorrowed} books.");
            book.ReturnToMain();
            break;
        case "q":
            Console.Clear();
            book.ShowHeader();
            Console.WriteLine("Thanks for visiting The Cyber Bookshop!\nGood bye!");
            isRunning = false;
            break;
        default:
            book.ShowHeader();
            Console.WriteLine("Invalid entry.");
            break;
    }
}
while (isRunning);


Console.ReadLine();






