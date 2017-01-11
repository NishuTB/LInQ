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
    public class JobFunctionRepository : Connection, IJobFunctionRepository
    {
        public tbJobFunction this[int ID]
        {
            get
            {
                return (from item in _context.tbJobFunctions where item.DeptId == ID select item).FirstOrDefault();
            }
        }

        public IQueryable<tbJobFunction> Get
        {
            get
            {
                return _context.tbJobFunctions;
            }
        }
    }
}
