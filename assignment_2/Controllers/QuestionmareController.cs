using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_2.Controllers
{
    public class QuestionmareController : Controller
    {
        // GET: QuestionmareController
        public ActionResult Index()
        {

            return View();
        }

        // GET: QuestionmareController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionmareController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionmareController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionmareController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionmareController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionmareController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionmareController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
