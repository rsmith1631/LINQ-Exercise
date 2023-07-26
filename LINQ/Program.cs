namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Pacman", "Super Mario Brothers", "Halo", "Karate Man" };
            var gameOrder = videoGames.OrderBy(games => games.Length);
            
            foreach (var game in gameOrder)
            {
                Console.WriteLine(game);
            }
        }
    }
}
