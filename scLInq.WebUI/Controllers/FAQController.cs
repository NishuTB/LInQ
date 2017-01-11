using scLInq.Domain;
using scLInq.Repository.Abstract.FAQ;
using scLInq.WebUI.Filters;
using scLInq.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scLInq.WebUI.Controllers
{
    [SessionExpire]
    public class FAQController : Controller
    {


        #region *********Fields***********

        private IFAQRepository _FAQRepo;
        private IFaqDocumentRepository _FaqDocumentRepo;


        #endregion
        #region *********Constructor***********

        public FAQController(IFAQRepository FAQRepo, IFaqDocumentRepository FaqDocumentRepo)
        {
            this._FAQRepo = FAQRepo;
            this._FaqDocumentRepo = FaqDocumentRepo;
        }

        #endregion


        #region GeneralFAQ Actions
        // GET: FAQ
        public ActionResult GeneralFAQ()
        {
            return View();
        }


        #region jqgrid  

        /// <summary>
        /// Load MasterTables Requests in JqGrid
        /// </summary>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        /// 

        public JsonResult LoadFAQRequests(string sidx, string sord, int page, int rows, string search)
        {
            foreach (var item in _FAQRepo.Get)
            {
                item.Answer = StripTagsCharArray(item.Answer);
            }

            var SARequests = _FAQRepo.Get.ToList();

            var jsonResult = Json(new
            {
                total = SARequests.Count / 10,
                page = 1,
                records = SARequests.Count,
                rows = SARequests
            }, JsonRequestBehavior.AllowGet);

            return jsonResult;
        }

        public JsonResult LoadFAQDocRequests(string sidx, string sord, int page, int rows, string search)
        {
            var SARequests = _FaqDocumentRepo.Get.ToList();
            var jsonResult = Json(new
            {
                total = SARequests.Count / 10,
                page = 1,
                records = SARequests.Count,
                rows = SARequests
            }, JsonRequestBehavior.AllowGet);

            return jsonResult;
        }
        #endregion



        #endregion


        #region Manage FAQ 
        // GET: FAQ
        public ActionResult ManageFAQ()
        {
            return View();
        }


        #region jqgrid  

        /// <summary>
        /// Load MasterTables Requests in JqGrid
        /// </summary>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        /// 

        public JsonResult LoadManageFAQRequests(string sidx, string sord, int page, int rows, string search)
        {
            foreach (var item in _FAQRepo.Get)
            {
                item.Answer = StripTagsCharArray(item.Answer);
            }
            var SARequests = _FAQRepo.Get.ToList();
            var jsonResult = Json(new
            {
                total = SARequests.Count / 10,
                page = 1,
                records = SARequests.Count,
                rows = SARequests
            }, JsonRequestBehavior.AllowGet);

            return jsonResult;
        }


        #endregion



        #endregion


        #region Add FAQ
        public ActionResult AddFAQ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFAQ(FAQM faqData)
        {
            tbFAQ tbfaq = new tbFAQ();
            tbfaq.Question = faqData.Question;
            //String ans = StripTagsCharArray(faqData.Answer);
            tbfaq.Answer = faqData.Answer;
            tbfaq.AttachedToNode = "General";
            tbfaq.CreatedBy = Session["UserName"].ToString();
            tbfaq.CreatedOn = DateTime.Now;
            _FAQRepo.Add(tbfaq);
            return RedirectToAction("ManageFAQ");
        }


        public static string StripTagsCharArray(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        #endregion



        #region WebGrid FAQ
        public ActionResult ModifyFAQ()
        {
            return View();
        }

       

        #endregion


    }
}