using scLInq.Repository.Abstract.FAQ;
using scLInq.WebUI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scLInq.WebUI.Controllers
{
    [SessionExpire]
    public class LInqController : Controller
    {
        //#region *********Fields***********

        //private IFAQRepository _FAQRepo;
        //private IFaqDocumentRepository _FaqDocumentRepo;


        //#endregion
        //#region *********Constructor***********

        //public LInqController(IFAQRepository FAQRepo, IFaqDocumentRepository FaqDocumentRepo)
        //{
        //    this._FAQRepo = FAQRepo;
        //    this._FaqDocumentRepo = FaqDocumentRepo;
        //}

        //#endregion


        #region MySpace
        // GET: LInq
        public ActionResult MySpace()
        {
            return View();
        }

        #endregion

        #region General FAQ
        // GET: LInq
        public ActionResult GeneralFAQ()
        {
            return View();
        }


        //#region jqgrid  

        ///// <summary>
        ///// Load MasterTables Requests in JqGrid
        ///// </summary>
        ///// <param name="sidx"></param>
        ///// <param name="sord"></param>
        ///// <param name="page"></param>
        ///// <param name="rows"></param>
        ///// <param name="search"></param>
        ///// <returns></returns>
        ///// 

        //public JsonResult LoadFAQRequests(string sidx, string sord, int page, int rows, string search)
        //{
        //    var SARequests = _FAQRepo.Get.ToList();
        //    var jsonResult = Json(new
        //    {
        //        total = SARequests.Count / 10,
        //        page = 1,
        //        records = SARequests.Count,
        //        rows = SARequests
        //    }, JsonRequestBehavior.AllowGet);

        //    return jsonResult;
        //}
        //#endregion






        #endregion
    }
}