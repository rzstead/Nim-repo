﻿using Nim.CpuVsCpu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    public class Menu
    {
        private Game game;
        int repeat = 0;

        public Menu(Game game)
        {
            this.game = game;
        }

        public void Select()
        {
            int i = 0;
            bool goodinput = false;
            while (!goodinput)
            {
                Console.WriteLine("Please Select Game mode \n 1:P v P \n 2:P v Cpu \n 3:Cpu v Cpu \n 4:Cpu v Smart Cpu \n 5:P v Smart Cpu");
                string s = Console.ReadLine();
                bool b = int.TryParse(s, out i);
                if (!b || i < 1 || i > 5)
                {
                    Console.WriteLine("ERROR:Invalid input. Please Enter A Number Between 1 and 5");
                }
                else
                {
                    goodinput = true;
                }
            }

            UseSelection(i);

        }
        public void UseSelection(int selection)
        {

            int sleepCounter = 1000;

            if (selection == 4)
            {
                sleepCounter = 0;
                bool goodinput = false;
                while (!goodinput)
                {
                    Console.WriteLine("How many games do you want to play:");
                    string s = Console.ReadLine();
                    bool b = int.TryParse(s, out repeat);
                    if (!b || repeat < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR:Invalid input. Please Enter A Number Above 0");
                    }
                    else
                    {
                        goodinput = true;
                    }
                }
            }
            game.Start(selection, sleepCounter);
            if (selection == 4)
            {
                game.resetStats();
                for (int i = 0; i < repeat; i++)
                {
                    game.Start(selection, sleepCounter);
                }
                showStats(game.p1Count, game.p2Count);
            }
            PlayAgain(selection);
        }

        private void showStats(int p1, int p2)
        {
            Console.WriteLine("Player 1 won " + p1 + " times.\nPlayer 2 won " + p2 + " times.");
            Console.WriteLine("Stats: \n\nPlayer 1 won " + Math.Truncate(((p1 / (double)(p1 + p2)) * 100)) +
                "% of the games.\nPlayer 2 won " + Math.Truncate(((p2 / (double)(p1 + p2)) * 100)) + "% of the games.");
        }

        public void PlayAgain(int selection)
        {
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Do you want to play again y/n");
                string s = Console.ReadLine();
                if (char.ToLower(s[0]) == 'y')
                {
                    UseSelection(selection);
                    valid = true;

                }
                else if (char.ToLower(s[0]) == 'n')
                {
                    valid = true;
                    DiffrentSelection();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                }
            }
        }
        public void DiffrentSelection()
        {
            bool svalid = false;
            while (!svalid)
            {
                Console.WriteLine("Do you want to make a diffrent selection y/n");
                string s2 = Console.ReadLine();
                if (char.ToLower(s2[0]) == 'y')
                {
                    Console.Clear();
                    Select();
                    svalid = true;
                }
                else if (char.ToLower(s2[0]) == 'n')
                {
                    svalid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine("Exit");
            }
        }
    }

}
