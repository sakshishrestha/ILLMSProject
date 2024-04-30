using System;
using System.Collections.Generic;
using System.Linq;
using ILLMS.models;

namespace ILLMS.service
{
    public class RegisteredUserHandler
    {
        private List<RegisteredUser> users = new List<RegisteredUser>();

        public RegisteredUserHandler()
        {
            // Add some initial data for demonstration
            users.Add(new RegisteredUser("johndoe", "password123", "johndoe@example.com", new DateTime(1990, 5, 15), "John", "Doe", "1234567890", "Student", false, false));
            users.Add(new RegisteredUser("janedoe", "password456", "janedoe@example.com", new DateTime(1985, 8, 20), "Jane", "Doe", "0987654321", "Faculty", true, true));
        }

        // Create
        public void AddUser(RegisteredUser user)
        {
            users.Add(user);
        }

        // Read
        // public List<RegisteredUser> GetAllUsers()
        // {
        //     return users;
        // }
        
        public List<RegisteredUser> GetAllUsers(bool isRegistered = true)
        {
            if (isRegistered)
            {
                return users.Where(u => u.IsRegistered).ToList();
            }
            else
            {
                return users;
            }
        }

        public RegisteredUser GetUserByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }

        // Update
        public void UpdateUser(RegisteredUser updatedUser)
        {
            var existingUser = users.FirstOrDefault(u => u.Username == updatedUser.Username);
            if (existingUser != null)
            {
                // Update user properties
                existingUser.Password = updatedUser.Password;
                existingUser.Email = updatedUser.Email;
                existingUser.DateOfBirth = updatedUser.DateOfBirth;
                existingUser.FirstName = updatedUser.FirstName;
                existingUser.LastName = updatedUser.LastName;
                existingUser.PhoneNumber = updatedUser.PhoneNumber;
                existingUser.InstitutionalRole = updatedUser.InstitutionalRole;
                existingUser.IsRegistered = updatedUser.IsRegistered;
                existingUser.MultifactorAuthenticationEnabled = updatedUser.MultifactorAuthenticationEnabled;
            }
        }

        // Delete
        public void DeleteUser(string username)
        {
            var userToDelete = users.FirstOrDefault(u => u.Username == username);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
            }
        }
    }
}
