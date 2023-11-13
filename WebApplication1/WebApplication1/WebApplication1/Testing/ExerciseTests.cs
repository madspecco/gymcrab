using Microsoft.VisualStudio.TestTools.UnitTesting;
using GymCrab.Classes;

[TestClass]
public class ExerciseTests
{
    [TestMethod]
    public void TestCalculateCaloriesBurned_Squats()
    {
        // Arrange
        var exercise = new Exercise(MainstreamExercise.Squats, 5, 5, 60, 60);

        // Act
        double caloriesBurned = exercise.CalculateCaloriesBurned();

        // Assert
        Assert.AreEqual(300, caloriesBurned, 0.01); // Approximate result with a small margin of error
    }

    [TestMethod]
    public void TestCalculateCaloriesBurned_Walking()
    {
        // Arrange
        var exercise = new Exercise(MainstreamExercise.Walking, 0, 0, 0, 60); // Duration is 60 minutes

        // Act
        double caloriesBurned = exercise.CalculateCaloriesBurned();

        // Assert
        Assert.AreEqual(234, caloriesBurned, 0.01); // Approximate result with a small margin of error
    }

    [TestMethod]
    public void TestCalculateCaloriesBurned_Running()
    {
        // Arrange
        var exercise = new Exercise(MainstreamExercise.Running, 0, 0, 0, 60); // Duration is 60 minutes

        // Act
        double caloriesBurned = exercise.CalculateCaloriesBurned();

        // Assert
        Assert.AreEqual(420, caloriesBurned, 0.01); // Approximate result with a small margin of error
    }

    [TestMethod]
    public void TestCalculateCaloriesBurned_OtherExercise()
    {
        // Arrange
        var exercise = new Exercise(MainstreamExercise.BenchPress, 5, 5, 60, 0); // Duration is 0 minutes

        // Act
        double caloriesBurned = exercise.CalculateCaloriesBurned();

        // Assert
        Assert.AreEqual(300, caloriesBurned, 0.01); // Approximate result with a small margin of error
    }
}
