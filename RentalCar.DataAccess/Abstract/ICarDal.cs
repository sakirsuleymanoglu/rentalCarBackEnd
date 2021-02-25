﻿using System;
using System.Collections.Generic;
using System.Text;
using RentalCar.Core.DataAccess;
using RentalCar.Core.Utilities.Results;
using RentalCar.Entities.Concrete;

namespace RentalCar.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
    }
}
