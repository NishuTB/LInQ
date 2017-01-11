using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using scLInq.Domain;

namespace scLInq.Repository.Abstract.FAQ
{
   public interface IFAQRepository
    {
        IQueryable<tbFAQ> Get { get; }

        tbFAQ this[Int32 faqId] { get; }

        Int32 Add(tbFAQ faqData);
        Int32 Update(tbFAQ faqData);

        Int32 Delete(Int32 id);
        IQueryable<tbFAQ> GetByStatusFilter(string status);
    }
}
