namespace ILLMS.models;

public class User
{
    public User(){}
    public User(int userId, string email, string password, DateTime dateOfBirth = default, string firstName = null, string lastName=null, string phoneNumber=null, string institutionalRole=null, bool isRegistered = false, bool multiFactorAuthenticationEnabled = false)
    {
        this.userId = userId;
        this.email = email;
        this.password = password;
        this.dateOfBirth = dateOfBirth;
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
        this.institutionalRole = institutionalRole;
        this.isRegistered = isRegistered;
        this.multiFactorAuthenticationEnabled = multiFactorAuthenticationEnabled;
    }
    public int userId { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public DateTime dateOfBirth { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string phoneNumber { get; set; }
    public string institutionalRole { get; set; }
    public bool isRegistered { get; set; }
    public bool multiFactorAuthenticationEnabled { get; set; }
}


// namespace ILLMS.models;

// public class User
// {
//     public User(){}
//     public User(int userId, string email, string password)
//     {
//         this.userId = userId;
//         this.email = email;
//         this.password = password;
//     }
//     public int userId { get; set; }
//     public string email { get; set; }
    
//     public string password { get; set; }
// }