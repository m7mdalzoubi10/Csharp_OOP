using System;
using static System.Console;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main()
        {
            List<Player> Names = new List<Player> ();

            Player player1 = new Player("Moh");
            Player player2 = new Player("Ahmed");
            Player player3 = new Player("Khaled");

            Names.Add(new Player("Rashed") );  //Same as making New player 1,2,3 then Adding it by Names.Add but it shorter

            Names.Add(player1);
            Names.Add(player2);
            Names.Add(player3);

            foreach (Player name in Names)
            {
                WriteLine(name);
            }

            ReadKey();
        }
    }


    class Player
    {
        public string Username;

        public Player(string Username)
        {
            this.Username = Username;
        }

        public override string ToString()
        {
            return Username;
        }
    }

}