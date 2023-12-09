using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car { Id=5,Description = "Ela" });
            carManager.Update(new Car {Id=1,BrandId=7,ColorId=7,DailyPrice=77777,ModelYear=1977,Description="7777777" });
            foreach (Car item in carManager.GetAll())
            {
                Console.WriteLine($"{item.Id} - {item.BrandId} - {item.ColorId} - {item.ModelYear} - {item.DailyPrice} - {item.Description}");
            }
            Console.WriteLine("\n---------------------------------------------\n");
            carManager.Delete(new Car { Id = 5});
            foreach (Car item in carManager.GetAll())
            {
                Console.WriteLine($"{item.Id} - {item.BrandId} - {item.ColorId} - {item.ModelYear} - {item.DailyPrice} - {item.Description}");
            }
            Console.WriteLine("\n---------------------------------------------\n");
            Console.WriteLine($"{carManager.GetById(4).Id} - {carManager.GetById(4).BrandId} - {carManager.GetById(4).ColorId} - {carManager.GetById(4).ModelYear} - {carManager.GetById(4).DailyPrice} - {carManager.GetById(4).Description}");
        }
    }
}
