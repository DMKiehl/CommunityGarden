using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Models;

namespace GardenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GardenController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public GardenController (IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var gardens = _repoWrapper.Garden.GetAllGardens();
            return Ok(gardens);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Garden value)
        {
            _repoWrapper.Garden.CreateGarden(value);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put([FromBody] Garden garden)
        {
            
            _repoWrapper.Garden.EditGarden(garden);
            return Ok();
        }




    }
}