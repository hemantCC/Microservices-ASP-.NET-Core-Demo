using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using EntityLayer.Models;

namespace BusinessLayer.Managers.Delete
{
    
    
    public class DeleteCarService : IDeleteCarService
    {
        private readonly IDeleteCarRepository _deleteCarRepository;
        public DeleteCarService(IDeleteCarRepository _deleteCarRepository)
        {
            this._deleteCarRepository = _deleteCarRepository;
        }

        public async Task DeleteCar(int id)
        {
            await _deleteCarRepository.DeleteCar(id);
        }
    }
}
