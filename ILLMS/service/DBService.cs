using ILLMS.models;

namespace ILLMS.service;
using System;
using System.Collections.Generic;
using System.Linq;

public class DBService
{
    private List<Book> books = new List<Book>();
    private List<User> users = new List<User>();
    private List<CheckoutDetail> _checkouts = new List<CheckoutDetail>();
    private int _bookIdCounter = 1;
    private int _checkoutIdCounter = 1;
    private  User currentUser;

    // Add some initial data for demonstration
    public DBService()
    {
        users.Add(new User(1, "johndoe@etsu.edu", "password"));
        books.Add(new Book(1, "Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", "Software Engineering", true, true));
        books.Add(new Book(2, "The Pragmatic Programmer: Your Journey to Mastery", "Andrew Hunt, David Thomas", "Software Engineering", true, false));
        books.Add(new Book(3, "Design Patterns: Elements of Reusable Object-Oriented Software", "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", "Software Engineering", true, true));
        books.Add(new Book(4, "Refactoring: Improving the Design of Existing Code", "Martin Fowler", "Software Engineering", true, false));
        books.Add(new Book(5, "Code Complete: A Practical Handbook of Software Construction", "Steve McConnell", "Software Engineering", true, true));
        books.Add(new Book(6, "Domain-Driven Design: Tackling Complexity in the Heart of Software", "Eric Evans", "Software Engineering", true, false));
        books.Add(new Book(7, "Clean Architecture: A Craftsman's Guide to Software Structure and Design", "Robert C. Martin", "Software Engineering", true, true));
        books.Add(new Book(8, "Continuous Delivery: Reliable Software Releases through Build, Test, and Deployment Automation", "Jez Humble, David Farley", "Software Engineering", true, false));
        books.Add(new Book(9, "Extreme Programming Explained: Embrace Change", "Kent Beck", "Software Engineering", true, true));
        books.Add(new Book(10, "The Mythical Man-Month: Essays on Software Engineering", "Frederick P. Brooks Jr.", "Software Engineering", true, false));
        books.Add(new Book(11, "Agile Estimating and Planning", "Mike Cohn", "Software Engineering", true, true));
        books.Add(new Book(12, "Test Driven Development: By Example", "Kent Beck", "Software Engineering", true, false));
        books.Add(new Book(13, "Scrum: The Art of Doing Twice the Work in Half the Time", "Jeff Sutherland", "Software Engineering", true, true));
        books.Add(new Book(14, "Introduction to the Theory of Computation", "Michael Sipser", "Software Engineering", true, false));
        books.Add(new Book(15, "Head First Design Patterns", "Eric Freeman, Elisabeth Robson, Bert Bates, Kathy Sierra", "Software Engineering", true, true));
        books.Add(new Book(16, "Patterns of Enterprise Application Architecture", "Martin Fowler", "Software Engineering", true, false));
        books.Add(new Book(17, "Building Microservices: Designing Fine-Grained Systems", "Sam Newman", "Software Engineering", true, true));
        books.Add(new Book(18, "The Clean Coder: A Code of Conduct for Professional Programmers", "Robert C. Martin", "Software Engineering", true, false));
        books.Add(new Book(19, "Software Engineering: A Practitioner's Approach", "Roger S. Pressman", "Software Engineering", true, true));
        books.Add(new Book(20, "Introduction to Algorithms", "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein", "Software Engineering", true, false));
        books.Add(new Book(21, "The Art of Computer Programming, Volumes 1-4A Boxed Set", "Donald E. Knuth", "Software Engineering", true, true));
        books.Add(new Book(22, "Agile Software Development, Principles, Patterns, and Practices", "Robert C. Martin", "Software Engineering", true, false));
        books.Add(new Book(23, "Head First Software Development: A Learner's Companion to Software Engineering", "Dan Pilone, Russ Miles", "Software Engineering", true, true));
        books.Add(new Book(24, "Software Engineering: Modern Approaches", "Eric J. Braude, Michael E. Bernstein", "Software Engineering", true, false));
        books.Add(new Book(25, "Structure and Interpretation of Computer Programs", "Harold Abelson, Gerald Jay Sussman, Julie Sussman", "Software Engineering", true, true));
    }

    // Create
    public void AddBook(Book book)
    {
        book.bookId = _bookIdCounter++;
        books.Add(book);
    }

    // Read
    public List<Book> GetAllBooks()
    {
        return books;
    }

    public Book GetBookById(int id)
    {
        return books.FirstOrDefault(b => b.bookId == id);
    }

    // Update
    public void UpdateBook(Book updatedBook)
    {
        var existingBook = books.FirstOrDefault(b => b.bookId == updatedBook.bookId);
        if (existingBook != null)
        {
            existingBook.title = updatedBook.title;
            existingBook.author = updatedBook.author;
            existingBook.category = updatedBook.category;
            existingBook.availability = updatedBook.availability;
            existingBook.fromLoanlibrary = updatedBook.fromLoanlibrary;
        }
    }

    // Delete
    public void DeleteBook(int id)
    {
        var bookToDelete = books.FirstOrDefault(b => b.bookId == id);
        if (bookToDelete != null)
        {
            books.Remove(bookToDelete);
        }
    }

    // Checkout a book
    public void CheckoutBook(CheckoutDetail checkout)
    {
        checkout.checkoutId = _checkoutIdCounter++;
        _checkouts.Add(checkout);
    }

    // Get all checkouts
    public List<CheckoutDetail> GetAllCheckouts()
    {
        return _checkouts;
    }

    public User getCurrentUser()
    {
        User user = this.currentUser;
        return user;
    }

    public  void setCurrentUser(User user)
    {
        this.currentUser = user;
    } 
    
    public User GetUserByEmailPassword(string email, string password)
    {
        return users.FirstOrDefault(b => String.Equals(b.email, email) && String.Equals(b.password, password));
    }
}
