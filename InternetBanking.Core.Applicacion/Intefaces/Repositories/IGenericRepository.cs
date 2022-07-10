using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Intefaces.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task AddAsync(Entity entity);
        Task UpdateAsync(Entity entity, int Id);
        Task DeleteAsync(Entity entity);
        Task<Entity> GetByIdAsync(int Id);
        Task<List<Entity>> GetAllAsync();
    }
}
