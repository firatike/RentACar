using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        //static void Main(string[] args)
        //{
        //    Test();
        //    RentalTest();
        //    GetCarDetailsTest();

        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(new Car
        //    {
        //        BrandId = 3,
        //        ColorId = 3,
        //        CarName = "Ddd",
        //        Descriptions = "Rar",
        //        ModelYear = 2020,
        //        DailyPrice = 380
        //    });


        //    foreach (var car in carManager.GetAll().Data)
        //    {
        //        Console.WriteLine(car.CarId+" / "+car.ColorId+" / "+car.BrandId+" / "+car.ModelYear+" / "+car.DailyPrice+" / "+car.Descriptions);
        //    }

        //    CarManager carManager = new CarManager(new EfCarDal());
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    foreach (var car in carManager.GetCarDetail().Data)
        //    {
        //        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        //    }

        //    foreach (var brand in brandManager.GetAll().Data)
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }

        //    foreach (var color in colorManager.GetAll().Data)
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }


        //    Console.ReadKey();
        //}

        //private static void GetCarDetailsTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetail();
        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarName + " / " + car.ColorName + " / " + car.BrandName);
        //        }
        //    }
        //}

        //private static void RentalTest()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //    foreach (var rental in rentalManager.GetAll())
        //    {
        //        Console.WriteLine(rental.RentalId + " " + rental.CarId + " " + rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
        //    }

        //    Console.ReadKey();
        //}

        //public static void Test()
        //{
        //    carManager.Update(new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 1111, DailyPrice = 111, Descriptions = "Deneme1", CarName = "DEnemee1" });

        //    carManager.Add(new Car { BrandId = 33, ColorId = 33, ModelYear = 3333, DailyPrice = 333, Descriptions = "Deneme3", CarName = "Denemee3" });

        //    carManager.Delete(new Car { CarId = 8 });

        //    CarManager carManager = new CarManager(new EfCarDal());
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + " " + car.CarName + " " + car.ModelYear + " " + car.DailyPrice + " " + car.BrandId + " " + car.ColorId + " " + car.Descriptions);

        //    }

        //    Console.WriteLine("------------------------------------------");

        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorId + " " + color.ColorName);
        //    }

        //    Console.WriteLine("------------------------------------------");

        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandId + " " + brand.BrandName);
        //    }
        //}
    }
}
