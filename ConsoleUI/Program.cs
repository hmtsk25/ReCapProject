using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"Id= {car.Id}, BrandId={car.BrandId}, ColorId={car.ColorId}, ModelYear={car.ModelYear}, Description={car.Description}, DailyPrice={car.DailyPrice}");
            }
        }
    }
}
