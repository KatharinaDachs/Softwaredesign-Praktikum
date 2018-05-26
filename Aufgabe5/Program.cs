using System;

namespace Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Person
        {
            string name;
            int age;
        }

        public class Teilnehmer : Person
        {
            int registration_number;

            string[] kurse;

            }
        }
        public class Dozent : Person
        {
            float room;
            DateTime office_hours;

            string[] kurse;

            }
        }
        public class Course
        {
            string title;
            DateTime course_hours;
            float room;
            string dozent;
            string[] teilnehmer;
        {
    }
}
