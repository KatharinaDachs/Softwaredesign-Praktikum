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
                Console.WriteLine("JUMP TO:   n=North |  e=East | w=West | s=South | l=Description of Room");
                Console.WriteLine("ITEM INTERACTION:  take <item>=take Item from the Place | t=inventory/your list of items | drop <item>=drop an Item of your inventory | swap=swap Item");
                Console.WriteLine("CHARACTER INTERACTION:  look=Selfdescription of Character | look=Description of character | a=attack Character | speak=speak with character");
                Console.WriteLine("NICE TO KNOW:  q=quit Game | c=show CommandInput possibilities");
                Console.WriteLine("Lasset die Spiele beginnen");
                Console.WriteLine("");
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