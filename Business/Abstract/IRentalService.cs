﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService 
    {
        IDataResult<List<Rental>> GetAll();
        IResult Update(Rental entity);
        IResult Delete(Rental entity);
        IResult Add(Rental entity);
    }
}
