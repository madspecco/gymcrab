namespace GymCrab.Classes
{
    class WorkoutManager
    {
        public List<Workout> Workouts { get; private set; }

        public WorkoutManager()
        {
            Workouts = new List<Workout>();
        }

        public void AddWorkout(Workout workout)
        {
            Workouts.Add(workout);
        }

        public void DeleteWorkout(Workout workout)
        {
            Workouts.Remove(workout);
        }
    }
}
