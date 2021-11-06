using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarSimulation_backend.Services.IServices
{
    public interface IBaseService<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
