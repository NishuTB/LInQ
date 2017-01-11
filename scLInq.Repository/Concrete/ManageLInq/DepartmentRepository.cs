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
    public class DepartmentRepository : Connection, IDepartmentRepository
    {
        public IQueryable<tbDepartment> Get
        {
            get
            {
                return _context.tbDepartments;
            }
        }
    }
}
