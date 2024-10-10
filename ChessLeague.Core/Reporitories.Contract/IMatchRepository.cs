using ChessLeague.Core.Models;

namespace ChessLeague.Core.Reporitories.Contract
{
    public interface IMatchRepository : IGenericRepository<Match>
    {
        Task UpdateAsync(Guid id, Guid ParticipantId);
    }
}
