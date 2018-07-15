using System;
using System.Collections.Generic;
using System.Collections;

namespace StrollThroughMUC
{
    public class SmartEnemy : Player
    {
        public int Healthpoints;
        //public List <SmartEnemy> SmartEnemyList = new List <SmartEnemy>(); 
        public static void DancePlayer()
        {
            Random Nr = new Random();
            int dancePartner1 = Nr.Next(1, 3);
            int dancePartner2 = Nr.Next(4,5);
            Munich.AllPlaces.AllPlacesList[dancePartner1].PlayersInPlace.Add(Munich.AllPlaces.AllPlacesList[dancePartner2].PlayersInPlace[0]);
            Munich.AllPlaces.AllPlacesList[dancePartner2].PlayersInPlace.Add(Munich.AllPlaces.AllPlacesList[dancePartner1].PlayersInPlace[0]);
            Munich.AllPlaces.AllPlacesList[dancePartner1].PlayersInPlace.Remove(Munich.AllPlaces.AllPlacesList[dancePartner1].PlayersInPlace[0]);
            Munich.AllPlaces.AllPlacesList[dancePartner2].PlayersInPlace.Remove(Munich.AllPlaces.AllPlacesList[dancePartner2].PlayersInPlace[0]);
        }
    }
}