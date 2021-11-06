using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolarSimulation_backend.Data;
using SolarSimulation_backend.Repository.IRepository;

namespace SolarSimulation_backend.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly SolarSimulationDBContext _solarSimulationDbContext;

        public RepositoryBase(SolarSimulationDBContext solarSimulationDbContext)
        {
            _solarSimulationDbContext = solarSimulationDbContext;
        }

        public async Task<List<T>> GetAll()
        {
            return await _solarSimulationDbContext.Set<T>().ToListAsync();
        }
    }
}
