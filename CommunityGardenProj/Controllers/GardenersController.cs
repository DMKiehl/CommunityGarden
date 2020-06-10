using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CommunityGardenProj.ActionFilters;
using CommunityGardenProj.Contracts;
using CommunityGardenProj.Data;
using CommunityGardenProj.Data.Migrations;
using CommunityGardenProj.Models;
using CommunityGardenProj.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

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
            var gardenerProfile = _context.Gardeners.Where(g => g.IdentityUserId == userId).ToList();

            if (gardenerProfile.Count == 0)
            {
                return RedirectToAction("Create", "Gardeners");
            }

            var gardener = _context.Gardeners.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return View(gardener);
        }


        public async Task<List<Garden>> GetAllGardens()//use a loop to manage multiple objects
        {
            List<Garden> allGardens = new List<Garden>();

            string url = "https://localhost:44329/api/Garden";

            // use HttpClient to make the API call
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                allGardens = JsonConvert.DeserializeObject<List<Garden>>(json);
                
            }
          
            return allGardens;

        }

        public IQueryable<T> SearchByCriteria()//location(Zip Code?), cost, volunteer opportunities, organic vs. non-organic, plotsize 
        {
            var gardens = GetAllGardens();

            //var searchByLocation = gardens.Result.Where(g => g.zip ==)
            //var lowCostGardens = gardens.Result.Where(g => g.cost ).;
            //var hasVolunteerOpportunities = gardens.Result.Where(g => g.volunteerOpportunities == true).ToDictionary;
            //var isOrganic = gardens.Result.Where(g => g.organic == true).ToList();
            //var SmallPlotSize = gardens.Result.Where(g => g.plotSize == )

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

        public async Task<IActionResult> Edit(int id, Gardener gardener)
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

       

       public ActionResult CreateGarden()
        {
            return View();
        }

        [HttpPost, ActionName("CreateGarden")]

        public async Task<IActionResult> CreateGarden(Garden garden)
        {
            var address = garden.streetAddress + ", " + garden.city + ", " + garden.state;
            GeoCode geocode = await _apiCalls.GoogleGeocoding(address);
            var lat = geocode.results[0].geometry.location.lat;
            var lng = geocode.results[0].geometry.location.lng;
            garden.latitude = lat;
            garden.longitude = lng;

            using var client = new HttpClient();
            var url = "https://localhost:44329/api/Garden";
            var json = JsonConvert.SerializeObject(garden);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

           

            var response = await client.PostAsync(url, data);
           
            
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("CreateGarden");

        }

        public async Task<IActionResult> GardenDetails(int id)
        {
            Garden garden = await _apiCalls.GardenDetailAPI(id);
            return View(garden);

        }


        public async Task<IActionResult> GardensNearMe(int id) {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var gardner = _context.Gardeners.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            var nearbyGardens = await GetAllGardens();
            var gardnerAddress = gardner.Address.City.ToString();
            var matchedGarden = nearbyGardens.Find(a => a.city == gardner.Address.City);

            return View(matchedGarden);
        }
    }

}

