namespace GymCrab.Classes
{
    class Workout
    {
        public List<Exercise> Exercises { get; private set; }
        public DateTime WorkoutDate { get; private set; }

        public Workout(DateTime workoutDate)
        {
            Exercises = new List<Exercise>();
            WorkoutDate = workoutDate;
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public void DeleteExercise(Exercise exercise)
        {
            Exercises.Remove(exercise);
        }

        public double CalculateTotalCaloriesBurned()
        {
            double totalCaloriesBurned = 0.0;
            foreach (Exercise exercise in Exercises)
            {
                totalCaloriesBurned += exercise.CalculateCaloriesBurned();
            }
            return totalCaloriesBurned;
        }
    }


}
