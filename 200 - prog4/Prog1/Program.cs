﻿// Program 1B
// CIS 200-01/02
// Due: 2/24/2016
// By: Andrew L. Wright

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy using
// LINQ and demonstrates polymorphism.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
     

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        

      

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2011, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2011, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2011, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2007, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            "MA53 9B", 16, 8));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            "MA53 9C", 16, 9));
        items.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2011, 14,
            "MA21 5V", 1, 1));


        //shows the original list of items
        Console.Out.WriteLine("Original List");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
        Pause();
       
       
        items.Sort(); // Sort - uses natural order
            Console.Out.WriteLine("Sorted list (natural order):");
            foreach (LibraryItem item in items)
                Console.WriteLine("{0}\n", item);
            Pause();

            items.Sort(new sortbycopyrightyear()); // Sort - uses specified Comparer class

            Console.Out.WriteLine("Sorted list by Copyright(reverse natural order) using Comparer:");
            foreach (LibraryItem item in items)
                Console.WriteLine("{0}\n", item);
            Pause();

    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press to continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }
}