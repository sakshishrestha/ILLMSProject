public class RegisteredUser
{
        public RegisteredUser(string username, string password, string email, DateTime dateOfBirth, string firstName, string lastName, string phoneNumber, string institutionalRole, bool isRegistered, bool multifactorAuthenticationEnabled)
        {
            Username = username;
            Password = password;
            Email = email;
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            InstitutionalRole = institutionalRole;
            IsRegistered = isRegistered;
            MultifactorAuthenticationEnabled = multifactorAuthenticationEnabled;
        }
        

    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string InstitutionalRole { get; set; }
    public bool IsRegistered { get; set; }
    public bool MultifactorAuthenticationEnabled { get; set; }
}