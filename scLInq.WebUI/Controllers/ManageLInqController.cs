
using scLInq.Repository.Abstract.ManageLInq;
using scLInq.WebUI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scLInq.WebUI.Controllers
{
    [SessionExpire]
    public class ManageLInqController : Controller
    {

        #region *********Fields***********
        private ILocationRepository _LocationRepo;
        private IDepartmentRepository _DepartmentRepo;
        private IJobFunctionRepository _JobFunctionRepo;

        #endregion
        #region *********Constructor***********

        public ManageLInqController(ILocationRepository LocationRepo,IDepartmentRepository DepartmentRepo,
            IJobFunctionRepository JobFunctionRepo)
        {
            this._LocationRepo = LocationRepo;
            this._DepartmentRepo = DepartmentRepo;
            this._JobFunctionRepo = JobFunctionRepo;
        }

        #endregion

        // GET: ManageLInq
        public ActionResult Index()
        {
           return View();
        }


        public ActionResult GetVideo()
        {
            var videoPath = Request.MapPath("~/Content/music.mp4");
            System.IO.FileStream fs = new System.IO.FileStream(videoPath, System.IO.FileMode.Open);
            return new FileStreamResult(fs, "video/mp4");
        }

        #region Add User    
        public ActionResult AddUser()
        {
            ViewBag.Department = _DepartmentRepo.Get;
            ViewBag.JobFunction = _JobFunctionRepo.Get;
            ViewBag.Location = _LocationRepo.Get;
            return View();
        }

        public JsonResult GetDepartments()
        {
            var departmentList = _DepartmentRepo.Get.ToList();
            return Json(departmentList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetJobFunctionByDepartmentId(string ID)
        {
            Int32 id = Convert.ToInt32(ID);
            return Json(_JobFunctionRepo[id]);
        }

        public JsonResult GetLocationByDepartmentId(string ID)
        {
            Int32 id = Convert.ToInt32(ID);
            return Json(_LocationRepo[id]);
        }


        #endregion
    }
}