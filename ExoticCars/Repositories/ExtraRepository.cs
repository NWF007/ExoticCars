using ExoticCars.DAL;
using ExoticCars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public class ExtraRepository : IExtraRepository
    {
        private readonly ExoticCarContext dbContext;

        public ExtraRepository(ExoticCarContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Extra> GetExtras {
            get
            {
                return dbContext.Extras;
            }
        }

        public void AddExtra(Extra extra)
        {
            if (extra == null)
            {
                throw new ArgumentNullException(nameof(extra));
            }
            dbContext.Extras.Add(extra);
            dbContext.SaveChanges();
        }

        public void DeleteExtra(Extra extra)
        {
            /*var extra = GetExtraId(extraId);*/
            if (extra != null)
            {
                dbContext.Extras.Remove(extra);
            }
        }

        public bool ExtraExists(int extraId)
        {
            throw new NotImplementedException();
        }

        public Extra GetExtraId(int extraId)
        {
            return dbContext.Extras.FirstOrDefault(c => c.ExtraID == extraId);
        }

        public void UpdateExtra(Extra extra)
        {
            if (extra != null)
            {
                dbContext.Entry(extra).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }
}
