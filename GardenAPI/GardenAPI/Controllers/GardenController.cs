using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;

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
    }
}