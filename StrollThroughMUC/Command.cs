using System;
using System.Collections.Generic;

namespace StrollThroughMUC
{
    public class Game
    {
        public static void Play()
        {
            Munich.BuildMunich();
            Intro.HowTo();
            Current.CurrentPlayer();
            Current.CurrentItems();
            Run();
        }
        public static void Run()
        {
            string Input = Console.ReadLine();
            
            switch(Input)
            {
                case("c"):
                Console.WriteLine("Die Ausdrücke der Interationsmöglichkeiten heißen:");
                Console.WriteLine("n = North, e = East, w = West, s = South");
                Console.WriteLine("l = look, t <item> = take, c = command, q = quit, t = inventory, p <item> = drop, look=Description of character, a<character> = attack");
                Run();
                break;

                case("n"):
                try{
                    Munich.CurrentPlace= Munich.CurrentPlace.Direction["n"];
                    Current.CurrentPlayer();
                    Current.CurrentItems();
                }
                catch{Console.WriteLine("In dieser Richtung existiert leider kein Raum. Versuchs nochmal");}
                Run();
                break;

                case("e"):
                try{
                    Munich.CurrentPlace= Munich.CurrentPlace.Direction["e"];
                    Current.CurrentPlayer();
                    Current.CurrentItems();
                }
                catch{Console.WriteLine("In dieser Richtung existiert leider kein Raum. Versuchs nochmal");}
                Run();
                break;

                case("s"):
                try{
                    Munich.CurrentPlace= Munich.CurrentPlace.Direction["s"];
                    Current.CurrentPlayer();
                    Current.CurrentItems();
                }
                catch{Console.WriteLine("In dieser Richtung existiert leider kein Raum. Versuchs nochmal");}
                Run();
                break;

                case("w"):
                try{
                    Munich.CurrentPlace= Munich.CurrentPlace.Direction["w"];
                    Current.CurrentPlayer();
                    Current.CurrentItems();
                }
                catch{Console.WriteLine("In dieser Richtung existiert leider kein Raum. Versuchs nochmal");}
                Run();
                break;

                case("l"):
                Console.WriteLine(Munich.CurrentPlace.PlaceDescription);
                Run();
                break;

                case("take <item>"):
                MainCharacter.TakeItem();
                Run();
                break;

                case("t"):
                Current.CurrentInventory();
                SmartEnemy.DancePlayer();
                Run();
                break;

                case("drop <item>"):
                MainCharacter.DropItem();
                Run();
                break;

                case("q"):
                Console.WriteLine("Thanks for playing! Have a nice day!! :)");
                break;

                case("look"):
                Player.LookCharakter();
                Run();
                break;

                case("a"):
                MainCharacter.AttackEnemy();
                Run();
                break;

                case("speak"):
                MainCharacter.SpeakPlayer();
                Run();
                break;

                case("swap"):
                MainCharacter.SwapWithPlayer();
                Run();
                break;

                default:
                Console.WriteLine("Command unknown. Please type c to see which commands are accepted. :)");
                Run();
                break;

            }
        }
    }
}