using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolarSimulation_backend.Models;

namespace SolarSimulation_backend.Services.IServices
{
    public interface IPlanetService
    {
        Task<List<Planet>> GetAll();
    }
}
