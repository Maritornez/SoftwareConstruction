using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business_Logic_Layer.Interfaces;
using Lab5AspNetMVC.Models;

namespace Lab5AspNetMVC.Controllers
{
    public class TaskController : Controller
    {
        IDbCrud crudServ;

        public TaskController(IDbCrud crudServ)
        {
            this.crudServ = crudServ;
        }


        // Create

        [HttpGet]
        public ActionResult Create()
        {
            return View(new TaskModel(crudServ.GetAllTaskKinds(), crudServ.GetAllTaskStatuses()));
        }

        [HttpPost]
        public ActionResult Create(TaskModel model)
        {
            Business_Logic_Layer.DTO.TaskDTO t = new Business_Logic_Layer.DTO.TaskDTO();

            t.Id = model.Id;
            t.Name = model.Name;
            t.Description = model.Description;
            t.StatusId = model.StatusId;
            t.KindId = model.KindId;
            t.BeginDate = model.BeginDate;
            t.BeginTime = model.BeginTime;
            t.EndDate = model.EndDate;
            t.EndTime = model.EndTime;
            t.IsRepeat = model.IsRepeat;
            t.RepeatIntervalDays = model.RepeatIntervalDays;
            t.RepeatIntervalMonths = model.RepeatIntervalMonths;
            t.RepeatIntervalWeeks = model.RepeatIntervalWeeks;
            t.RepeatIntervalYears = model.RepeatIntervalYears;

            crudServ.CreateTask(t);

            return RedirectToAction("Index");
        }


        // GET: Task (Read)
        public ActionResult Index()
        {
            return View("Index", crudServ.GetAllTasks().Select(i => new TaskModel(i, crudServ.GetAllTaskKinds(), crudServ.GetAllTaskStatuses())));
        }

        // Update

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(new TaskModel(crudServ.GetTask(id), crudServ.GetAllTaskKinds(), crudServ.GetAllTaskStatuses()));
        }

        [HttpPost]
        public ActionResult Edit(TaskModel model)
        {
            Business_Logic_Layer.DTO.TaskDTO t = new Business_Logic_Layer.DTO.TaskDTO();

            t.Id = model.Id;
            t.Name = model.Name;
            t.Description = model.Description;
            t.StatusId = model.StatusId;
            t.KindId = model.KindId;
            t.BeginDate = model.BeginDate;
            t.BeginTime = model.BeginTime;
            t.EndDate = model.EndDate;
            t.EndTime = model.EndTime;
            t.IsRepeat = model.IsRepeat;
            t.RepeatIntervalDays = model.RepeatIntervalDays;
            t.RepeatIntervalMonths = model.RepeatIntervalMonths;
            t.RepeatIntervalWeeks = model.RepeatIntervalWeeks;
            t.RepeatIntervalYears = model.RepeatIntervalYears;

            crudServ.UpdateTask(t);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            crudServ.DeleteTask(id);
            return RedirectToAction("Index");
        }
    }
}