using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating constant variables, these we can change if we want to have more numbers in the Lotto.
            const int LOTTO_NUMBERS = 8;
            const int MAX_NUMBER = 37;
            const int MIN_NUMBER = 1;
            // Creating new random
            Random random = new Random();
            // Creating int array that has LOTTO_NUMBERS amount of indexes.
            int[] lottoNumbers = new int[LOTTO_NUMBERS];
            // Creating loop to fill out the array.
            for (int i = 0; i < LOTTO_NUMBERS; i++)
            {
                // Creating a temporary nubmer, with our MIN_NUMBER and MAX_NUMBER
                int tempLottoNumber = random.Next(MIN_NUMBER, MAX_NUMBER);
                // If the number already is in our array this part of the code will activate
                if (lottoNumbers.Contains(tempLottoNumber))
                {
                    // Creating a while loop that only stops when then number is different from the numbers we already have in our array
                    while (lottoNumbers.Contains(tempLottoNumber))
                    {
                        tempLottoNumber = random.Next(MIN_NUMBER, MAX_NUMBER);
                    }
                    // Adding the new number to our array
                    lottoNumbers[i] = tempLottoNumber;
                }
                // Else just put the number in our array
                else
                {
                    lottoNumbers[i] = tempLottoNumber;
                }
            }
            // Sorting our array
            Array.Sort(lottoNumbers);
            // Appending our array with one more number
            lottoNumbers.Append(random.Next(MIN_NUMBER, MAX_NUMBER));
            // foreach loop to print all our numbers
            foreach (int i in lottoNumbers)
            {
                // Testing if the current number != the last index of our array
                if(i != lottoNumbers[lottoNumbers.GetUpperBound(0)])
                {
                    //Writing the number if it isnt the last index
                    Console.Write(i);
                    Console.Write("   ");
                    // Sleeping for 2 seconds before continuing
                    System.Threading.Thread.Sleep(2000);
                }
                // This prints the last index of our array.
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nThis is this weeks lotto numbers! Go to your local vendor for payouts");
                }
            }
            Console.ReadLine();
        }
    }
}
