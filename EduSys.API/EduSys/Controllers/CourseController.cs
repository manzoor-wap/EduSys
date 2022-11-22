using BusinessObject.Abstract;
using Datastore.Abstract.Models.Impl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduSys.Controllers
{
    public class CourseController : Controller
    {
        ICourseBusinessObject _courseBusinessObject { get; set; }
        public CourseController(ICourseBusinessObject courseBusinessObject)
        {
            _courseBusinessObject = courseBusinessObject;
        }





        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Course course)
        {

            if (await _courseBusinessObject.CreateCourse(course))
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
        public async Task<ActionResult> Edit(Course course)
        {

            if (await _courseBusinessObject.UpdateCourse(course))
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
        public async Task<ActionResult> Delete(Course course)
        {

            if (await _courseBusinessObject.UpdateCourse(course))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }

        // GET: CourseController
        public async Task<ActionResult> Index()
        {
            return View(await _courseBusinessObject.GetCourses().ConfigureAwait(false));
        }

        // GET: CourseController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _courseBusinessObject.GetCourse(id));
        }





        // GET: CourseController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _courseBusinessObject.GetCourse(id));
        }



        // GET: CourseController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _courseBusinessObject.GetCourse(id));
        }


    }

}


