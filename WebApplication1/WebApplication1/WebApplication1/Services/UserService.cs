namespace GymCrab.Services
{
    using System;
    using System.Collections.Generic;
    using WebApplication1.Classes;

    public class UserService
    {
        private List<User> users; // Replace with a database or data store

        public UserService()
        {
            users = new List<User>();
        }

        public User CreateUser(string username, string email, string password, int age, double height, double weight, int sex, ActivityLevel activityLevel)
        {
            // You can add validation and password hashing here
            User user = new User(username, email, password)
            {
                Age = age,
                HeightInCentimeters = height,
                WeightInKilograms = weight,
                Sex = sex,
            };

            users.Add(user); // Replace with database insertion
            return user;
        }

        public User GetUserById(Guid userId)
        {
            return users.Find(u => u.UserId == userId); // Replace with database query
        }

        public List<User> GetAllUsers()
        {
            return users; // Replace with a database query to retrieve all users
        }

        public void UpdateUser(User updatedUser)
        {
            User existingUser = GetUserById(updatedUser.UserId);
            if (existingUser != null)
            {
                existingUser.Username = updatedUser.Username;
                existingUser.Age = updatedUser.Age;
                existingUser.HeightInCentimeters = updatedUser.HeightInCentimeters;
                existingUser.WeightInKilograms = updatedUser.WeightInKilograms;
                existingUser.Sex = updatedUser.Sex;
            }
        }

        public void DeleteUser(Guid userId)
        {
            User user = GetUserById(userId);
            if (user != null)
            {
                users.Remove(user); // Remove from the in-memory list
                                    // Replace with database delete logic
            }
        }
    }

}
