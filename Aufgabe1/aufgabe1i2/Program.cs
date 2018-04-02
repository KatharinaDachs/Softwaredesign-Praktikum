using System;
using System.Linq;
using System.Collections;

namespace aufgabe1i2
{
    class Program
    {
        // SUBJECT
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };

                // Kopie von Subject Shuffle

        static Random subject=new Random();
        static string[] RandomSubject = subjects.OrderBy(x => subject.Next()).ToArray();

        static int subjectindex = 0;

        //VERB
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };

                //Kopie von Verb Shuffle
        static Random verb =new Random();
        static string[] RandomVerb = verbs.OrderBy(x => verb.Next()).ToArray();
        static int verbindex = 0;

        // OBJECT
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };

                // Kopie von Object Shuffle
        static Random objectt =new Random();
        static string[] RandomObject = objects.OrderBy(x => objectt.Next()).ToArray();
        static int objectindex = 0;

        // SÄTZE
        static string[] sentences = {};

        static void Main(string[] args)
        {
            // Verse werden geschrieben
            for(int i=0; i<RandomSubject.Length; i++){
                sentences[i]= GetVerse();
            }
            for (int i = 0; i< RandomSubject.Length; i++){
            Console.WriteLine(sentences[i]);
            }
        }
        public static string GetVerse(){
            //random subject
                // Random wort wird vom Random Array, der oben erzeugt wurde,ausgewählt. Hierbei wird mit dem Wort im Index 0 begonnen und bei erneutem 
                // aufrufen Idnex 1, 2, 3, etc eingesetzt. 
            string sub = RandomSubject[subjectindex];
            subjectindex += 1;

            // random verb
            string ver = RandomVerb[verbindex];
            verbindex += 1;

            //random object
            string obj = RandomObject[objectindex];
            objectindex += 1;

            // Verszeile wird zusammengefügt
            string zeile = sub + " " + ver + " " + obj;
            return zeile;

        }
    }
}
