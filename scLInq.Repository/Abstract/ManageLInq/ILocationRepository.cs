using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using scLInq.Domain;

namespace scLInq.Repository.Abstract.ManageLInq
{
    public interface ILocationRepository
    {
        IQueryable<tbLocation> Get { get; }

        tbLocation this[Int32 ID] { get; }

    }
}
