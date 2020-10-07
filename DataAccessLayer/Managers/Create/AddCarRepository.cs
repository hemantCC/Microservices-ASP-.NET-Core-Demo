using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using EntityLayer.Models;

namespace DataAccessLayer.Managers.Create
{
    public class AddCarRepository : IAddCarRepository
    {
        private readonly DbMicroservicesDemoContext _context;
        public AddCarRepository(DbMicroservicesDemoContext _context)
        {
            this._context = _context;
        }

        public async Task CreateCar(TblCar car)
        {
            await _context.TblCar.AddAsync(car);
            await _context.SaveChangesAsync();
        }
    }
}
