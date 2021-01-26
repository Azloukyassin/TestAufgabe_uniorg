using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAufgabe_uniorg.Models;
using TestAufgabe_uniorg.Models.IServices;

namespace TestAufgabe_uniorg.Controllers
{
    public class AnmeldenController : Controller
    {
        /// <summary>
        /// Controller um die Methode CRUD zu implementieren 
        /// hier bei unsere Test wurde nur die Create Methode implementiert 
        /// </summary>
        private UserRepository _userRepository;

        /// <summary>
        /// Konstruktur 
        /// </summary>
        /// <returns></returns>
        public AnmeldenController(UserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        // GET: Anmelden
        public ActionResult Index()
        {
            var users = _userRepository.liste();
            return View(users);
        }

        // GET: Anmelden/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Anmelden/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anmelden/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                _userRepository.Add(user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Anmelden/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Anmelden/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Anmelden/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Anmelden/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
