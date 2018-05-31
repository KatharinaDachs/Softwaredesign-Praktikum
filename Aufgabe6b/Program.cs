using System;
using System.Collections.Generic;

namespace DesPatternDecorator
{

    
    public class Spielfigur
    {
        public virtual void Drohe()
        {
        }
    }
    public class Monster : Spielfigur
    {
        public override void Drohe()
        {
            // Calling the base class GetInfo method:
           // base.Drohe();
            Console.Write("GRRR");
        }
    }

    class Held : Spielfigur
    {
        public override void Drohe()
        {
            // Calling the base class GetInfo method:
            //base.Drohe();
            Console.Write("Weiche zurück");
        }
    }

    //Decorator
     public class Decorator : Spielfigur
    {
        private Spielfigur _original;
        public Decorator(Spielfigur original)
        {
            _original = original; 
        }
        public override void Drohe()
        {
            _original.Drohe();
        }
    }

    class ErkaelteteFigur : Decorator
    {
        public ErkaelteteFigur(Spielfigur original)
        
           :base (original){}
        
        public override void Drohe()
        {
            base.Drohe();
            Console.Write(" Hust!");
        }
    }

    class HeisereFigur : Decorator
    {
        public HeisereFigur(Spielfigur original)
        :base (original){}

        public override void Drohe()
        {
            Console.Write("Räusper....");
            base.Drohe();
        }
    }

    class TestClass
    {
        static void Main()
        {

            List<Spielfigur> figuren = new List<Spielfigur>();

            figuren.Add(new Monster());
            figuren.Add(new Held());
            figuren.Add(new ErkaelteteFigur(new Held()));
            figuren.Add(new HeisereFigur(new Held()));

            foreach(var spielfigur in figuren)
            {
                spielfigur.Drohe();
                Console.WriteLine();
            }
        }
    }
}