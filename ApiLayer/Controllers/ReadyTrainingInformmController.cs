using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadyTrainingInformmController : ControllerBase
    {
        private readonly IReadyTrainingInformService _readyTrainingInformService;

        public ReadyTrainingInformmController(IReadyTrainingInformService readyTrainingInformService)
        {
            _readyTrainingInformService = readyTrainingInformService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
        
            var values = await _readyTrainingInformService.TGetAllAsync();
            return Ok(values);
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var value = await _readyTrainingInformService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost("AddReadyTrainingInformAsync")]
        public async Task<IActionResult> AddReadyTrainingInformAsync(ReadyTrainingInform readyTrainingInform)
        {
            await _readyTrainingInformService.TAddAsync(readyTrainingInform);
            return Ok("Başarıyla eklendi");
        }


        [HttpPatch("UpdateReadyTrainingInform")]
        public async Task<IActionResult> UpdatereadyTrainingInformAsync(ReadyTrainingInform readyTrainingInform)
        {
            await _readyTrainingInformService.TUpdateAsync(readyTrainingInform);
            return Ok("Başarıyla güncellendi");
        }

        [HttpDelete("DeleteReadyTrainingInform")]
        public async Task<IActionResult> DeleteExerciseAsync(ReadyTrainingInform readyTrainingInform)
        {
            await _readyTrainingInformService.TDeleteAsync(readyTrainingInform);
            return Ok("Başarıyla silindi");
        }

        [HttpDelete("DeleteReadyTrainingInformWithByIdAsync")]
        public async Task<IActionResult> DeleteExerciseWithByIdAsync(int id)
        {
            var readyTrainingInform = await _readyTrainingInformService.TGetByIdAsync(id);
            await _readyTrainingInformService.TDeleteAsync(readyTrainingInform);
            return Ok("Başarıyla silindi");
        }




    }
}
