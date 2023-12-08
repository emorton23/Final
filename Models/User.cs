namespace Final.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string Username {get; set;}=string.Empty;
        public List<Game> Games {get; set;} = default!;
    }
}