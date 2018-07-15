using System;
using System.Collections.Generic;

namespace StrollThroughMUC
{

    public class Current
    {
        public static void CurrentPlayer()
        {
            Console.WriteLine(Munich.CurrentPlace.PlaceDescription);
            Console.WriteLine("Hier befindet sich folgender Spieler:");
            Munich.CurrentPlace.PlayersInPlace.ForEach(delegate(Player Person )
            {
            Console.WriteLine(Person.Name);
            });
        }

        public static void CurrentItems()
        {
            Console.WriteLine("Diese Items sind hier zu finden:");
            Munich.CurrentPlace.PlaceInventory.ForEach(delegate(Item Thing )
            {
            Console.WriteLine(Thing.ItemName);
            });
        }

        public static void CurrentInventory()
        {
            Console.WriteLine("In deinem Inventory befindet sich:");
            Munich.Pati.PlayerInventory.ForEach(delegate(Item Itm)
            {
                Console.WriteLine(Itm.ItemName);
            });
            Console.WriteLine("Schau aber nicht zu lange ins Inventory! Die Mitspieler tanzen dir sonst von der Nase davon!!");
        }
    }
}