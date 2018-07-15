using System;
using System.Collections.Generic;
using System.Collections;

namespace StrollThroughMUC
{
    public class Place
    {
        public string PlaceName;
        public string PlaceDescription;
        public Dictionary <String, Place> Direction = new Dictionary <String, Place>();
        public List<Item> PlaceInventory = new List<Item>();
        public List<Player> PlayersInPlace = new List<Player>();
    }
}
