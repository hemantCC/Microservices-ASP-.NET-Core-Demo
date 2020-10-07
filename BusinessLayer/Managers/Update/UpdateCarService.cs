using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using EntityLayer.Models;

namespace BusinessLayer.Managers.Update
{
    public class UpdateCarService : IUpdateCarService
    {
        private readonly IUpdateCarRepository _updateCarRepository;
        public UpdateCarService(IUpdateCarRepository _updateCarRepository)
        {
            this._updateCarRepository = _updateCarRepository;
        }

        public async Task UpdateCar(TblCar car)
        {
            await _updateCarRepository.UpdateCar(car);
        }
    }
}
