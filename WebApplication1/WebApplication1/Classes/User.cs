using GymCrab.Classes;
using System.Data;

namespace WebApplication1.Classes
{
    public class User
    {
        private WorkoutManager workoutManager;
        private CrabEntity crabEntity;

        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }

        public string GetPassword()
        {
            return Password;
        }






        public int Sex { get; set; }
        public int Age { get; set; }
        public double HeightInCentimeters { get; set; }
        public double WeightInKilograms { get; set; }
        public ActivityLevel ActivityLevel { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;

            Age = 18;
            HeightInCentimeters = 170;
            WeightInKilograms = 50;
            Sex = 1;
            workoutManager = new WorkoutManager(); // Initialize a new WorkoutManager
            crabEntity = new CrabEntity();
        }

        public CrabEntity GetCrabEntity()
        {
            return crabEntity;
        }

    }

    public enum ActivityLevel
    {
        Sedentary,
        LightlyActive,
        ModeratelyActive,
        VeryActive,
    }

}
