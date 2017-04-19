//Austin Shircliff
// Program 0
// Due 2/3/16
//CIS 200-01

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            -1, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book

       

        List<LibraryBook> theBooks = 
            new List<LibraryBook>();// Test List of books
        theBooks.Add(book1);
        theBooks.Add(book2);
        theBooks.Add(book3);
        theBooks.Add(book4);
        theBooks.Add(book5);

        LibraryPatron patron1 = new LibraryPatron("Austin Shircliff", "1234567");//1st test patron

        LibraryPatron patron2 = new LibraryPatron("Steven Kendra", "1314151");//2nd test patron

        LibraryPatron patron3 = new LibraryPatron("James Bond", "007");//3rd test patron

        LibraryPatron patron4 = new LibraryPatron("Batman", "0101010");//4th test patron

        LibraryPatron patron5 = new LibraryPatron("The Joker", "9999999");//5th test patron


        Console.WriteLine("Original list of books");
        PrintBooks(theBooks);

        // Make changes
        book1.CheckOut(patron4);//returning the patron 1
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2);//returning the patron 2
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron5);//returning the patron 3

        Console.WriteLine("After changes");
        PrintBooks(theBooks);

        // Return all the books
        for (int i = 0; i < theBooks.Count; ++i)
            theBooks[i].ReturnToShelf();

        Console.WriteLine("After returning the books");
        PrintBooks(theBooks);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> books)//array changed to a list 
    {
        foreach (LibraryBook b in books)
        {
            Console.WriteLine(b);
            Console.WriteLine();
        }
    }
}
