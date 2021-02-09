using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDao : ICarDal
    {
        List<Car> _cars = null;
        List<Color> _colors = null;
        List<Brand> _brands = null;

        public InMemoryCarDao()
        {
            _cars = new List<Car>()
            {
                new Car(){Id=1,ColorId=1,BrandId=1,DailyPrice=5000, Description="Güzel",ModelYear=2000},
                new Car(){Id=1,ColorId=2,BrandId=1,DailyPrice=5000, Description="Güzel",ModelYear=2000},
                new Car(){Id=1,ColorId=2,BrandId=1,DailyPrice=5000, Description="Güzel",ModelYear=2000},
                new Car(){Id=1,ColorId=4,BrandId=1,DailyPrice=5000, Description="Güzel",ModelYear=2000},
                new Car(){Id=1,ColorId=5,BrandId=1,DailyPrice=5000, Description="Güzel",ModelYear=2000},
            };

            _colors = new List<Color>()
            {
                new Color {ColorId=1,ColorName="Black"},
                new Color { ColorId=2, ColorName="White"},
                new Color { ColorId=3, ColorName="Grey"},
                new Color { ColorId=4, ColorName="Blue"},
                new Color { ColorId=5, ColorName="Yellow"},
                new Color { ColorId=6, ColorName="Cyan"},
            };

            _brands = new List<Brand>()
            {
                new Brand {BrandId=1,BrandName="Bmw"},
                new Brand {BrandId=2,BrandName="Audi"},
                new Brand {BrandId=3,BrandName="Toyota"},
                new Brand {BrandId=4,BrandName="Skoda"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.Find(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            cartoUpdate.Id = car.Id;
            cartoUpdate.BrandId = car.BrandId;
            cartoUpdate.ColorId = car.ColorId;
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.Description = car.Description;
            cartoUpdate.ModelYear = car.ModelYear;
        }
    }
}
