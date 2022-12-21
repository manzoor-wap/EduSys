using BusinessObject.Abstract;
using Datastore.Abstract.Models.Impl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduSys.Controllers
{
    public class AttendanceController : Controller
    { 
     IAttendanceBusinessObject _attendanceBusinessObject { get; set; }
   
     public AttendanceController(IAttendanceBusinessObject attendanceBusinessObject)
     {
        _attendanceBusinessObject = attendanceBusinessObject;
     }





    // GET: Employee/Create
    public ActionResult Create()
    {
        return View();
    }


    // POST: Employee/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(Attendance attendance)
    {

        if (await _attendanceBusinessObject.CreateAttendance(attendance))
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
    public async Task<ActionResult> Edit(Attendance attendance)
    {

        if (await _attendanceBusinessObject.UpdateAttendance(attendance))
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
    public async Task<ActionResult> Delete(Attendance attendance)
    {

        if (await _attendanceBusinessObject.UpdateAttendance(attendance))
        {
            //TODO: send sucess response to UI
            return RedirectToAction(nameof(Index));
        }
        //TODO: send failed response to UI
        return View();
    }

    // GET: AttendanceController
    public async Task<ActionResult> Index()
    {
        return View(await _attendanceBusinessObject.GetAttendances().ConfigureAwait(false));
    }

    // GET: AttendanceController/Details/5
    public async Task<ActionResult> Details(int id)
    {
        return View(await _attendanceBusinessObject.GetAttendance(id));
    }





    // GET: AttendanceController/Edit/5
    public async Task<ActionResult> Edit(int id)
    {
        return View(await _attendanceBusinessObject.GetAttendance(id));
    }



    // GET: AttendanceController/Delete/5
    public async Task<ActionResult> Delete(int id)
    {
        return View(await _attendanceBusinessObject.GetAttendance(id));
    }


  }

}


