using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitness_api.Models;

public class Exercise
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int StudentId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public int Duration { get; set; } // in minutes

    public string? Comments { get; set; }

    // Navigation property
    [ForeignKey("StudentId")]
    public virtual Student? Student { get; set; }
}