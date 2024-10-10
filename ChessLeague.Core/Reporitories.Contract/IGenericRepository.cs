using ChessLeague.Core.Models;

namespace ChessLeague.Core.Reporitories.Contract
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T T);
        void Update(T T);
        void Delete(Guid id);

    }
}
