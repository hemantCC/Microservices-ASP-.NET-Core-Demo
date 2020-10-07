using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        private readonly IAddCarService _addCarService;
        public AddController(IAddCarService _addCarService)
        {
            this._addCarService = _addCarService;
        }

        [HttpPost]
        [Route("AddCar")]
        public async Task AddCar(TblCar car)
        {
            await _addCarService.CreateCar(car);
        }
    }
}