using Core.Utilities.Results;
using Entities;
using Entities.Concrete;
using Entities.Concrete.CDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IEntityService<Car>
    {
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<DtoCarDetail>> GetCarDetail();
    }
}
