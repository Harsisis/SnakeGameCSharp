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

        public void AddPlayer(Player playerToAdd)
        {
            playerList.Add(playerToAdd);
        }

        public void StartGame()
        {
            PrintSnake();
            Console.WriteLine("Let's the " + this.boardName + " begin !!!");
            bool isPartyEnded = false;
            while (!isPartyEnded)
            {
                for (int j = 0; j < this.playerList.Count; j++)
                {
                    isPartyEnded = this.playerList[j].ThrowDice(this.boardSize, this.boardDefaultCase);
                    if (isPartyEnded)
                    {
                        PrintFireworks();
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Print snake in ASCII art
        /// </summary>
        public void PrintSnake()
        {
            Console.WriteLine("           /^\\/^\\\r\n         _|__|  O|\r\n\\/     /~     \\_/ \\\r\n \\____|__________/  \\\r\n        \\_______      \\\r\n                `\\     \\                 \\\r\n                  |     |                  \\\r\n                 /      /                    \\\r\n                /     /                       \\\\\r\n              /      /                         \\ \\\r\n             /     /                            \\  \\\r\n           /     /             _----_            \\   \\\r\n          /     /           _-~      ~-_         |   |\r\n         (      (        _-~    _--_    ~-_     _/   |\r\n          \\      ~-____-~    _-~    ~-_    ~-_-~    /\r\n            ~-_           _-~          ~-_       _-~\r\n               ~--______-~                ~-___-~");
        }

        /// <summary>
        /// Print fireworks in ASCII art
        /// </summary>
        public void PrintFireworks()
        {
            Console.WriteLine("                                   .''.       \r\n       .''.      .        *''*    :_\\/_:     . \r\n      :_\\/_:   _\\(/_  .:.*_\\/_*   : /\\ :  .'.:.'.\r\n  .''.: /\\ :   ./)\\   ':'* /\\ * :  '..'.  -=:o:=-\r\n :_\\/_:'.:::.    ' *''*    * '.\\'/.' _\\(/_'.':'.'\r\n : /\\ : :::::     *_\\/_*     -= o =-  /)\\    '  *\r\n  '..'  ':::'     * /\\ *     .'/.\\'.   '\r\n      *            *..*         :");
        }
    }
}
