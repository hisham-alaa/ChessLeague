namespace ChessLeague.Core.Models
{
    public class Match : BaseModel
    {
        public Guid Id { get; set; }
        public Guid Player1Id { get; set; }
        public Guid Player2Id { get; set; }
        public DateTime ScheduledTime { get; set; }
        public Guid? WinnerId { get; set; } // Nullable to handle cases where the match is a draw or not yet completed
        public string Result { get; set; } // Optional: Can be used for additional details like "Draw" or "Player1 wins by resignation"
        public bool IsClosed { get; set; }

        public Guid RoundId { get; set; } // Foreign key to the Round
        public Round Round { get; set; }

    }
}
