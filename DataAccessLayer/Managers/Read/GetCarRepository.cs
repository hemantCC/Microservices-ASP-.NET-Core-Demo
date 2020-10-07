using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces.Read;
using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Managers.Read
{
    public class GetCarRepository:IGetCarRepository
    {
        private readonly DbMicroservicesDemoContext _context;
        public GetCarRepository(DbMicroservicesDemoContext _context)
        {
            this._context = _context;
        }

        public async Task<IEnumerable<TblCar>> GetCars()
        {
            return await _context.TblCar.ToListAsync();
        }
    }
}
