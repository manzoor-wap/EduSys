using BusinessObject.Abstract;
using Datastore.Abstract.Models.Impl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduSys.Controllers
{
    public class TimeTableController : Controller
    {
        ITimeTableBusinessObject _timetableBusinessObject { get; set; }

        public TimeTableController(ITimeTableBusinessObject timetableBusinessObject)
        {
            _timetableBusinessObject = timetableBusinessObject;
        }





        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TimeTable timetable)
        {

            if (await _timetableBusinessObject.CreateTimeTable(timetable))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }



        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(TimeTable timetable)
        {

            if (await _timetableBusinessObject.UpdateTimeTable(timetable))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }



        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(TimeTable timetable)
        {

            if (await _timetableBusinessObject.UpdateTimeTable(timetable))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }

        // GET: TimeTableController
        public async Task<ActionResult> Index()
        {
            return View(await _timetableBusinessObject.GetTimeTables().ConfigureAwait(false));
        }

        // GET: TimeTableController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _timetableBusinessObject.GetTimeTable(id));
        }





        // GET: TimeTableController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _timetableBusinessObject.GetTimeTable(id));
        }



        // GET: TimeTableController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _timetableBusinessObject.GetTimeTable(id));
        }


    }

}


