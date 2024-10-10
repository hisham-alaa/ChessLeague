namespace ChessLeague.Core.Models
{
    public class Round : BaseModel
    {
        public int RoundNumber { get; set; }
        public List<Match> Matches { get; set; }
        public Guid GroupId { get; set; } // Foreign key to the Group
        public bool IsClosed { get; set; }
    }
}
