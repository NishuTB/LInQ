using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using scLInq.Domain;

namespace scLInq.Repository.Abstract.FAQ
{
    public interface IFaqDocumentRepository
    {
        IQueryable<tbFAQDocument> Get { get; }
    }
}
