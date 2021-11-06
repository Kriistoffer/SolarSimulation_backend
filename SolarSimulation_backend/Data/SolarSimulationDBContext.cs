using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolarSimulation_backend.Models;

namespace SolarSimulation_backend.Data
{
    public class SolarSimulationDBContext : DbContext
    {
        public SolarSimulationDBContext(DbContextOptions<SolarSimulationDBContext> options)
            : base(options)
        { }

        public DbSet<Planet> Planets { get; set; }
    }
}