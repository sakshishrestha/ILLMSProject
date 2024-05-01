using ILLMS.models;

namespace ILLMS.service;

public class UserRepository
{
    private List<User> users = new List<User>();
    private  User currentUser;
    private bool isUserLoggedIn = false;

    public UserRepository()
    {
        users.Add(new User(1, "johndoe@etsu.edu", "password"));

    }
    public User getCurrentUser()
    {
        User user = this.currentUser;
        return user;
    }

    public  void setIsUserLoggedIn(bool isUserLoggedIn)
    {
        this.isUserLoggedIn = isUserLoggedIn;
    }
    
    public bool getIsUserLoggedIn()
    {
        return isUserLoggedIn;
    }

    public  void setCurrentUser(User user)
    {
        this.currentUser = user;
    }
    
    public User GetUserByEmailPassword(string email, string password)
    {
        return users.FirstOrDefault(b => String.Equals(b.email, email) && String.Equals(b.password, password));
    }

    public async Task<User> Login(string email, string password)
    {
        return await Task.Run(() => users.FirstOrDefault(u => u.email == email && u.password == password));
    }
    // register new user
    public void RegisterUser(User user)
    {
        // Generate unique user ID
        user.userId = users.Count + 1;

        // Add user to list of users
        users.Add(user);
    }

}