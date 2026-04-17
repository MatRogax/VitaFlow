using projeto_carlos.Common.Entities;
using VitaFlow.Common.Interfaces;

namespace VitaFlow.Services.Base
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IRepositoryBase<TEntity> _repository;

        protected ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
            var existing = await _repository.GetByIdAsync(entity.Id);

            if (existing == null)
                return false;

            await _repository.UpdateAsync(entity);
            await _repository.SaveChangesAsync();

            return true;
        }

        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            var existing = await _repository.GetByIdAsync(id);

            if (existing == null)
                return false;

            await _repository.DeleteAsync(existing);
            await _repository.SaveChangesAsync();

            return true;
        }
    }
}