using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadyTrainingController : ControllerBase
    {
        private readonly IReadyTrainingService _readyTrainingService;

        public ReadyTrainingController(IReadyTrainingService readyTrainingService)
        {
            _readyTrainingService = readyTrainingService;
        }

        [HttpGet("GetAllReadyTrainingAsync")]
        public async Task<IActionResult> GetAllReadyTrainingAsync()
        { 
            var values = await _readyTrainingService.TGetAllAsync();
            return Ok(values);
        }

        [HttpGet("GetReadyTrainingByIdAsync")]
        public async Task<IActionResult> GetReadyTrainingByIdAsync(int id)
        {
            var value = await _readyTrainingService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost("AddReadyTrainingAsync")]
        public async Task<IActionResult> AddReadyTrainingAsync(ReadyTraining readyTraining)
        {
             await _readyTrainingService.TAddAsync(readyTraining);
            return Ok("Başarıyla eklendi");
        }

        [HttpPatch("UpdateReadyTrainingAsync")]
        public async Task<IActionResult> UpdateReadyTrainingAsync(ReadyTraining readyTraining)
        {
           await _readyTrainingService.TUpdateAsync(readyTraining);
            return Ok("Başarıyla güncellendi");
        }

        [HttpDelete("DeleteReadyTrainingAsync")]
        public async Task<IActionResult> DeleteReadyTrainingAsync(ReadyTraining readyTraining)
        {
            await _readyTrainingService.TDeleteAsync(readyTraining);
            return Ok("Başarıyla silindi");
        }

        [HttpDelete("DeleteReadyTrainingWithByIdAsync")]
        public async Task<IActionResult> DeleteReadyTrainingWithByIdAsync(int id)
        {
            var readyTraining = await _readyTrainingService.TGetByIdAsync(id);
            await _readyTrainingService.TDeleteAsync(readyTraining);
            return Ok("Başarıyla silindi");
        }

    }
}
