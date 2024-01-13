using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business_Logic_Layer.Interfaces;
using Lab5AspNetMVC.Models;

namespace Lab5AspNetMVC.Controllers
{
    public class ReportsController : Controller
    {
        IReportsService reportsService;
        IDbCrud crudServ;

        public ReportsController(IReportsService reportservice, IDbCrud crudDb)
        {
            reportsService = reportservice;
            crudServ = crudDb;
        }


        [HttpGet]
        public ActionResult LinkReportKind()
        {
            return View(new LinkReportKindModel() { taskKindsList = crudServ.GetAllTaskKinds() });
        }

        [HttpPost]
        public ActionResult LinkReportKind(LinkReportKindModel model)
        {
            model.SelectionByKindData = reportsService.ReportSelectionByKind(model.SelectedKindId);
            model.taskKindsList = crudServ.GetAllTaskKinds();
            return View(model);
        }


        [HttpGet]
        public ActionResult LinkReportStatus()
        {
            return View(new LinkReportStatusModel() { taskStatusesList = crudServ.GetAllTaskStatuses() });
        }

        [HttpPost]
        public ActionResult LinkReportStatus(LinkReportStatusModel model)
        {
            model.SelectionByStatusData = reportsService.ReportSelectionByStatus(model.SelectedStatusId);
            model.taskStatusesList = crudServ.GetAllTaskStatuses();
            return View(model);
        }


        [HttpGet]
        public ActionResult SPReportRepeat()
        {
            return View(new SPReportRepeatModel());
        }

        [HttpPost]
        public ActionResult SPReportRepeat(SPReportRepeatModel  model)
        {
            model.SelectionByRepeatabilityData = reportsService.ReportSelectionByRepeatability(model.SelectedValueIsRepeat);
            return View(model);
        }





        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }
    }
}