using scLInq.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scLInq.Repository.Abstract.ManageLInq
{
   public interface IDepartmentRepository
    {
        IQueryable<tbDepartment> Get { get; }
    }
}
