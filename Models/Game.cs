namespace Final.Models
{
    public class Game
    {
        public int GameId {get; set;}
        public string Title {get; set;}=string.Empty;
        public string Developer {get; set;}=string.Empty;
        public string Genre {get; set;}=string.Empty;
        public double? Price {get; set;}
        public int? UserId {get; set;}
        public User? User {get; set;}
    }
}