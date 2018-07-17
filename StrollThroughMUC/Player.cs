using System;
using System.Collections.Generic;
using System.Collections;

namespace StrollThroughMUC
{
    public class Player
    {
        public string Name;
        public string ConversationSentence;
        public string Selfdescription;
        public List<Item> PlayerInventory = new List<Item>();
        public static void LookCharakter()
        {
            Current.CurrentPlayer();
            Console.WriteLine("Gib den Namen des Charakters ein, zu dem du die Beschreibung haben möchtest");
            string PlayerNameInput = Console.ReadLine();
            bool checkPlayerName = false;
            for(int i = 0; i < Munich.CurrentPlace.PlayersInPlace.Count; i++)
            {
                if(Munich.CurrentPlace.PlayersInPlace[i].Name == PlayerNameInput)
                {
                    Console.WriteLine(Munich.CurrentPlace.PlayersInPlace[i].Selfdescription);
                    checkPlayerName = true;
                }
                if (checkPlayerName == false)
                {
                Console.WriteLine("Heyyy.. Ich hab dir doch grade gesagt welche Charaktere im Raum sind! Versuch es nochmal *look*" );
                }
            }
        }
    }
}
