using scLInq.Repository.Abstract;
using scLInq.Repository.Abstract.ManageLInq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scLInq.Domain;

namespace scLInq.Repository.Concrete.ManageLInq
{
    public class LocationRepository : Connection, ILocationRepository
    {
        public tbLocation this[int ID]
        {
            get
            {
                return (from loc in _context.tbLocations where loc.DeptId == ID select loc).FirstOrDefault();
            }
        }

        public IQueryable<tbLocation> Get
        {
            get
            {
                return _context.tbLocations;
            }
        }
    }
}
