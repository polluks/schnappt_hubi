﻿using System;

namespace Hubi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"

                            Schnappt

         ('-. .-. #             #.-. .-')   #          #
        ( OO )  / #             #\  ( OO )  #          #
        ,--. ,--. # ,--. ,--.   # ;-----.\  #  ,-.-')  #
        |  | |  | # |  | |  |   # | .-.  |  #  |  |OO) #
        |   .|  | # |  | | .-') # | '-' /_) #  |  |  \ #
        |       | # |  |_|( OO )# | .-. `.  #  |  |(_/ #
        |  .-.  | # |  | | `-' /# | |  \  | # ,|  |_.' #
        |  | |  | #('  '-'(_.-' # | '--'  / #(_|  |    #
        `--' `--' #  `-----'    # `------'  #  `--'    #

");
            Console.Write("Level 1-3: ");
            int lev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Player Order (rgby): ");
            string players = Console.ReadLine();

            if(lev < 1 || lev > 3)
            {
                Console.WriteLine("Wrong level");
                return;
            }
            if (players.Length < 2 || players.Length > 4 )
            {
                Console.WriteLine("Wrong players");
                return;
            }

            var game = new Game(false, lev,players);
            game.Init();
            var isEnd = false;
            while(!isEnd)
            {
                isEnd = game.Loop();
            }
        }
    }
}
