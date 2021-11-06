using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolarSimulation_backend.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using SolarSimulation_backend.Data;
using SolarSimulation_backend.Models;

namespace SolarSimulation_backend.Repository
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly SolarSimulationDBContext _dbContext;

        public PlanetRepository(SolarSimulationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Planet>> GetAll()
        {
            return await _dbContext.Planets.ToListAsync();
        }
    }
}
