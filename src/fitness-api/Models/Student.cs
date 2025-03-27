using System.ComponentModel.DataAnnotations;

namespace fitness_api.Models;

public class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    [Required]
    public DateTime DateOfBirth { get; set; }

    // Navigation property
    public virtual ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
}