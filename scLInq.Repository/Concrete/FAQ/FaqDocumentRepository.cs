using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using scLInq.Domain;
using scLInq.Repository.Abstract;
using scLInq.Repository.Abstract.FAQ;


namespace scLInq.Repository.Concrete.FAQ
{
    public class FaqDocumentRepository : Connection, IFaqDocumentRepository
    {
        public IQueryable<tbFAQDocument> Get
        {
            get
            {
                return _context.tbFAQDocuments;
            }
        }

    }
    
}
