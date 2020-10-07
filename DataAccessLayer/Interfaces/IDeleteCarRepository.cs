using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Models;

namespace DataAccessLayer.Interfaces
{
    public interface IDeleteCarRepository
    {
        Task DeleteCar(int id); 
    }
}
