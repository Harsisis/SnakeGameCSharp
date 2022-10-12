using SnakeGame.entity;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("joueur1");
            Player player2 = new Player("joueur2");

            Party party = new Party(50, "Mon super jeu du serpent", 25);
            party.addPlayer(player1);
            party.addPlayer(player2);

            party.startParty();
        }
    }
}