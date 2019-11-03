using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POSTS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutsController : ControllerBase
    {
        private readonly Models.WorkoutContext _context;

        public WorkoutsController(Models.WorkoutContext context)
        {
            _context = context;
        }
        // GET: api/Workouts
        [HttpGet]
        public IEnumerable<Models.Workout> GetWorkout()
        {
            var t = _context.Workouts.ToList();
            return t;
        }
        // POST: api/Workouts
        [HttpPost]
        public async Task<IActionResult> PostWorkout([FromBody] Models.Workout workout)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Workouts.Add(workout);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkout", new { id = workout.WorkoutID }, workout);
        }
        // DELETE: api/Workouts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkout([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var workout = _context.Workouts.SingleOrDefault(m => m.WorkoutID == id);
            if (workout == null)
            {
                return NotFound();
            }

            _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();

            return Ok(workout);
        }
    }
}