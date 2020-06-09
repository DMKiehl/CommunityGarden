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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var garden = _repoWrapper.Garden.GetByID(id);
            return Ok(garden);
        }



        [HttpPost]
        public IActionResult Post([FromBody]Garden value)
        {
            _repoWrapper.Garden.CreateGarden(value);
            _repoWrapper.Save();
            return Ok();
        }

        [HttpPut]

        public IActionResult Put([FromBody] Garden garden)
        {
            
            _repoWrapper.Garden.EditGarden(garden);
            _repoWrapper.Save();
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete([FromBody] Garden garden)
        {
            _repoWrapper.Garden.DeleteGarden(garden);
            _repoWrapper.Save();
            return Ok();
        }




    }
}