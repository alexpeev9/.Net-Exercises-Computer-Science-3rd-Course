namespace DataAccess.Repositories.Interfaces
{
    using DataStructure;
    using System.Collections.Generic;
    public interface ICarRepository
    {
        Car Car(int id);
        IEnumerable<Car> Cars { get; }
        void Add(Car car);
        void Edit(Car car);
        void Delete(Car car);
    }
}
