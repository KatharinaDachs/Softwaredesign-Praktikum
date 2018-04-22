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
        static Random subject = new Random();
        static string[] RandomSubject = subjects.OrderBy(x => subject.Next()).ToArray();

        static int subjectindex = 0;

        //VERB
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };

            //Kopie von Verb Shuffle
        static Random verb = new Random();
        static string[] RandomVerb = verbs.OrderBy(x => verb.Next()).ToArray();
        static int verbindex = 0;

        // OBJECT
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };

            // Kopie von Object Shuffle
        static Random objectt = new Random();
        static string[] RandomObject = objects.OrderBy(x => objectt.Next()).ToArray();
        static int objectindex = 0;

        // SÄTZE
        /*static string[] sentences = { };*/
        string[] zeile = new string [RandomSubject.Length];

        static string Sub;
        static string Verb;
        static string Obj;

        static void Main(string[] args)
        {
            // Verse are written
            string[] zeile = new string[RandomSubject.Length];
            for (int i = 0; i < RandomSubject.Length; i++)
            {
                GetVerse();
                zeile[i] = Sub + " " + Verb + " " + Obj;
                
                
            }
            for (int i = 0; i < RandomSubject.Length; i++)
            {
                Console.WriteLine(zeile[i]);
            
            }
        }

        
        public static void GetVerse()
        {
            //random subject
            Sub = RandomSubject[subjectindex];
            subjectindex += 1;
            

            // random verb
            Verb = RandomVerb[verbindex];
            verbindex += 1;
            

            //random object
            Obj = RandomObject[objectindex];
            objectindex += 1;
            

        }
    }
}
