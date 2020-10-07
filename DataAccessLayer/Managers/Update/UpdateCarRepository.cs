using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using EntityLayer.Models;

namespace DataAccessLayer.Managers.Update
{
    public class UpdateCarRepository : IUpdateCarRepository
    {
        private readonly DbMicroservicesDemoContext _context;
        public UpdateCarRepository(DbMicroservicesDemoContext _context)
        {
            this._context = _context;
        }
        public async Task UpdateCar(TblCar car)
        {
            _context.Update(car);
            await _context.SaveChangesAsync();
        }
    }
}
