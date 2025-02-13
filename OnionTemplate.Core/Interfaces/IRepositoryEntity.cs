using andon_ng.Core.Entities;

namespace andon_ng.Core.Interfaces
{
    public interface IRepositoryEntity
    {
        Task<IEnumerable<TestEntity>> GetEntitiesAsync();
        Task<TestEntity> GetEntityAsync(Guid id);
        Task<TestEntity> AddEntityAsync(TestEntity entity);
        Task<TestEntity> UpdateEntityAsync(TestEntity entity);
        Task DeleteEntityAsync(Guid id);
    }
}
