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
    public class FAQRepository : Connection, IFAQRepository
    {
        public tbFAQ this[int faqId]
        {
            get
            {
                return (from faq in this._context.tbFAQs where faq.Id == faqId select faq).FirstOrDefault();
            }
        }
        
        public IQueryable<tbFAQ> GetByStatusFilter(string status)
        {
            IQueryable<tbFAQ> reqDetails = _context.tbFAQs.Where(a => a.Question == status).AsQueryable();
            return reqDetails;
        }

        public IQueryable<tbFAQ> Get
        {
            get
            {
                return _context.tbFAQs;
            }
        }

        public int Add(tbFAQ faqData)
        {          
            try
            {
               var obj = _context.tbFAQs.Add(faqData);
                _context.SaveChanges();
                return obj.Id;
            }
            catch(Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return 0;
        }

        public int Delete(int id)
        {
            try
            {
                if(id !=0)
                {
                    tbFAQ obj = this[id];
                    this._context.tbFAQs.Remove(obj);
                    _context.SaveChanges();
                    return obj.Id;
                }
            }
            catch { }
            return 0;
        }

        public int Update(tbFAQ faqData)
        {


            try
            {
                faqData.ModifyOn = DateTime.Now.Date;
                //tbFAQ objfaq = this[faqData.Id];
                //objfaq.Question = faqData.Question;
                //objfaq.Answer = faqData.Answer;
                //objfaq.AttachedToNode = faqData.AttachedToNode;
                //objfaq.CreatedBy = faqData.CreatedBy;
                //objfaq.CreatedOn = faqData.CreatedOn;
                //objfaq.ModifyOn = 
                _context.Entry(faqData).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return faqData.Id;
            }
            catch { }
            return 0;
        }
    }
}
