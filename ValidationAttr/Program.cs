using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

public class ValidationExample
{
    public static void Main()
    {
        User user = new User
        {
            Name = "John Doe",
            Age = 30,
            Email = "johndoe@example.com"
        };

        Validator.ValidateObject(user, new ValidationContext(user), true);
        Console.WriteLine("Validation passed!");
        Console.ReadKey();
    }
}

public class User
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Range(18, 60, ErrorMessage = "Age should be between 18 and 60")]
    public int Age { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }
}