using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarSimulation_backend.Repository.IRepository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
