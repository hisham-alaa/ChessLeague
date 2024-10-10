namespace ChessLeague.Core.Models
{
    public class League : BaseModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid ChampionId { get; set; }
        public List<Group> Groups { get; set; }
    }
}