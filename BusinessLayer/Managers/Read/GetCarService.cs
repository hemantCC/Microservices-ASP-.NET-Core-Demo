using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces.Read;
using EntityLayer.Models;

namespace BusinessLayer.Managers.Read
{
    public class GetCarService : IGetCarService
    {
        private readonly IGetCarRepository _carRepository;
        public GetCarService(IGetCarRepository _carRepository)
        {
            this._carRepository = _carRepository;
        }
        public Task<IEnumerable<TblCar>> GetCars()
        {
            return _carRepository.GetCars();
        }
    }
}
