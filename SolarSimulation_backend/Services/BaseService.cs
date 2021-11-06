using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolarSimulation_backend.Repository.IRepository;
using SolarSimulation_backend.Services.IServices;

namespace SolarSimulation_backend.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public async Task<List<T>> GetAll()
        {
            return await _repositoryBase.GetAll();
        }
    }
}
