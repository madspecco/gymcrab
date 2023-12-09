namespace GymCrab333333333.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class WorkoutManager
    {

        [Key]
        public int WorkoutManagerId { get; set; }


        [ForeignKey("WorkoutManager")]
        public int UserId { get; set; }




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
