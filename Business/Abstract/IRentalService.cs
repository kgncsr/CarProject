using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService : IEntityService<Rental>
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
