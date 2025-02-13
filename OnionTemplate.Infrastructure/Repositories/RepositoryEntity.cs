using andon_ng.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using andon_ng.Core.Entities;
using andon_ng.Core.Interfaces;

namespace andon_ng.Infrastructure.Repositories
{
    public class RepositoryEntity : IRepositoryEntity
    {
        private readonly AppDbContext _context;

        public RepositoryEntity(AppDbContext context) =>
            _context = context;

        public async Task<IEnumerable<TestEntity>> GetEntitiesAsync()
        {
            return await _context.Entities.ToListAsync();
        }

        public async Task<TestEntity> GetEntityAsync(Guid id)
        {
            return await _context.Entities.FindAsync(id) ?? throw new InvalidOperationException("No se encontro el Entity");
        }

        public async Task<TestEntity> AddEntityAsync(TestEntity entity)
        {
            _context.Entities.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TestEntity> UpdateEntityAsync(TestEntity entity)
        {
            _context.Entities.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteEntityAsync(Guid id)
        {
            var Entity = await _context.Entities.FindAsync(id);
            if (Entity == null)
            {
                throw new KeyNotFoundException("Entity not found.");
            }

            _context.Entities.Remove(Entity);
            await _context.SaveChangesAsync();
        }
    }
}

