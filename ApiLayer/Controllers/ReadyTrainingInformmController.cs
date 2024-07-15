using BusinessLayer.Abstract;
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


            
    }
}
