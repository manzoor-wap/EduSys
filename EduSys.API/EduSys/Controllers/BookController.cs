using BusinessObject.Abstract;
using Datastore.Abstract.Models.Impl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduSys.Controllers
{
    public class BookController : Controller
    {
        IBookBusinessObject _bookBusinessObject { get; set; }
        public BookController(IBookBusinessObject bookBusinessObject)
        {
            _bookBusinessObject = bookBusinessObject;
        }





        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Book book)
        {

            if (await _bookBusinessObject.CreateBook(book))
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
        public async Task<ActionResult> Edit(Book book)
        {

            if (await _bookBusinessObject.UpdateBook(book))
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
        public async Task<ActionResult> Delete(Book book)
        {

            if (await _bookBusinessObject.UpdateBook(book))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }

        // GET: BookController
        public async Task<ActionResult> Index()
        {
            return View(await _bookBusinessObject.GetBooks().ConfigureAwait(false));
        }

        // GET: BookController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _bookBusinessObject.GetBook(id));
        }





        // GET: BookController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _bookBusinessObject.GetBook(id));
        }



        // GET: BookController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _bookBusinessObject.GetBook(id));
        }


    }

}
