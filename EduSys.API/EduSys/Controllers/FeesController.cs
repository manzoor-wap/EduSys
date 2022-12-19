using BusinessObject.Abstract;
using Datastore.Abstract.Models.Impl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduSys.Controllers
{
    public class FeesController : Controller
    {
        IFeesBusinessObject _feesBusinessObject { get; set; }
        public FeesController(IFeesBusinessObject feesBusinessObject)
        {
            _feesBusinessObject = feesBusinessObject;
        }





        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Fees fees)
        {

            if (await _feesBusinessObject.CreateFees(fees))
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
        public async Task<ActionResult> Edit(Fees fees)
        {

            if (await _feesBusinessObject.UpdateFees(fees))
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
        public async Task<ActionResult> Delete(Fees fees)
        {

            if (await _feesBusinessObject.UpdateFees(fees))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }

        // GET: FeesController
        public async Task<ActionResult> Index()
        {
            return View(await _feesBusinessObject.GetFeess().ConfigureAwait(false));
        }

        // GET: FeesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _feesBusinessObject.GetFees(id));
        }





        // GET: FeesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _feesBusinessObject.GetFees(id));
        }



        // GET: FeesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _feesBusinessObject.GetFees(id));
        }


    }

}
