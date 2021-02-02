using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    CarId = 1, CarBrandId = 1, CarColorId= 1, CarDailyPrice = 500000, 
                    CarDescription = "BMW", CarModalYear = 2020
                },
                new Car
                {
                    CarId = 2, CarBrandId = 1, CarColorId= 2, CarDailyPrice = 200000,
                    CarDescription = "BMW", CarModalYear = 2019
                },
                new Car
                {
                    CarId = 3, CarBrandId = 1, CarColorId= 3, CarDailyPrice = 100000,
                    CarDescription = "BMW", CarModalYear = 2018
                },
                new Car
                {
                    CarId = 4, CarBrandId = 2, CarColorId= 1, CarDailyPrice = 300000,
                    CarDescription = "VOLKSWAGEN", CarModalYear = 1996
                },
                new Car
                {
                    CarId = 5, CarBrandId = 2, CarColorId= 1, CarDailyPrice = 400000,
                    CarDescription = "VOLKSWAGEN", CarModalYear = 2015
                }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(p => p.CarBrandId == brandId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.CarModalYear = car.CarModalYear;
        }
    }
}
