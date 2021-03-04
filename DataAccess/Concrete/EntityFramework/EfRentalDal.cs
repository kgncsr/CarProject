using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using(var context = new CarContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarID equals ca.CarID
                             join cu in context.Customers
                             on re.CustomerID equals cu.UserID
                             join us in context.Users
                             on cu.UserID equals us.UserID
                             select new RentalDetailDto
                             {
                                 Id=re.CarID,
                                 Description=ca.Descriptions,
                                 CompanyName=cu.CompanyName,
                                 RentDate=re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();
            }
        }

    }
}