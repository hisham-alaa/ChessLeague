namespace ChessLeague.Core.Models
{
    public class Group : BaseModel
    {
        public string Name { get; set; }
        public Guid LeagueId { get; set; } // Foreign key to the League
        public League League { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Round> Rounds { get; set; }
    }
}
