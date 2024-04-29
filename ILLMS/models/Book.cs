namespace ILLMS.models;

public class Book
{
    public Book(string title, string author, string category, bool availability)
    {
        this.title = title;
        this.author = author;
        this.category = category;
        this.availability = availability;
    }

    public string title { get; set; }
    public string author { get; set; }
    public string category { get; set; }
    public bool availability { get; set; } 

}