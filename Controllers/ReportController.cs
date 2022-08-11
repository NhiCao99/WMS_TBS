using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYKHOHANG.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GENERALCARGOINWH()
        {
            return View();
        }
        public ActionResult CONTAINERSTUFFFROMTO()
        {
            return View();
        }
        public ActionResult CLPWITHCONTS_SEAL()
        {
            return View();
        }
        public ActionResult PRINTCARGORECEIPT()
        {
            return View();
        }
        public ActionResult EDIT_DELETERECORDINDATA()
        {
            return View();
        }
        public ActionResult UPDATEBOOKINGCBM()
        {
            return View();
        }
        public ActionResult PRINTPACKINGLISTVESSEL()
        {
            return View();
        }
        public ActionResult DAILYREPORTFORSAPPO()
        {
            return View();
        }
        public ActionResult FACTORYFORECASTANDPLANOUT()
        {
            return View();
        }
        public ActionResult PRINTPALLETLABLE()
        {
            return View();
        }
        public ActionResult LOCATIONCARGOINWH()
        {
            return View();
        }
        public ActionResult OVERTIMEREPORT()
        {
            return View();
        }
    }
}