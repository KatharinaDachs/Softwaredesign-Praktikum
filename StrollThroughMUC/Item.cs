using System;
using System.Collections.Generic;
using System.Collections;

namespace StrollThroughMUC
{
    public class Item
    {
        public string ItemName;
        public List <SmartEnemy> SmartEnemyList = new List <SmartEnemy>();
        public List <Place> AllPlacesList = new List <Place>();
    }
}