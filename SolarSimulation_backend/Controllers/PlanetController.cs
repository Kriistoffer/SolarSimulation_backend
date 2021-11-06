using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SolarSimulation_backend.Models;
using SolarSimulation_backend.Services.IServices;

namespace SolarSimulation_backend.Data
{
    [ApiController]
    [EnableCors("CORSPolicy")]
    [Route("[controller]")]

    public class PlanetController : ControllerBase
    {
        private readonly IPlanetService _planetService;

        public PlanetController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        ///<summary>
        ///Returns all planets
        ///</summary>
        ///<returns></returns>
        [HttpGet("All")]
        public async Task<List<Planet>> GetAll()
        {
            return await _planetService.GetAll();
        }
    }
}
