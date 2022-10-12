using SnakeGame.entity;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("joueur1");
            Player player2 = new Player("joueur2");
            Player player3 = new Player("joueur3");

            Party party = new Party(50, "Mon super jeu du serpent", 25);
            party.AddPlayer(player1);
            party.AddPlayer(player2);
            party.AddPlayer(player3);

            party.StartGame();
        }
    }
}