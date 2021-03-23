using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=180,Descriptions="BMW"},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=2019,DailyPrice=160,Descriptions="Passat"},
                new Car{CarId=3,BrandId=3,ColorId=2,ModelYear=2019,DailyPrice=150,Descriptions="Wolswagen"},
                new Car{CarId=4,BrandId=4,ColorId=3,ModelYear=2015,DailyPrice=120,Descriptions="Renault Clio 1.2 Joy"},
                new Car{CarId=5,BrandId=5,ColorId=1,ModelYear=2020,DailyPrice=170,Descriptions="Toyota"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _car.Where(c => c.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Descriptions = car.Descriptions;
        }
    }
}
