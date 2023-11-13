using GymCrab.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Classes;

[Route("api/users")]
public class UserController : ControllerBase
{
    private UserService userService;

    public UserController()
    {
        userService = new UserService();
    }

    [HttpGet]
    [Route("{userId}")]
    public IActionResult GetUser(Guid userId)
    {
        var user = userService.GetUserById(userId);

        if (user == null)
        {
            return NotFound("User not found");
        }

        return Ok(user);
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = userService.GetAllUsers();
        return Ok(users);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] User user)
    {
        if (user == null)
        {
            return BadRequest("Invalid user data");
        }

        // You can add validation here

        var createdUser = userService.CreateUser(user.Username, user.Email, user.GetPassword(), user.Age, user.HeightInCentimeters, user.WeightInKilograms, user.Sex, user.ActivityLevel);

        return Created($"api/users/{createdUser.UserId}", createdUser);
    }

    [HttpPut]
    [Route("{userId}")]
    public IActionResult UpdateUser(Guid userId, [FromBody] User user)
    {
        if (user == null)
        {
            return BadRequest("Invalid user data");
        }

        // You can add validation here

        var existingUser = userService.GetUserById(userId);

        if (existingUser == null)
        {
            return NotFound("User not found");
        }

        // Update the user
        existingUser.Username = user.Username;
        existingUser.Email = user.Email;
        existingUser.Age = user.Age;
        existingUser.HeightInCentimeters = user.HeightInCentimeters;
        existingUser.WeightInKilograms = user.WeightInKilograms;
        existingUser.Sex = user.Sex;
        existingUser.ActivityLevel = user.ActivityLevel;

        userService.UpdateUser(existingUser);

        return Ok(existingUser);
    }

    [HttpDelete]
    [Route("{userId}")]
    public IActionResult DeleteUser(Guid userId)
    {
        var user = userService.GetUserById(userId);

        if (user == null)
        {
            return NotFound("User not found");
        }

        userService.DeleteUser(userId);

        return NoContent();
    }
}
