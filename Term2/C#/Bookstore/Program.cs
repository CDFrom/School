using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    //Create book class
    class Book
    {
        //Create Fields
        private string _bookName;
        private int _bookSerial;
        private bool _bookStatus = true;

        public Book(string bookName, int bookSerial) //Constructor Method
        {
            _bookName = bookName;
            _bookSerial = bookSerial;
        }

        public string BookName() //Get value of private field
        {
            return _bookName;
        }

        public int BookSerial() //Get value of private field
        {
            return _bookSerial;
        }

        public bool CheckAvailable() //Check book status
        {
            if (_bookStatus) return true;
            return false;
        }

        public bool RentBook() //Change status of book on rent
        {
            if (_bookStatus)
            {
                _bookStatus = false;
                return true;
            }
            return false;
        }
        public bool ReturnBook() //Change status of book on return
        {
            if (!_bookStatus)
            {
                _bookStatus = true;
                return true;
            }
            return false;
        }

        public void DisplayBookInfo() //Display information on the book
        {
            Console.WriteLine($"Book Name: {_bookName}, Serial: {_bookSerial}, Status: {(_bookStatus == true ? "Available" : "Rented")}");
        }
    }

    //Create Reader Class
    class Reader
    {
        //Create Fields
        private string _readerName;
        List<Book> _readerBooks;

        public Reader(string readerName) //Constructor Method
        {
            _readerName = readerName;
            _readerBooks = new List<Book>();
        }

        public string ReaderName() //Get value of private field
        {
            return _readerName;
        }

        public List<Book> ReaderBooks() //Get value of private field
        {
            return _readerBooks;
        }

        public void RentBook(Book book) //Add book to readers book list upon rental
        {
            _readerBooks.Add(book);
        }

        public void ReturnBook(Book book) //Remove book from readers book list upon return
        {
            _readerBooks.Remove(book);
        }

        public void DisplayReaderInfo() //Display name of reader and their currently rented books
        {
            Console.WriteLine($"Reader {_readerName} rented the following books: "); //Gives reader name
            if (_readerBooks.Count == 0) Console.WriteLine($"No books rented yet!"); //If no books are rented by reader
            else
            {
                foreach (var book in _readerBooks) //Display book info for each book currently rented by the reader
                {
                    book.DisplayBookInfo();
                }
            }
        }
    }

    //Create Book Store class
    class Bookstore
    {
        //Create Book Store fields
        private List<Book> _books;
        private List<Reader> _readers;

        public Bookstore() //Constructor Method
        {
            _books = new List<Book>();
            _readers = new List<Reader>();
        }

        public void AddReader(string name) //Create reader and add them to the list of readers
        {
            Reader person = new Reader(name);
            _readers.Add(person);
        }

        public void RemoveReader(string name) //Check if reader is in the list of readers and if they are found check if they have any books
        {                                     //After returning any books currently rented by the reader delete the reader from the list of readers
            foreach (var reader in _readers)
            {
                if (reader.ReaderName() == name)
                {
                    if (reader.ReaderBooks().Count > 0) //Check if the reader has any books rented and if so return them to the bookstore
                    {
                        Console.WriteLine($"Returning books rented by {name}:");
                        foreach (var book in reader.ReaderBooks())
                        {
                            if (book.ReturnBook())
                            {
                                Console.WriteLine($"Book: '{book.BookName()}', Serial: {book.BookSerial()} successfully returned by {name}.");
                            }
                        }
                    }
                    _readers.Remove(reader);
                    Console.WriteLine($"Reader {reader.ReaderName()} successfully removed from bookstore.\n");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {name} is not a registered reader.\n");
        }

        public void AddBook(string bookName, int serialNum) //Create a book and add it to the list of books
        {
            Book book = new Book(bookName, serialNum);
            _books.Add(book);
        }

        public void RemoveBook(string bookName, int serialNum) //First check to see if the book and serial exist in the list of books and if found
        {                                                      //check to see if it is rented and if it is not remove the book from the list of books
            foreach (var book in _books)
            {
                if (book.BookName() == bookName && book.BookSerial() == serialNum)
                {
                    if (book.CheckAvailable()) //If found and not rented remove the book from the bookstore
                    {
                        _books.Remove(book);
                        Console.WriteLine($"The book: {book.BookName()},Serial: {book.BookSerial()}, is successfully removed from the bookstore.");
                        return;
                    }
                    else //If found but rented let user know
                    {
                        Console.WriteLine($"Sorry! '{book.BookName()}' is already rented. System cannot remove a rented book!\n");
                        return;
                    }
                }
            }
            Console.WriteLine($"Sorry, '{bookName}', Serial: {serialNum} does not exist in bookstore.\n"); //If book and serial are not found
        }

        public void RentBook(string readerName, string bookName) //Allow a reader to rent a book if it is found and available
        {                                                        //and they do not currently have more than 2 books
            foreach (var reader in _readers)
            {
                if (reader.ReaderName() == readerName) //Check if reader exists in the list of registered readers
                {
                    if (reader.ReaderBooks().Count >= 2) //Check if they have are trying to rent more than 2 books
                    {                                    //(Should work with =2 but we use >=2 just in case)
                        Console.WriteLine($"Sorry! {readerName}, You cannot rent more than two books!");
                        return;
                    }
                    foreach (var book in _books)
                    {
                        if (book.BookName() == bookName) //If the book is found we check if the book is available for rental if it is not it will
                        {                                //continue to go through the list in case there is more then one copy until an available copy
                            if (book.RentBook())         //has been found or we have reached the end of the list
                            {
                                Console.WriteLine($"Book: '{bookName}' successfully rented by {readerName}.");
                                reader.RentBook(book);
                                return;
                            }
                        }
                    }
                    Console.WriteLine($"Sorry {readerName}, The book '{bookName}' is not Available for renting."); //If the book is not found or a copy
                    return;                                                                                        //is not available
                }
            }
            Console.WriteLine($"{readerName}, you are not a registered reader of this bookstore!\n"); //If the reader is not found in the list of readers
        }

        public void ReturnBook(string readerName, string bookName, int serialNum) //Determine if the reader is a registered reader and if the book
        {                                                                         //with mentioned serial number is in their possession and if so
            foreach (var reader in _readers)                                      //return the book
            {
                if (reader.ReaderName() == readerName) //Ensure the reader exists
                {
                    foreach (var book in reader.ReaderBooks())
                    {
                        if (book.BookName() == bookName && book.BookSerial() == serialNum) //Check they have the book and matching serial in question
                        {
                            if (book.ReturnBook()) //If book is eligible to be returned (which by this point it should) return it
                            {
                                reader.ReturnBook(book);
                                Console.WriteLine($"Book: '{bookName}', Serial: {serialNum} successfully returned by {readerName}.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine($"Return Error! {readerName}, you have not rented {bookName}, Serial: {serialNum}\n"); //If the book is not in
                    return;                                                                                                  //their list of books
                }
            }
            Console.WriteLine($"Sorry, {readerName}, you are not currently a registered reader of this bookstore!\n"); //If the reader is not in the list
        }                                                                                                              //of readers

        public void ShowBooks() //Display all books currently available in the bookstore
        {
            if (_books.Count == 0) Console.WriteLine("There are currently no books in the bookstore!\n"); //If no books are in the list
            else
            {
                Console.WriteLine("The bookstore has the following books available:");
                foreach (var book in _books) //Go through the list of books and display each one if it is currently available for rental
                {
                    if (book.CheckAvailable())
                    {
                        book.DisplayBookInfo();
                    }
                }
                Console.WriteLine();
            }
        }

        public void ShowReaders() //Display all registered readers and their currently rented books
        {
            if (_readers.Count == 0) Console.WriteLine("There are currently no readers registered!\n"); //If no readers are in the list
            else
            {
                Console.WriteLine("The bookstore has the following readers:");
                foreach (var reader in _readers) //Go through the list of readers and display each one and the list of books they currently have
                {
                    reader.DisplayReaderInfo();
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //The following was copied and pasted from the starter code, with slight changes to the function names in accordance with what I had
            Bookstore bs = new Bookstore();
            bs.AddReader("Mickey Mouse");
            bs.AddReader("Donald Duck");
            bs.AddReader("Daisy Duck");
            bs.AddBook("Object Oriented Programming", 1);
            bs.AddBook("Object Oriented Programming", 2);
            bs.AddBook("Object Oriented Programming", 3);
            bs.AddBook("Programming Fundamentals", 1);
            bs.AddBook("Programming Fundamentals", 2);
            bs.AddBook("Let us C#", 1);
            bs.AddBook("Programming is Fun", 1);
            bs.AddBook("Life is Beautiful", 1);
            bs.AddBook("Let's Talk About the Logic", 1);
            bs.AddBook("How to ace a job interview", 1);

            bs.ShowBooks();
            bs.ShowReaders();

            bs.RentBook("John Doe", "Object Oriented Programming");

            bs.RentBook("Mickey Mouse", "Object Oriented Programming");
            bs.RentBook("Mickey Mouse", "How to ace a job interview");
            bs.RentBook("Mickey Mouse", "Life is Beautiful");

            Console.WriteLine();

            bs.RentBook("Donald Duck", "Object Oriented Programming");
            bs.RentBook("Donald Duck", "Programming Fundamentals");
            Console.WriteLine();

            bs.RentBook("Daisy Duck", "Let's Talk About the Logic");
            bs.RentBook("Daisy Duck", "How to ace a job interview");
            Console.WriteLine();

            bs.ShowBooks();
            bs.ShowReaders();


            bs.ReturnBook("Mickey Mouse", "Object Oriented Programming", 1);
            bs.RentBook("Mickey Mouse", "Life is Beautiful");
            Console.WriteLine();

            bs.ReturnBook("Mickey Mouse", "Programming Fundamentals", 1);

            bs.RemoveBook("Let us C#", 1);
            bs.RemoveBook("Let's Talk About the Logic", 1);

            bs.ShowReaders();
            bs.RemoveReader("Mickey Mouse");


            bs.ShowBooks();
            bs.ShowReaders();
            Console.Read();
            //This is the end of the copied portion
        }
    }
}
