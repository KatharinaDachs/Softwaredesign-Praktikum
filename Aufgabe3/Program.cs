using System;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertDecimalToHexal(121));
            Console.WriteLine(ConvertHexalToDezimal(43));
            Console.WriteLine(ConvertToBaseFromDecimal(6, 121));
            Console.WriteLine(ConvertToDecimalFromBase(6, 321));
        }

        //Part 1
        public static int ConvertDecimalToHexal(int dec){
            string hexalRest = "";
            if(dec >= 0 && dec <= 1023){
                while (dec >= 1){
                    hexalRest = (dec % 6) + hexalRest;
                    dec = dec / 6; 
                }
            }
            return Convert.ToInt32(hexalRest);
        }

        //Part 2
       public static int ConvertHexalToDezimal(int hexal){
            string hexalString = ""  + hexal;
            var hexalEinzeln = hexalString.ToCharArray();
            int hexalLength = hexalString.Length-1;
            int deci = 0;
            for (int i = 0; i<hexalString.Length; i++){
                deci +=  hexalEinzeln[hexalLength] * (int)Math.Pow(6,i);
                hexalLength -= 1;           
            }
            return deci;
        }

        //Part 3
        public static int ConvertToBaseFromDecimal(int toBase, int dec){
            string baseRest = "";
            if(dec <= 0 && dec >= 1023){
                while (dec >= 1){
                    baseRest = (dec % toBase) + baseRest;
                    dec = dec / toBase; 
                }
            }
            return Convert.ToInt32(baseRest);
        }

        //Part 4
        public static int ConvertToDecimalFromBase(int fromBase, int number){
            string baseString = ""  + number;
            var baseEinzeln = baseString.ToCharArray();
             int baseLength = baseString.Length-1;
            int decimalConverted = 0;
            for (int i = 0; i<baseString.Length; i++){
               decimalConverted += baseEinzeln[baseLength] * (int)Math.Pow(fromBase,i);
               baseLength -= 1;
            }
            return decimalConverted;
        }

        //Final Part 5

        public static int ConvertNumberToBaseFromBase(int number, int toBase, int fromBase){
            int convertedBase= 0;
            if(1< toBase && toBase > 1 && 1< fromBase && fromBase > 1){
                int dec=0;
                dec = (ConvertToDecimalFromBase(fromBase,number));
                convertedBase= ConvertToBaseFromDecimal(toBase,dec); 
            }
            return convertedBase;

        }

    }
}
