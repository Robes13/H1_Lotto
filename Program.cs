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
            const int LOTTO_NUMBERS = 8;
            const int MAX_NUMBER = 37;
            const int MIN_NUMBER = 1;
            Random random = new Random();
            int[] lottoNumbers = new int[LOTTO_NUMBERS];
            for (int i = 0; i < LOTTO_NUMBERS; i++)
            {
                int tempLottoNumber = random.Next(MIN_NUMBER, MAX_NUMBER);
                if (lottoNumbers.Contains(tempLottoNumber))
                {
                    while (lottoNumbers.Contains(tempLottoNumber))
                    {
                        tempLottoNumber = random.Next(MIN_NUMBER, MAX_NUMBER);
                    }
                    lottoNumbers[i] = tempLottoNumber;
                }
                else
                {
                    lottoNumbers[i] = tempLottoNumber;
                }
            }
            Array.Sort(lottoNumbers);
            lottoNumbers.Append(random.Next(MIN_NUMBER, MAX_NUMBER));
            foreach (int i in lottoNumbers)
            {
                if(i != lottoNumbers[lottoNumbers.GetUpperBound(0)])
                {
                    Console.Write(i);
                    Console.Write("   ");
                    System.Threading.Thread.Sleep(2000);
                }
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
