using BusinessObject.Abstract;
using Datastore.Abstract.Models.Impl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduSys.Controllers
{
    public class MarksController : Controller
    {
        IMarksBusinessObject _marksBusinessObject { get; set; }
        public MarksController(IMarksBusinessObject marksBusinessObject)
        {
            _marksBusinessObject = marksBusinessObject;
        }





        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Marks marks)
        {

            if (await _marksBusinessObject.CreateMarks(marks))
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
        public async Task<ActionResult> Edit(Marks marks)
        {

            if (await _marksBusinessObject.UpdateMarks(marks))
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
        public async Task<ActionResult> Delete(Marks marks)
        {

            if (await _marksBusinessObject.UpdateMarks(marks))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }

        // GET: MarksController
        public async Task<ActionResult> Index()
        {
            return View(await _marksBusinessObject.GetMarkss().ConfigureAwait(false));
        }

        // GET: MarksController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _marksBusinessObject.GetMarks(id));
        }





        // GET: MarksController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _marksBusinessObject.GetMarks(id));
        }



        // GET: MarksController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _marksBusinessObject.GetMarks(id));
        }


    }

}
