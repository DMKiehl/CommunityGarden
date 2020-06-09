using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CommunityGardenProj.ActionFilters;
using CommunityGardenProj.Contracts;
using CommunityGardenProj.Data;
using CommunityGardenProj.Models;
using CommunityGardenProj.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CommunityGardenProj.Controllers
{
    
    public class GardenersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IAPIService _apiCalls;
        public GardenersController(ApplicationDbContext context, IAPIService apiCalls)
        {
            _context = context;
            _apiCalls = apiCalls;
        }
        // GET: GardenersController
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var gardener = _context.Gardeners.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return View(gardener);
        }

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
        
        public ActionResult Create()
        {
           
            
                return View();
            
        }


        // POST: GardenersController/Create
        [HttpPost]
    
        public async Task<IActionResult> Create(GardenerViewModel gardenerViewModel)
        {              
           

            if (ModelState.IsValid)
            {

                var fullAddress = gardenerViewModel.Address.StreetAddress + ", " + gardenerViewModel.Address.City + ", " + gardenerViewModel.Address.State;
                GeoCode geocode = await _apiCalls.GoogleGeocoding(fullAddress);
                var lat = geocode.results[0].geometry.location.lat;
                var lng = geocode.results[0].geometry.location.lng;
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                gardenerViewModel.Gardener.IdentityUserId = userId;
                gardenerViewModel.Address.Latitude = lat;
                gardenerViewModel.Address.Longitude = lng;
                gardenerViewModel.Gardener.Address = gardenerViewModel.Address;
                _context.Add(gardenerViewModel.Gardener);
             
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", gardenerViewModel.Gardener.IdentityUserId);
            return View(gardenerViewModel);
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
