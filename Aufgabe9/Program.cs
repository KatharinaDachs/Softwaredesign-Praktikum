using System;

namespace Aufgabe9
{
    class Program
    {

        public static char[] gameData = {'1', '2', '3', '4', '5', '6','7', '8', '9'};

        public static int count = 0;
        public static char player ;

        public static string playerInput;

        static void Main(string[] args)
        {
            
           gamePrep();
           for(;;)
           {
                printGameData();  
                // O or X ?
                if (count %2 != 0 ){ 
                    //X is added
                    player = 'X';
                }else{
                    // O is added
                    player = 'O';
                }

                playerInput = Console.ReadLine();    

                if (playerInput.ToLower() == "exit")
                {
                    Console.WriteLine("Have a nice day!");
                    break;  
                }

                try
                {
                    int intInput; 

                    intInput = Convert.ToInt32(playerInput);

                    if (gameData[intInput - 1] == 'O' || gameData[intInput - 1] == 'O')
                    {
                        Console.WriteLine("Number is occupied");
                    }
                    else
                    {
                        count++;
                        gameData[intInput - 1] = player;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Number between 1 and 9 is needed!");
                }

                if (checkWin())
                {
                    Console.WriteLine("Player " + player + " is the Winner!");
                    break;
                }
                else
                {
                    if (count >= 9)
                    Console.WriteLine("Draw!");
                    break;
                }     
            }
        }

        public static void gamePrep()
        {
            Console.WriteLine("Servus! Let the games begin. Whoever doesn't know about the ruless...just google it pls. Tack!");
      
        }

        public static bool checkWin ()
        {
            if(
                (gameData[0] == gameData[1]) && (gameData[1] == gameData[2]) && (gameData[0] != ' ')
                || (gameData[3] == gameData[4]) && (gameData[4] == gameData[5]) && (gameData[3] != ' ')
                || (gameData[6] == gameData[7]) && (gameData[7] == gameData[8]) && (gameData[6] != ' ')
                || (gameData[0] == gameData[3]) && (gameData[3] == gameData[6]) && (gameData[0] != ' ')
                || (gameData[1] == gameData[4]) && (gameData[4] == gameData[7]) && (gameData[1] != ' ')
                || (gameData[2] == gameData[5]) && (gameData[5] == gameData[8]) && (gameData[2] != ' ')
                || (gameData[0] == gameData[4]) && (gameData[4] == gameData[8]) && (gameData[0] != ' ')
                || (gameData[2] == gameData[4]) && (gameData[4] == gameData[6]) && (gameData[2] != ' ')
                )
                return true;
            else
                return false;
        }

        public static void printGameData()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("|" + gameData[0] + "|" + gameData[1] + "|" + gameData[2] + "|");
            Console.WriteLine("|" + gameData[3] + "|" + gameData[4] + "|" + gameData[5] + "|");
            Console.WriteLine("|" + gameData[6] + "|" + gameData[7] + "|" + gameData[8] + "|");
            Console.WriteLine("=========================================");
        }
    }
}
