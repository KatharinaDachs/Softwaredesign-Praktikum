using System;

namespace aufgabe1i1
{
    class Program
    {

        static void Main(string[] args)
        {
           /* foreach (string arg in args){
                 Console.WriteLine(arg);
            }*/
            
            switch (args[0]){
                
                case "w":
                getCubeInfo(double.Parse(args[1]));
                break;

                case "k":
                getSphereInfo(double.Parse(args[1]));
                break;

                case "o":
                getOctaederInfo(double.Parse(args[1]));
                break;

                default:
                Console.WriteLine("Falsche Eingabe!!"); 
                break;
            }
            
        }
        // Würfel
        public static double getCubeSurface(double d){
            double oberflaecheW = 6 * (d * d);
            return oberflaecheW;
        }

        public static double getCubeVolumen(double d){
            double volumenW = d * d * d;
            return volumenW;
        }

        static void getCubeInfo(double d){
            double Ober = getCubeSurface(d);
            Ober = Math.Round(Ober,2);
            double Vol = getCubeVolumen(d);
            Vol = Math.Round(Vol,2);
            Console.WriteLine("Würfel:  A= " + Ober + " | V= "  + Vol);
        }

        // Kugel
        public static double getSphereSurface(double d){  //Kugel A=πd², V=πd³/6
            double oberflaecheK = Math.PI * (d * d);
            return oberflaecheK;
        }

        public static double getSphereVolumen(double d){
            double volumenK = (Math.PI * (d * d * d)) / 6;
            return volumenK;
        }

        static void getSphereInfo(double d){
            double Ober = getSphereSurface(d);
            Ober = Math.Round(Ober,2);
            double Vol = getSphereVolumen(d);
            Vol = Math.Round(Vol,2);
            Console.WriteLine("Kugel:  A=" + Math.Round(Ober,2) + " | V="  + Math.Round(Vol,2));
        }

        //Oktaeder
        public static double getOctaederSurface(double d){ //Oktaeder A=2(√3)d² , V=(√2)d³/3
            double volumenO = 2 * (Math.Sqrt(3)) * (d * d);
            return volumenO;
        }

        public static double getOctaederVolumen(double d){
            double oberflaecheO = ((Math.Sqrt(3)) * (d * d * d)) / 3;
            return oberflaecheO;
        }

        static void getOctaederInfo(double d){
            double Ober = getOctaederSurface(d);
            Ober = Math.Round(Ober,2);
            double Vol = getOctaederVolumen(d);
            Vol = Math.Round(Vol,2);
            Console.WriteLine("Oktaeder:  A=" + Math.Round(Ober,2) + " | V="  + Math.Round(Vol,2));
        }

    }   
}
