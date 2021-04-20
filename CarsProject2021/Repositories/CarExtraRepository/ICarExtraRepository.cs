namespace Repositories.CarExtraRepository
{
    using Models;
    using System.Collections.Generic;

    public interface ICarExtraRepository
    {
        void Add(CarExtra carextra);
        ICollection<CarExtra> GetCarExtras(int carId);
    }
}
