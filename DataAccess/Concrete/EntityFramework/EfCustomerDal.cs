using System;
using Core.DataAccess.EntityFramework;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,CarContext>,ICustomerDal
    {
    }
}
