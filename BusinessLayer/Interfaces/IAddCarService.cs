﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IAddCarService
    {
        Task CreateCar(TblCar car);

    }
}
