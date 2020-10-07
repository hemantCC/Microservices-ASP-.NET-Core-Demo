using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Models;

namespace DataAccessLayer.Interfaces.Read
{
    public interface IGetCarRepository
    {
        Task<IEnumerable<TblCar>> GetCars();
    }
}
