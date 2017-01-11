using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using scLInq.Domain;

namespace scLInq.Repository.Abstract.ManageLInq
{
    public interface IJobFunctionRepository
    {
        IQueryable<tbJobFunction> Get { get; }

        tbJobFunction this[Int32 ID] { get; }
    }
}
