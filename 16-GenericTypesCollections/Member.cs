using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 3)
            {
                Console.WriteLine("Maksimum 3 kitab goture bilersiniz!");
                return;
            }
            BorrowedBooks.Add(book);
            Console.WriteLine($"Kitab goturuldu: {book.Title}");
        }

        public void ReturnBook(int bookId)
        {
            Book found = null;
            foreach (var b in BorrowedBooks)
            {
                if (b.Id == bookId)
                {
                    found = b;
                    break;
                }
            }

            if (found != null)
            {
                BorrowedBooks.Remove(found);
                Console.WriteLine($"Kitab qaytarildi: {found.Title}");
            }
            else
            {
                Console.WriteLine("Bu ID-li kitab borcda yoxdur!");
            }
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Borc kitab yoxdur");
                return;
            }

            Console.WriteLine($"{Name} adlı uzvun borc goturduyu kitablar:");
            foreach (var b in BorrowedBooks)
            {
                b.DisplayInfo();
            }
        }
    }
}
