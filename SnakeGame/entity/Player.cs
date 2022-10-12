namespace SnakeGame.entity {
    public class Player {
        public string playerName { get; set; }
        public int playerCase { get; set; }

        public Player(string playerName) {
            this.playerName = playerName;
            this.playerCase = 1;
        }

        /// <summary>
        /// Throw dice and check if game is ended or not
        /// </summary>
        /// <param name="boardSize"></param>
        /// <param name="boardDefaultCase"></param>
        /// <returns></returns>
        public bool ThrowDice(int boardSize, int boardDefaultCase) {
            bool isPartyEnded;
            Random rd = new Random();
            Console.WriteLine($"\nIt's {this.playerName} turn to throw the dice !");
            int diceResult = rd.Next(1, 7);
            Console.WriteLine($"Dice result : {diceResult}");

            this.playerCase += diceResult;
            isPartyEnded = CheckPlayerPosition(boardSize, boardDefaultCase);

            return isPartyEnded;
        }

        public bool CheckPlayerPosition(int boardSize, int boardDefaultCase) {
            if (this.playerCase == boardSize) {
                Console.WriteLine($"{this.playerName} reach the board limit and won the game !!!");
                return true;
            } else if (this.playerCase > boardSize) {
                this.playerCase = boardDefaultCase;
                Console.WriteLine($"{this.playerName} overcome the board limit : new player position {boardDefaultCase}");
            } else {
                Console.WriteLine($"{this.playerName} : new player position {this.playerCase}");
            }
            return false;
        }
    }
}
