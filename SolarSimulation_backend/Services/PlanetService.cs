using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolarSimulation_backend.Models;
using SolarSimulation_backend.Repository.IRepository;
using SolarSimulation_backend.Services.IServices;

namespace SolarSimulation_backend.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public async Task<List<Planet>> GetAll()
        {
            var planets = await _planetRepository.GetAll();

            return planets;
        }
    }
}
