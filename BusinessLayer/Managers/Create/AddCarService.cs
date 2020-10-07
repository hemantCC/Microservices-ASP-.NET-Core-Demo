using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using EntityLayer.Models;

namespace BusinessLayer.Managers
{
    public class AddCarService : IAddCarService
    {
        private readonly IAddCarRepository _addCarRepository;
        public AddCarService(IAddCarRepository _addCarRepository)
        {
            this._addCarRepository = _addCarRepository;
        }
        public async Task CreateCar(TblCar car)
        {
            await _addCarRepository.CreateCar(car);
        }
    }
}
