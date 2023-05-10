using DesignPatterns.SingletonPattern;
using DesignPatterns.SingletonPattern.Models;

LibrarySystem librarySystem1 = LibrarySystem.GetInstance();
Book book1 = new Book(1, "Yüzüklerin Efendisi", "J. R. R. Tolkien", 1026);
librarySystem1.AddBook(book1);

LibrarySystem librarySystem2 = LibrarySystem.GetInstance();
Book book2 = new Book(2, "Game Of Thrones", "George R. R. Martin", 847);
librarySystem2.AddBook(book2);

bool isEquals = librarySystem1 == librarySystem2;
Console.WriteLine("Library System referance is equals: " + isEquals);

// Print:
// Created Instance
// Id: 1, Name: Yüzüklerin Efendisi, Author: J.R.R.Tolkien, Page Size: 1026
// Id: 2, Name: Game Of Thrones, Author: George R. R.Martin, Page Size: 847
// Library System referance is equals: True