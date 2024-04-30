namespace ILLMS.models;


public class CheckoutDetail
{
    public CheckoutDetail(int checkoutId, string email, int bookId, DateOnly checkoutDate, DateOnly returnDate)
    {
        this.checkoutId = checkoutId;
        this.email = email;
        this.bookId = bookId;
        this.checkoutDate = checkoutDate;
        this.returnDate = returnDate;
    }

    public int checkoutId { get; set; }
    public string email { get; set; }
    public int bookId { get; set; }
    public DateOnly checkoutDate { get; set; }
    public DateOnly returnDate { get; set; }
}