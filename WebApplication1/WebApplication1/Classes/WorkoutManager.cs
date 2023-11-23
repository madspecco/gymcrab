namespace GymCrab.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

        public List<DateTime> GetLast7WorkoutDates()
        {
            if (Workouts.Count == 0)
            {
                return new List<DateTime>(); // Return an empty list if there are no workouts
            }

            List<DateTime> last7Dates = Workouts
                .OrderByDescending(w => w.WorkoutDate)
                .Take(7)
                .Select(w => w.WorkoutDate)
                .ToList();

            return last7Dates;
        }
    }
}
