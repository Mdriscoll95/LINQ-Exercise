namespace LINQ
{
    public class Program
    {
        public static void Main()
        {
            List<string> gameNames = new List<string>
            {
                "Skyrim",
                "Total War : Warhammer 3",
                "Destiny",
                "World of Warcraft",
                "Star Wars Battlefront 2",
                "Diablo 3",
                "Jak and Daxter",
                "Guitar Hero 3",
                "Age of Empires 3",
                "Sid Meier's Civilization V",



            };
            var vidGames = gameNames.OrderBy(game => game.Length);
            foreach(string Games in vidGames)
            {
                Console.WriteLine(Games);
            }
            
        }
    }
}
