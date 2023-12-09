using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymCrab333333333.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }

        public MainstreamExercise ExerciseType { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double WeightUsed { get; set; } // Weight used in kilograms
        public int Duration { get; set; } // Duration in minutes
        public Workout Workout { get; set; }

        // Public parameterless constructor for model binding
        public Exercise()
        {
        }

        public Exercise(MainstreamExercise exerciseType, int sets, int reps, double weightUsed, int duration)
        {
            ExerciseType = exerciseType;
            Sets = sets;
            Reps = reps;
            WeightUsed = weightUsed;
            Duration = duration;
        }

        public double CalculateCaloriesBurned()
        {
            if (ExerciseType == MainstreamExercise.Walking || ExerciseType == MainstreamExercise.Running)
            {
                // For walking and running, use a method that considers duration
                return CalculateCaloriesBurnedWithDuration();
            }
            else
            {
                // For other exercises, use the simplified formula
                return (GetMETValue(ExerciseType) * WeightUsed * Sets * Reps) / 200;
            }
        }

        private double CalculateCaloriesBurnedWithDuration()
        {
            double metValue = GetMETValue(ExerciseType);
            double totalHours = Duration / 60.0; // Convert minutes to hours
            return (metValue * WeightUsed * totalHours);
        }

        private double GetMETValue(MainstreamExercise exerciseType)
        {
            // Define MET values for different exercises
            switch (exerciseType)
            {
                case MainstreamExercise.Squats:
                    return 4.0; // MET value for squats
                case MainstreamExercise.Deadlift:
                    return 5.0; // MET value for deadlift
                case MainstreamExercise.BenchPress:
                    return 3.0; // MET value for bench press
                case MainstreamExercise.Walking:
                    return 3.9; // MET value for walking
                case MainstreamExercise.Running:
                    return 7.0; // MET value for running
                // Add MET values for other exercises as needed
                default:
                    return 1.0; // Default MET value (e.g., for rest)
            }
        }

        public override string ToString()
        {
            return $"{ExerciseType} - Sets: {Sets}, Reps: {Reps}, Weight Used: {WeightUsed} kg, Duration: {Duration} minutes";
        }
    }

    public enum MainstreamExercise
    {
        Squats,
        Deadlift,
        BenchPress,
        LegPress,
        PushUps,
        PullUps,
        Walking,
        Running
        // Add more exercises as needed
    }
}
