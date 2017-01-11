using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using scLInq.Domain;

namespace scLInq.Repository.Abstract
{
    public abstract class Connection
    {
        protected db_scLInqEntities _context;
        public Connection()
        {
            _context = new db_scLInqEntities();
        }
    }
}
