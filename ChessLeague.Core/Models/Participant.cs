namespace ChessLeague.Core.Models
{
    public class Participant : BaseModel
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public DateTime JoinDate { get; set; }
        public Guid GroupId { get; set; } // Foreign key to the Group
        public Group Group { get; set; } // Navigation property to the Group

    }
}
