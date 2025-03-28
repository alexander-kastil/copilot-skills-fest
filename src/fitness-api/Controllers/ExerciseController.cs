using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using fitness_api.Data;
using fitness_api.Models;

namespace fitness_api.Controllers;

[ApiController]
[Route("api")]
public class ExerciseController : ControllerBase
{
    private readonly FitnessDBContext _dbContext;

    public ExerciseController(FitnessDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("Students")]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        var result = await _dbContext.Students.ToListAsync();
        return result;
    }

    [HttpGet("Students/{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id)
    {
        var student = await _dbContext.Students
            .Include(s => s.Exercises)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (student == null)
        {
            return NotFound();
        }

        return student;
    }

    [HttpGet("exercises")]
    public async Task<ActionResult<IEnumerable<Exercise>>> GetExercises()
    {
        return await _dbContext.Exercises.Include(e => e.Student).ToListAsync();
    }

    [HttpPost("exercises")]
    public async Task<ActionResult<Exercise>> CreateExercise(Exercise exercise)
    {
        // Check if student exists
        var studentExists = await _dbContext.Students.AnyAsync(s => s.Id == exercise.StudentId);
        if (!studentExists)
        {
            return BadRequest($"Student with ID {exercise.StudentId} does not exist");
        }

        _dbContext.Exercises.Add(exercise);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetExercises), new { id = exercise.Id }, exercise);
    }
}