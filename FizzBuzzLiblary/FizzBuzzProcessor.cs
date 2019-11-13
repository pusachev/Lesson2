using System;

namespace FizzBuzzLiblary
{
    public class FizzBuzzProcessor
    {
        private readonly int Start;
        private readonly int End;
        private readonly int FizzNum;
        private readonly int BuzzNum;
        private readonly string FizzAlias;
        private readonly string BuzzAlias;

        public FizzBuzzProcessor(
            int start,
            int end,
            int fizzNum = 3,
            int buzzNum = 5,
            string fizzAlias = "Fizz",
            string buzzAlias = "Buzz"
        )
        {
            Start       = start;
            End         = end;
            FizzNum     = fizzNum;
            BuzzNum     = buzzNum;
            FizzAlias   = fizzAlias;
            BuzzAlias   = buzzAlias;

        }

        public void Process()
        {
            int i = Start;

            for (; i < End; i++)
            { 
                if (i % FizzNum == 0)
                {
                    Console.Write(FizzAlias);
                }

                if (i % BuzzNum == 0)
                {
                    Console.Write(BuzzAlias);
                }

                if (i % FizzNum != 0 && i % BuzzNum != 0)
                {
                    Console.Write(i.ToString());

                }

                Console.WriteLine();
            }
        }

        public static bool isPrime(int num)
        {
            bool result = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
