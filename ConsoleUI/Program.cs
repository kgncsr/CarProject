using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
//CarRental Projenizde Core katmanı oluşturunuz.
//IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.
//Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.
//Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
//Arabaları şu bilgiler olacak şekilde listeleyiniz.CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDao());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.ModelYear);
            }
        }
    }
}
