using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeleteService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        private readonly IDeleteCarService _deleteCarService;
        public DeleteController(IDeleteCarService _deleteCarService)
        {
            this._deleteCarService = _deleteCarService;
        }

        [HttpDelete]
        [Route("DeleteCar/{id}")]
        public async Task<IActionResult> UpdateCar(int id)
        {
            await _deleteCarService.DeleteCar(id);
            return Ok();
        }
    }
}