using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.entity
{
    internal class Party
    {
        public List<Player> playerList { get; set; }
        public int boardSize { get; set; }
        public int boardDefaultCase { get; set; }
        public string boardName { get; set; }

        public Party(List<Player> playerList, int boardSize, string boardName)
        {
            this.playerList = playerList;
            this.boardSize = boardSize;
            this.boardName = boardName;
        }

        public Party(int boardSize, string boardName, int boardDefaultCase)
        {
            this.playerList = new List<Player>();
            this.boardSize = boardSize;
            this.boardName = boardName;
            this.boardDefaultCase = boardDefaultCase;
        }

        public void addPlayer(Player playerToAdd)
        {
            playerList.Add(playerToAdd);
        }

        public void startParty()
        {
            Console.WriteLine("Let's the " + this.boardName + " begin !!!");
            bool isPartyEnded = false;
            while (!isPartyEnded)
            {
                for (int j = 0; j < this.playerList.Count; j++)
                {
                    isPartyEnded = this.playerList[j].throwDice(this.boardSize, this.boardDefaultCase);
                    if (isPartyEnded)
                    {
                        break;
                    }
                }
            }
        }

    }
}
