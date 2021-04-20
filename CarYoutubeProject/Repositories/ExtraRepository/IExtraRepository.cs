using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.ExtraRepository
{
    public interface IExtraRepository
    {
        IEnumerable<Extra> GetAllExtras { get; }
        Extra GetExtraByName(string name);
    }
}
