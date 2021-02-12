using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {
      
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetById(2).ColorName);

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(2).BrandName);

            //brandManager.Add(new Brand { BrandName = "Opel" });
            //brandManager.Update(new Brand { BrandID = 2, BrandName = "Merco" });
         
            brandManager.Delete(6);

            //colorManager.Add(new Color { ColorName = "Yellow" });
            //colorManager.Update(new Color { ColorID = 3, ColorName = "Mavi" });
            //colorManager.Delete(7);



        }
    }
}
