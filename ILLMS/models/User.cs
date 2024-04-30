namespace ILLMS.models;

public class User
{
    public User(){}
    public User(int userId, string email, string password)
    {
        this.userId = userId;
        this.email = email;
        this.password = password;
    }
    public int userId { get; set; }
    public string email { get; set; }
    
    public string password { get; set; }
}