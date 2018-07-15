
using System;
using System.Collections.Generic;
using System.Collections;

namespace StrollThroughMUC
{
    public class MainCharacter:Player
    {
         public static void TakeItem()
        {
            Current.CurrentItems();
            Console.WriteLine("Gib den Namen deines gewünschten Items ein!");
            bool ItemNameCheck = false;
            string ItemNameInput = Console.ReadLine();
            for(int i = 0; i < Munich.CurrentPlace.PlaceInventory.Count; i++)
            {
                if(Munich.CurrentPlace.PlaceInventory[i].ItemName == ItemNameInput)
                {
                    Munich.Pati.PlayerInventory.Add(Munich.CurrentPlace.PlaceInventory[i]);
                    Munich.CurrentPlace.PlaceInventory.Remove(Munich.CurrentPlace.PlaceInventory[i]);
                    ItemNameCheck = true;
                }
            }
            if(ItemNameCheck == false)
            {
                Console.WriteLine("Heyyy.. Ich hab dir doch grade gesagt welche Items du nehmen darfst! Versuch es nochmal *Item take*" );

            }
        }
        public static void DropItem()
        {
            Current.CurrentInventory();
            Console.WriteLine("Welches Item möchtes du ablegen?");
            bool ItemNameCheck = false;
            string ItemNameInput = Console.ReadLine();
            for(int i = 0; i < Munich.Pati.PlayerInventory.Count; i++)
            {
                if(Munich.Pati.PlayerInventory[i].ItemName == ItemNameInput)
                {
                    Munich.CurrentPlace.PlaceInventory.Add(Munich.Pati.PlayerInventory[i]);
                    Munich.Pati.PlayerInventory.Remove(Munich.Pati.PlayerInventory[i]);
                    ItemNameCheck = true;
                }
            }
            if(ItemNameCheck == false)
            {
                Console.WriteLine("Heyyy.. Ich hab dir doch grade gesagt welche Items du ablegen kannst! Versuch es nochmal *drop item*" );

            }
        }

        public static void SwapWithPlayer()
        {
            if(Munich.Pati.PlayerInventory.Count != 0)
            {
                Current.CurrentPlayer();
                Console.WriteLine("Gib den Namen des Charakters ein, mit dem du Item tauschen möchtest");
                string ItemNameInput = Console.ReadLine();
                bool PlayerNameCheck = false;
                for(int i = 0; i < Munich.CurrentPlace.PlayersInPlace.Count; i++)
                {
                    if(Munich.CurrentPlace.PlayersInPlace[i].Name == ItemNameInput && Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory.Count != 0)
                    {
                        PlayerNameCheck = true;
                        Console.WriteLine("Player " + Munich.CurrentPlace.PlayersInPlace[i].Name + " hat folgende Items:");
                        Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory.ForEach(delegate(Item Thing )
                        {
                            Console.WriteLine(Thing.ItemName);
                        });
                        Console.WriteLine("Gib den Namen des Items an, welches du haben möchtest");
                        string GetItem = Console.ReadLine();
                        bool GetItemNameCheck = false;
                        for(int x = 0; x < Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory.Count; x++)
                        {
                            if(Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory[x].ItemName == GetItem)
                            {
                                GetItemNameCheck = true;
                                Munich.Pati.PlayerInventory.Add(Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory[x]);
                                Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory.Remove(Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory[x]);
                                Console.WriteLine("In deinem Inventory befindet sich:");
                                Munich.Pati.PlayerInventory.ForEach(delegate(Item Itm)
                                {
                                    Console.WriteLine(Itm.ItemName);
                                });
                                Console.WriteLine("Gib den Namen des Items an, welches du hergeben möchtest");
                                string GiveItem = Console.ReadLine();
                                bool DropItemNameCheck = false;
                                for(int y = 0; y < Munich.Pati.PlayerInventory.Count; y++)
                                {
                                    if(Munich.Pati.PlayerInventory[y].ItemName == GiveItem)
                                    {
                                        DropItemNameCheck = true;
                                        Munich.CurrentPlace.PlayersInPlace[i].PlayerInventory.Add(Munich.Pati.PlayerInventory[y]);
                                        Munich.Pati.PlayerInventory.Remove(Munich.Pati.PlayerInventory[y]);
                                    }
                                }
                                if(DropItemNameCheck == false)
                                {
                                    Console.WriteLine("Heyyy.. Ich hab dir doch grade gesagt welche Items du hergeben darfst! Versuch es nochmal *swap*" );
                                }
                            }
                        }
                        if(GetItemNameCheck == false)
                        {
                            Console.WriteLine("Heyyy.. Ich hab dir doch grade gesagt welche Items du nehmen darfst! Versuch es nochmal *swap*" );
                        }
                    }
                }
                if(PlayerNameCheck== false)
                {
                    Console.WriteLine("Falscher character oder character hat keine Items");
                }
            }else
            {
                Console.WriteLine("Du hast keine Items!!");
            }
        }
        public static void SpeakPlayer()
        {
            Current.CurrentPlayer();
            Console.WriteLine("Gib den Namen des Charakters ein, mit dem du reden möchtest");
            string ItemNameInput = Console.ReadLine();
            bool SpeakCheck = false;
            for(int i = 0; i < Munich.CurrentPlace.PlayersInPlace.Count; i++)
            {
                if(Munich.CurrentPlace.PlayersInPlace[i].Name == ItemNameInput)
                {
                    SpeakCheck = true;
                    Console.WriteLine("Heyyyy wie gehts? Lange nicht mehr gesehen!");
                    Console.WriteLine("[Write 'Good and you?' or 'Not good and you?']");
                    string OptionInput = Console.ReadLine();
                    switch (OptionInput){
                        case("Good and you?"):
                        Console.WriteLine("Super freut mich dass es dir gut geht! Ich für meinen Teil kann sagen, dass " + Munich.CurrentPlace.PlayersInPlace[i].ConversationSentence);
                        break;

                        case("Not good and you?"):
                        Console.WriteLine("Aach das wird schon wieder. Die Sonne strahlt heute und am Ende des Tages wird dein Gesicht genauso zurückstrahlen, glaub mir. Ich für meinen Teil kann sagen, dass " + Munich.CurrentPlace.PlayersInPlace[i].ConversationSentence);
                        break;

                        default:
                        Console.WriteLine("Sorry ich versteh deine Frage nicht.");
                        break;
                    }
                }
            }
            if (SpeakCheck == false)
            {
            Console.WriteLine("Lern mal richtig schreiben... Bitte <speak> erneut tippen");
            }
        }

        public static void AttackEnemy()
        {
            Current.CurrentPlayer();
            Console.WriteLine("Gib den Namen des Charakters ein, den du attackieren möchtest");
            string ItemNameInput = Console.ReadLine();
            for(int i = 0; i < Munich.CurrentPlace.PlayersInPlace.Count; i++)
            {
                if(Munich.CurrentPlace.PlayersInPlace[i].Name == ItemNameInput )
                {
                    if (ItemNameInput == "Pati")
                    {
                        Console.WriteLine("Sich selbst attackieren ist nicht sehr schlau...");
                        Game.Run();
                    }else{
                        Munich.AllEvil.SmartEnemyList.ForEach(delegate(SmartEnemy Enemy ){
                            if(Enemy.Name == ItemNameInput)
                            {
                                Enemy.Healthpoints -= 1;
                                if(Enemy.Healthpoints == 0)
                                {
                                    Console.WriteLine("Du hast den Spieler besiegt!");
                                    Munich.CurrentPlace.PlayersInPlace.Remove(Munich.CurrentPlace.PlayersInPlace[i]);
                                    Munich.AllEvil.SmartEnemyList.Remove(Enemy);
                                    if (Munich.AllEvil.SmartEnemyList.Count == 0)
                                    {
                                        Console.WriteLine (" DU HAST GEWONNEN JUHUUUU !! ");
                                        Console.WriteLine ("Nur so als Tipp. Hol dir therapeutische Hilfe. Du hast echt ein leichtes Aggressionsproblem und unschuldige Leute umgebracht...Naja vielleicht kommst du auch in den Knast. Viel Spaß");
                                        EndGoodEverythingGood.EndOfMUC();;
                                    }else{
                                        Game.Run();
                                    }
                                }else{
                                    Console.WriteLine("Hau ihm noch eine rein! Bald ist er erledigt!");
                                    Game.Run();
                                }
                            }
                        }); 
                    }  
                }else{
                    Console.WriteLine("Heyyy.. Ich hab dir doch grade gesagt wer attackiert werden kann! Versuch es nochmal *drop item*" );
                    Game.Run();
                }
            }
        }
    }
}