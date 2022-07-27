using System;

namespace PractiseConsole
{
 
    class Program
    {
        public delegate int Roll();

        static void Main(string[] args)
        {


            Roll rollDice = () => { //random number gen
            
                Random random = new Random();
                return random.Next(1, 7);

            };


            Dice dice1 = new Dice();
            
            int rolledDice1 = rollDice.Invoke();
            

            Dice dice2 = new Dice();

            int rolledDice2 = rollDice.Invoke();


            ColorMessage(ConsoleColor.Red,"ROLLING DICES....\n");
            ColorMessage(ConsoleColor.Green,"Die1 has rolled " + rolledDice1 + ".");
            ColorMessage(ConsoleColor.Green,$"Die2 has rolled {rolledDice2}.");


            int total = rolledDice1 + rolledDice2;

            double probability = 0;

            int rows = 0;
            int num = 0;


            Console.WriteLine("\nThe total sum of rolled dice is " + total + ".");

                  
            
            switch (total)
            {
                case 2:
                    probability = 1.0 / 36.0; // 1 possible combination of dice 1/36
                    rows = 1;
                    num = 2;
                    break;

                case 3:
                    probability = 2.0 / 36.0; // 2 possible combinations of dice 2/36
                    rows = 2;
                    num = 3;
                    break;

                case 4:
                    probability = 3.0 / 36.0; // 3 possible combination of dice 3/36
                    rows = 3;
                    num = 4;
                    break;

                case 5:
                    probability = 4.0 / 36.0; //4 possible combination of dice 4/36
                    rows = 4;
                    num = 5;
                    break;

                case 6:
                    probability = 5.0 / 36.0; //5 possible combination of dice 5/36
                    rows = 5;
                    num = 6;
                    break;

                case 7:
                    probability = 6.0 / 36.0; //6 possible combination of dice 6/36
                    rows = 6;
                    num = 7;
                    break;

                case 8:
                    probability = 5.0 / 36.0; //5 possible combination of dice 5/36
                    rows = 5;
                    num = 8;
                    break;

                case 9:
                    probability = 4.0 / 36.0; //4 possible combination of dice 4/36
                    rows = 4;
                    num = 9;
                    break;

                case 10:
                    probability = 3.0 / 36.0; // 3 possible combination of dice 3/36
                    rows = 3;
                    num = 10;
                    break;

                case 11:
                    probability = 2.0 / 36.0; // 2 possible combinations of dice 2/36
                    rows = 2;
                    num = 11;
                    break;

                case 12:
                    probability = 1.0 / 36.0; // 1 possible combination of dice 1/36
                    rows = 1;
                    num = 12;
                    break;


            }

            //int[,] allPossibleCombinations = new int[rows, 2]; //Created 2d array for storing all the possible numbers

            Console.WriteLine("-------**-------");

            //Console.WriteLine("Dice A     Dice 2");

            Console.WriteLine("The probability of rolling two dices which sums up to {0} is {1}%.\n", total, Math.Round(probability*100,2));

            Console.WriteLine("Printing all the possible combinations of the dices ('{0}') when the sum is {1}:\n", rows ,total);

            Console.WriteLine("------");

            int[,] arrayOfPossibleCombinations = ArrayOfPossibileCombs(num); //storing returned 2d array from method


            for (int i = 0; i < arrayOfPossibleCombinations.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfPossibleCombinations.GetLength(1); j++)
                {
                    Console.Write("|" + arrayOfPossibleCombinations[i, j] + "|");

                }
                Console.Write("\n-----");
                Console.WriteLine();
            }         


            Console.ReadLine();
        }

        private static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static int[,] ArrayOfPossibileCombs(int sum)
        {
            Dictionary<int, int[,]> dicForArray = DictionaryOfCombs();

            int[,] arrayOfCombinations = dicForArray[sum];
    
            return arrayOfCombinations;
        }

        private static Dictionary<int, int[,]> DictionaryOfCombs()
        {

            Dictionary<int, int[,]> keyValuePairs = new Dictionary<int, int[,]>();
            keyValuePairs.Add(2, new int[,] { { 1, 1 } });
            keyValuePairs.Add(3, new int[,] { { 2, 1 }, { 1, 2 } });
            keyValuePairs.Add(4, new int[,] { { 2, 2 }, { 1, 3 }, { 3, 1 } });
            keyValuePairs.Add(5, new int[,] { { 4, 1 }, { 1, 4 }, { 2, 3 }, { 3, 2 } });
            keyValuePairs.Add(6, new int[,] { { 1, 5 }, { 5, 1 }, { 3, 3 }, { 4, 2 }, { 2, 4 } });
            keyValuePairs.Add(7, new int[,] { { 1, 6 }, { 6, 1 }, { 3, 4 }, { 4, 3 }, { 2, 5 }, { 5, 2 } });
            keyValuePairs.Add(8, new int[,] { { 1, 7 }, { 7, 1 }, { 5, 3 }, { 3, 5 }, { 4, 4 } });
            keyValuePairs.Add(9, new int[,] { { 6, 3 }, { 3, 6 }, { 5, 4 }, { 4, 5 } });
            keyValuePairs.Add(10, new int[,] { { 6, 4 }, { 4, 6 }, { 5, 5 } });
            keyValuePairs.Add(11, new int[,] { { 6, 5 }, { 5, 6 } });
            keyValuePairs.Add(12, new int[,] { { 6, 6 } });


            return keyValuePairs;
        }


    }

    class Dice
    {

       

    }




}



