using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CommunityGardenProj.Data;
using CommunityGardenProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommunityGardenProj.Controllers
{
    public class GardenersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GardenersController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: GardenersController
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var gardener = _context.Gardeners.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return View(gardener);
        }

        // GET: GardenersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GardenersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GardenersController/Create
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

        // GET: GardenersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GardenersController/Edit/5
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

        // GET: GardenersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GardenersController/Delete/5
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
