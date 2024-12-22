using businesslayers.Interfaces;
using datalayers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayers.Services
{
    public class GenericServices<T> : IGenericServices<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;


        public GenericServices(IGenericRepository<T> repository)
        {
            _repository = repository;

        }

        public Task<T> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task<IEnumerable<T>> GetAllAsync() => _repository.GetAllAsync();
        public Task AddAsync(T entity) => _repository.AddAsync(entity);
        public Task UpdateAsync(T entity) => _repository.UpdateAsync(entity);
        public Task<bool> SoftDeleteAsync(int id) => _repository.SoftDeleteAsync(id);
        public Task<bool> RestoreAsync(int id) => _repository.RestoreAsync(id);

    }
}
