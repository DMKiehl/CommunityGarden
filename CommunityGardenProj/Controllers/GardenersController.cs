using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CommunityGardenProj.Data;
using CommunityGardenProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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


   





            //IEnumerable<GardenViewModel> gardens = null;

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("); //Get the actual local host here
            //    //HTTP GET
            //    var resonseTask = client.GetAsync("garden");
            //    responseTask.Wait();

            //    var result = resonseTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsStringAsync<IList<GardenViewModel>>();
            //        readTask.Wait();

            //        gardens = readTask.Result;
            //    }
            //    else //web api sent error response
            //    {
            //        //log response status here..
            //        gardens = Enumerable.Empty<GardenViewModel>();

            //        ModelState.AddModelError(string.Empty, "Server error!");
            //    }
            //}
            //return View(gardens);

        


        // GET: GardenersController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var gardener = _context.Gardeners.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            if (gardener == null)
            {
                return NotFound();
            }

            return View(gardener);
        }

        // GET: GardenersController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GardenersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GardenerId,FirstName,LastName,Email,GardenInterest,AddressId")] GardenerViewModel gardenerViewModel)
        {
            Gardener gardener = new Gardener();
            Address address = new Address();

            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                gardener.IdentityUserId = userId;
                _context.Add(gardener);
                _context.Add(address);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", gardener.IdentityUserId);
            return View(gardener);
        }
        // GET: GardenersController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gardener = await _context.Gardeners.FindAsync(id);

            if (gardener == null)
            {
                return NotFound();
            }

            return View(gardener);
        }

        // POST: GardenersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GardenerId,FirstName,LastName,Email,GardenInterest,AddressId,IdentityUserId")] Gardener gardener)
        {

            if (id != gardener.GardenerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gardener);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GardenerExists(gardener.GardenerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gardener);
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
        private bool GardenerExists(int id)
        {
            return _context.Gardeners.Any(e => e.GardenerId == id);
        }


    }
   
}

