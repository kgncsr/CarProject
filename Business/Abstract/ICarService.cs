using Entities;
using Entities.Concrete;
using Entities.Concrete.CDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByBrandId(int brandId);
        List<DtoCarDetail> GetCarDetail();
    }
}
