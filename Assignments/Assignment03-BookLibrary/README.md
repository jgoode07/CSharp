# Assignment 3 – Book Library
**Author:** Joe Goode  
**Course:** C# Programming

This console app is a small library system built as part of Assignment 3 for my C# Programming course.  
The goal was to practice interfaces, classes, events, functions, and basic program structure while keeping the code clean and easy to follow.

## What the program does
- Lets the user add different types of books (Ebook, HardCover, Audiobook)
- Stores all books in a `List<IBook>`
- Lets the user search for a book by title
- Allows borrowing and returning books
- Tracks whether a book is available or borrowed
- Tracks the book's location:
  - **HardCover** books switch between *Library* and *Client*
  - **Ebook** and **Audiobook** always stay on *Web*
- Keeps running until the user chooses to exit

## What I focused on
- Using an interface (`IBook`) so every book type follows the same structure
- Using classes and methods to separate logic
- Basic input validation and a clean menu system
- Writing code that’s readable and consistent with what I’ve learned so far

## How to run it
Run the console app and choose options from the menu.  
You can add, find, borrow, and return books as needed.