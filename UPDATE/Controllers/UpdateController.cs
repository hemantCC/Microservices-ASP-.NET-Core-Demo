using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace UpdateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        private readonly IUpdateCarService _updateCarService;
        public UpdateController(IUpdateCarService _updateCarService)
        {
            this._updateCarService = _updateCarService;
        }

        [HttpPut]
        [Route("UpdateCar")]
        public async Task<IActionResult> UpdateCar(TblCar car)
        {
            await _updateCarService.UpdateCar(car);
            return Ok();
        }
    }
}