using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public interface IExtraRepository
    {
        void AddExtra(Extra extra);
        void UpdateExtra(Extra extra);
        Extra GetExtraId(int extraId);
        void DeleteExtra(Extra extra);
        bool ExtraExists(int extraId);
        IEnumerable<Extra> GetExtras { get; }
    }
}
