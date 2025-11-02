using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Kitablar
            Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ağ Gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qiriq Budaq", "Elcin", 1998, 350);

            Console.WriteLine("\n--- Kitab Melumatları ---");
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            // 2. Generic Library
            Library<Book> library = new Library<Book>("Milli Kitabxana");
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);

            Console.WriteLine($"\nKitab sayi: {library.Count()}");
            Console.WriteLine("İndeks 0 kitabi:");
            library.FindByIndex(0).DisplayInfo();
            Console.WriteLine("İndeks 2 kitabi:");
            library.FindByIndex(2).DisplayInfo();

            Console.WriteLine("\nButun kitablar:");
            foreach (var b in library.GetAll())
                b.DisplayInfo();

            // 3. Üzvlər
            List<Member> members = new List<Member>()
            {
                new Member(1, "Ali Memmedov", "ali@mail.com"),
                new Member(2, "Leyla Hesenova", "leyla@mail.com"),
                new Member(3, "Vuqar Eliyev", "vuqar@mail.com")
            };

            members[0].BorrowBook(book1);
            members[0].BorrowBook(book2);
            members[0].DisplayBorrowedBooks();

            members[0].ReturnBook(1);
            members[0].DisplayBorrowedBooks();

            members[0].BorrowBook(book3);
            members[0].BorrowBook(book4);
            members[0].BorrowBook(book5);
            members[0].BorrowBook(book1); // limit xəbərdarlığı

            // 4. BookManager
            BookManager bm = new BookManager();
            bm.AddBook(book1);
            bm.AddBook(book2);
            bm.AddBook(book3);
            bm.AddBook(book4);
            bm.AddBook(book5);

            Console.WriteLine("\n--- Muellife gore axtarıs ---");
            foreach (var b in bm.GetBooksByAuthor("George Orwell"))
                b.DisplayInfo();
            foreach (var b in bm.GetBooksByAuthor("Cingiz Aytmatov"))
                b.DisplayInfo();
            foreach (var b in bm.GetBooksByAuthor("Jack London"))
                b.DisplayInfo();
            Console.WriteLine($"Dostoyevski kitablari: {bm.GetBooksByAuthor("Dostoyevski").Count}");

            // 5. Queue
            Console.WriteLine("\n--- Novbe ---");
            bm.AddToWaitingQueue("Nigar");
            bm.AddToWaitingQueue("Resad");
            bm.AddToWaitingQueue("Sebine");
            Console.WriteLine($"Novbede: {bm.WaitingQueue.Count}");

            string next = bm.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {next}");
            Console.WriteLine($"Novbede: {bm.WaitingQueue.Count}");

            next = bm.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {next}");
            Console.WriteLine($"Novbede: {bm.WaitingQueue.Count}");

            next = bm.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {next}");
            Console.WriteLine($"Novbede: {bm.WaitingQueue.Count}");

            // 6. Stack
            Console.WriteLine("\n--- Stack (Son qaytarılan kitablar) ---");
            bm.ReturnBook(book1);
            bm.ReturnBook(book2);
            bm.ReturnBook(book3);
            Console.WriteLine($"Stack-de kitab sayi: {bm.RecentlyReturned.Count}");

            var last = bm.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarilan kitab: {last.Title}");

            bm.RecentlyReturned.Pop();
            Console.WriteLine($"Stack-de kitab sayi: {bm.RecentlyReturned.Count}");
            Console.WriteLine($"Son kitab indi: {bm.GetLastReturnedBook().Title}");

            // 7. Axtarış
            Console.WriteLine("\n--- Axtarış ---");
            var found = bm.SearchByTitle("1984");
            if (found != null) found.DisplayInfo();

            var notFound = bm.SearchByTitle("Harry Potter");
            if (notFound == null)
                Console.WriteLine("Kitab tapilmadi!");

            // 8. Statistika
            Console.WriteLine("\n--- Statistika ---");
            Console.WriteLine($"Umumi kitab sayi: {bm.Books.Count}");
            Console.WriteLine($"Umumi Uzv sayi: {members.Count}");
            Console.WriteLine($"Novbede nefer sayi: {bm.WaitingQueue.Count}");
            Console.WriteLine($"Stack-de kitab sayi: {bm.RecentlyReturned.Count}");

            int minYear = int.MaxValue, maxYear = int.MinValue;
            foreach (var b in bm.Books)
            {
                if (b.Year < minYear) minYear = b.Year;
                if (b.Year > maxYear) maxYear = b.Year;
            }
            Console.WriteLine($"En kohne kitab ili: {minYear}");
            Console.WriteLine($"En yeni kitab ili: {maxYear}");
        }
    }
}
