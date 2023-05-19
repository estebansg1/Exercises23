using System;

Book[] books = new Book[2];

Console.WriteLine("Insert the information of two books:\n");

Console.WriteLine("Information of book 1:");
books[0] = GetBookDataFromUser(); 

Console.WriteLine("\nInformation of book 2:");
books[1] = GetBookDataFromUser(); 

Console.WriteLine("\nExpected Output:");

for (int i = 0; i < books.Length; i++)
    {
        Console.WriteLine($"{i + 1}: Title = {books[i].Title},  Author = {books[i].Author}");
    }

static Book GetBookDataFromUser()
    {
        Book book = new Book();

        Console.Write("Input name of the book: ");
        book.Title = Console.ReadLine();

        Console.Write("Input the author: ");
        book.Author = Console.ReadLine();

        return book;
    }