namespace ILLMS.models;
 
 public class Book
 {
     public Book(int bookId, string title, string author, string category, bool availability, bool fromLoanlibrary)
     {
         this.bookId = bookId;
         this.title = title;
         this.author = author;
         this.category = category;
         this.availability = availability;
         this.fromLoanlibrary = fromLoanlibrary;
     }
 
     public int bookId { get; set;  }
     public string title { get; set; }
     public string author { get; set; }
     public string category { get; set; }
     public bool availability { get; set; } 
     
     public bool fromLoanlibrary { get; set; }
 
 }