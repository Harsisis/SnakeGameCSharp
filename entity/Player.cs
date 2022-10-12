﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.entity
{
    internal class Player
    {
        public string playerName { get; set; }
        public int playerCase { get; set; }

        public Player(String playerName)
        {
            this.playerName = playerName;
            this.playerCase = 0;
        }

        public bool throwDice(int boardSize, int boardDefaultCase)
        {
            bool isPartyEnded = false;
            Console.WriteLine("\nIt's " + this.playerName + " turn to throw the dice !");
            Random rd = new Random();
            int diceResult = rd.Next(1, 6);
            Console.WriteLine("Dice result : " + diceResult);

            if ((this.playerCase + diceResult) == boardSize)
            {
                this.playerCase += diceResult;
                Console.WriteLine(this.playerName + " reach the board limit and won the game !!!");
                isPartyEnded = true;
            }
            else if ((this.playerCase + diceResult) > boardSize)
            {
                this.playerCase = boardDefaultCase;
                Console.WriteLine(this.playerName + " overcome the board limit : new player position " + boardDefaultCase);
            } else
            {
                this.playerCase += diceResult;
                Console.WriteLine(this.playerName + " : new player position " + this.playerCase);
            }
            return isPartyEnded;
        }
    }
}