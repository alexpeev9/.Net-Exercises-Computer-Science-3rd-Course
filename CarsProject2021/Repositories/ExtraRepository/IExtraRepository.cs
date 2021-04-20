using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.ExtraRepository
{
    public interface IExtraRepository
    {
        IEnumerable<Extra> GetAllExtras { get; }
        Extra GetExtraByName(string name);
    }
}
