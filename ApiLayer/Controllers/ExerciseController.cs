using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync() 
        { 
            var values= await _exerciseService.TGetAllAsync();
            return Ok(values);
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var value = await _exerciseService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost("AddExerciseExercise")]
        public async Task<IActionResult> AddExerciseAsync(Exercise exercise)
        {
            await _exerciseService.TAddAsync(exercise);
            return Ok("Başarıyla eklendi");
        }

       
        [HttpPatch("UpdateExercise")]
        public async Task<IActionResult> UpdateExerciseAsync(Exercise exercise)
        {
            await _exerciseService.TUpdateAsync(exercise);
            return Ok("Başarıyla güncellendi");
        }

        [HttpDelete("DeleteExercise")]
        public async Task<IActionResult> DeleteExerciseAsync(Exercise exercise)
        {
            await _exerciseService.TDeleteAsync(exercise);
            return Ok("Başarıyla silindi");
        }

        [HttpDelete("DeleteExerciseWithByIdAsync")]
        public async Task<IActionResult> DeleteExerciseWithByIdAsync(int id)
        {
            var exercise = await _exerciseService.TGetByIdAsync(id);
            await _exerciseService.TDeleteAsync(exercise);
            return Ok("Başarıyla silindi");
        }


    }
}
