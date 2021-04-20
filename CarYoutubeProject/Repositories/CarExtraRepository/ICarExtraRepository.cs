using Models;
using System.Collections.Generic;

namespace Repositories.CarExtraRepository
{
    public interface ICarExtraRepository
    {
        void Add(CarExtra carextra);
        ICollection<CarExtra> GetCarExtras(int carId);
    }
}
