using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_TemplateMethod
{
    public abstract class Game
    {
        protected int currentPlayer;
        protected readonly int numberOfPlayers;
        // other members omitted

        protected abstract void Start();
        protected abstract bool HaveWinner { get; }
        protected abstract void TakeTurn();
        protected abstract int WinningPlayer { get; }

        public Game(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }
       

        public void Run()
        {
            Start();
            while (!HaveWinner)
                TakeTurn();
            Console.WriteLine($"Player {WinningPlayer} wins.");
        }
    }
}
