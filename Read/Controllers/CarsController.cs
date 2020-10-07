using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Read.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IGetCarService _carService;

        public CarsController(IGetCarService _carService)
        {
            this._carService = _carService;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblCar>>> GetTblCar()
        {
            return Ok(await _carService.GetCars());
        }

       
    }
}
