using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine($"{item.BrandName} - {item.CarName} - {item.ColorName} - {item.DailyPrice}");
            }
            Console.WriteLine("-----------------");
            foreach (var item in carManager.GetByUnitPrice(11000,14000))
            {
                Console.WriteLine(item.CarName);
            }


            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.ColorName);
            //}


            //BrandManager brandManager = new(new EfBrandDal());
            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}

        }
    }
}
