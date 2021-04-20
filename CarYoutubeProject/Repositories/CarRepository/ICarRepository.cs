namespace Repositories.CarRepository
{
    using Models;
    using System.Collections.Generic;
    public interface ICarRepository
    {
        Car GetCarById(int id);
        Car GetCarByModel(string model);
        IEnumerable<Car> GetAllCars { get; }
        int Add(Car car);
        void Update(Car car);
        void Delete(int car);
    }
}
