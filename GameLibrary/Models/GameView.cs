namespace GameLibrary.Models
{
    public class GameView
    {
        public int Id { get; set; }
        public string PhotoLink { get; set; }
        public string genre { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Platform { get; set; }
        public int year { get; set; }
        public string? LoanPerson { get; set; }
        public string? Date { get; set; }
    }
}
