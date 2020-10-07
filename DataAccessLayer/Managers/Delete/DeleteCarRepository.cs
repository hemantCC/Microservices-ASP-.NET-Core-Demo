using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using EntityLayer.Models;

namespace DataAccessLayer.Managers.Delete
{
    public class DeleteCarRepository : IDeleteCarRepository
    {
        private readonly DbMicroservicesDemoContext _context;
        public DeleteCarRepository(DbMicroservicesDemoContext _context)
        {
            this._context = _context;
        }
        public async Task DeleteCar(int id)
        {
            TblCar car = await _context.TblCar.FindAsync(id);
            _context.TblCar.Remove(car);
            await _context.SaveChangesAsync();
        }
    }
}
