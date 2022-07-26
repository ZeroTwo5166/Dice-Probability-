using System;

namespace PractiseConsole
{
    

    class Program
    {
        public delegate int Roll();

        static void Main(string[] args)
        {



            Roll rollDice = () => {
            
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

            int[,] allPossibleCombinations = new int[rows, 2]; //Created 2d array for storing all the possible numbers

            Console.WriteLine("-------**----------");

            //Console.WriteLine("Dice A     Dice 2");

            Console.WriteLine("The probability of rolling two dices which sums up to {0} is {1}%.\n", total, Math.Round(probability*100,2));

            Console.WriteLine("Printing all the possible combinations of the dices ('{0}') when the sum is {1}:\n", rows ,total);


            Console.WriteLine("------");
            while (true)
            {
                if (rows == 1 && num == 2)
                {
                    allPossibleCombinations[0, 0] = 1;
                    allPossibleCombinations[0, 1] = 1;

                }

                else if (rows == 2 && num == 3)
                {
                    allPossibleCombinations[0, 0] = 1;
                    allPossibleCombinations[0, 1] = 2;
                    allPossibleCombinations[1, 0] = 2;
                    allPossibleCombinations[1, 1] = 1;
                }

                else if (rows == 3 && num == 4)
                {
                    allPossibleCombinations[0, 0] = 1;
                    allPossibleCombinations[0, 1] = 3;
                    allPossibleCombinations[1, 0] = 2;
                    allPossibleCombinations[1, 1] = 2;
                    allPossibleCombinations[2, 0] = 3;
                    allPossibleCombinations[2, 1] = 1;
                }

                else if (rows == 4 && num == 5)
                {
                    allPossibleCombinations[0, 0] = 1;
                    allPossibleCombinations[0, 1] = 4;
                    allPossibleCombinations[1, 0] = 4;
                    allPossibleCombinations[1, 1] = 1;
                    allPossibleCombinations[2, 0] = 2;
                    allPossibleCombinations[2, 1] = 3;
                    allPossibleCombinations[3, 0] = 3;
                    allPossibleCombinations[3, 1] = 2;
                }

                else if (rows == 5 && num == 6)
                {
                    allPossibleCombinations[0, 0] = 1;
                    allPossibleCombinations[0, 1] = 5;
                    allPossibleCombinations[1, 0] = 5;
                    allPossibleCombinations[1, 1] = 1;
                    allPossibleCombinations[2, 0] = 3;
                    allPossibleCombinations[2, 1] = 3;
                    allPossibleCombinations[3, 0] = 4;
                    allPossibleCombinations[3, 1] = 2;
                    allPossibleCombinations[4, 0] = 2;
                    allPossibleCombinations[4, 1] = 4;
                }

                else if (rows == 6 && num == 7)
                {
                    allPossibleCombinations[0, 0] = 1;
                    allPossibleCombinations[0, 1] = 6;
                    allPossibleCombinations[1, 0] = 6;
                    allPossibleCombinations[1, 1] = 1;
                    allPossibleCombinations[2, 0] = 4;
                    allPossibleCombinations[2, 1] = 3;
                    allPossibleCombinations[3, 0] = 3;
                    allPossibleCombinations[3, 1] = 4;
                    allPossibleCombinations[4, 0] = 5;
                    allPossibleCombinations[4, 1] = 2;
                    allPossibleCombinations[5, 0] = 2;
                    allPossibleCombinations[5, 1] = 5;
                }

                else if (rows == 5 && num == 8)
                {
                    allPossibleCombinations[0, 0] = 2;
                    allPossibleCombinations[0, 1] = 6;
                    allPossibleCombinations[1, 0] = 6;
                    allPossibleCombinations[1, 1] = 2;
                    allPossibleCombinations[2, 0] = 4;
                    allPossibleCombinations[2, 1] = 4;
                    allPossibleCombinations[3, 0] = 5;
                    allPossibleCombinations[3, 1] = 3;
                    allPossibleCombinations[4, 0] = 3;
                    allPossibleCombinations[4, 1] = 5;
                }

                else if (rows == 4 && num == 9)
                {
                    allPossibleCombinations[0, 0] = 5;
                    allPossibleCombinations[0, 1] = 4;
                    allPossibleCombinations[1, 0] = 4;
                    allPossibleCombinations[1, 1] = 5;
                    allPossibleCombinations[2, 0] = 6;
                    allPossibleCombinations[2, 1] = 3;
                    allPossibleCombinations[3, 0] = 3;
                    allPossibleCombinations[3, 1] = 6;
                }

                else if (rows == 3 && num == 10)
                {
                    allPossibleCombinations[0, 0] = 5;
                    allPossibleCombinations[0, 1] = 5;
                    allPossibleCombinations[1, 0] = 6;
                    allPossibleCombinations[1, 1] = 4;
                    allPossibleCombinations[2, 0] = 4;
                    allPossibleCombinations[2, 1] = 6;
                    
                }

                else if (rows == 2 && num == 11)
                {
                    allPossibleCombinations[0, 0] = 6;
                    allPossibleCombinations[0, 1] = 5;
                    allPossibleCombinations[1, 0] = 5;
                    allPossibleCombinations[1, 1] = 6;
                }

                else if (rows == 1 && num == 12)
                {
                    allPossibleCombinations[0, 0] = 6;
                    allPossibleCombinations[0, 1] = 6;
                }

                break;

            }

            for (int i = 0; i < allPossibleCombinations.GetLength(0); i++)
            {
                for (int j = 0; j < allPossibleCombinations.GetLength(1); j++)
                {
                    Console.Write("|" + allPossibleCombinations[i,j] + "|");
                    


                }
                Console.Write("\n------");

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


    }

    class Dice
    {

       

    }




}


//int[] aArray = { 1, 2,3,4,5,6};

//int[] bArray = { 1, 2, 3,4,5,6};

////int[] cArray = { 1, 2, 3, 4, 5, 6 };



//int[,] newArray = new int[6, 6];


//for (int i = 0; i < aArray.Length; i++)
//{
//    for (int j = 0; j < bArray.Length; j++)
//    {

//        newArray[i, j] = aArray[i] + bArray[j];
//        Console.Write(newArray[i, j] + " ");

//    }
//    Console.WriteLine();
//}



