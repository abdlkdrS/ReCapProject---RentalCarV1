﻿using Core.Utilities.Results;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByCarId(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetByModelYear(int year);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);
    }
}
