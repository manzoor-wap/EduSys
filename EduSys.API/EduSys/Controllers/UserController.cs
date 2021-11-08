using BusinessObject.Abstract;
using Datastore.Abstract.Models.Impl;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduSys.Controllers
{
    public class UserController : Controller
    {
        IUserBusinessObject _userBusinessObject { get; set; }
        public UserController(IUserBusinessObject userBusinessObject)
        {
            _userBusinessObject = userBusinessObject;
        }





        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {

            if (await _userBusinessObject.CreateUser(user))
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
        public async Task<ActionResult> Edit(User user)
        {

            if (await _userBusinessObject.UpdateUser(user))
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
        public async Task<ActionResult> Delete(User user)
        {

            if (await _userBusinessObject.UpdateUser(user))
            {
                //TODO: send sucess response to UI
                return RedirectToAction(nameof(Index));
            }
            //TODO: send failed response to UI
            return View();
        }

        // GET: UserController
        public async Task<ActionResult> Index()
        {
            return View(await _userBusinessObject.GetUsers().ConfigureAwait(false));
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _userBusinessObject.GetUser(id));
        }





        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _userBusinessObject.GetUser(id));
        }



        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _userBusinessObject.GetUser(id));
        }


    }

}
