using System;
using FizzBuzzLiblary;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, fizzNum, buzzNum;
            string fizzAlias, buzzAlias, userFizz, userBuzz;

            bool exit = false;

            do
            {
                fizzNum = 3;
                buzzNum = 5;
                fizzAlias = "Fizz";
                buzzAlias = "Buzz";

                Console.WriteLine("Please enter start number: ");

                if (!int.TryParse(Console.ReadLine(), out start))
                {
                    Console.WriteLine("Please enter valid start number");
                    continue;

                }

                Console.WriteLine("Please enter end number: ");

                if (!int.TryParse(Console.ReadLine(), out end))
                {
                    Console.WriteLine("Please enter valid end number");
                    continue;
                }

                Console.WriteLine("Please enter fizz number[3]: ");

                string initFizz = Console.ReadLine();

                if (initFizz != "")
                {
                    if (!int.TryParse(initFizz, out fizzNum))
                    {

                        Console.WriteLine("Please enter valid fizz number");
                        continue;
                    }

                    if (!FizzBuzzProcessor.isPrime(fizzNum))
                    {
                        Console.WriteLine("Please enter only prime num");
                        continue;
                    }
                }

                Console.WriteLine("Please enter buzz number[5]: ");

                string initBuzz = Console.ReadLine();

                if (initBuzz != "")
                {
                    if (!int.TryParse(initBuzz, out buzzNum))
                    {

                        Console.WriteLine("Please enter valid buzz number");
                        continue;
                    }

                    if (!FizzBuzzProcessor.isPrime(buzzNum))
                    {
                        Console.WriteLine("Please enter only prime num");
                        continue;
                    }
                }

                Console.WriteLine("Please enter fizz alias[Fizz]: ");

                userFizz = Console.ReadLine();

                if (userFizz != "")
                {
                    fizzAlias = userFizz;
                }

                Console.WriteLine("Please enter buzz alias[Buzz]: ");

                userBuzz = Console.ReadLine();

                if (userBuzz != "")
                {
                    buzzAlias = userBuzz;
                }

                Console.WriteLine("Please enter to start");

                FizzBuzzProcessor processor = new FizzBuzzProcessor(start, end, fizzNum, buzzNum, fizzAlias, buzzAlias);

                processor.Process();

                Console.WriteLine("Enter E to key to exit or Enter to continue");

                exit = Console.ReadKey().Key == ConsoleKey.E;

            } while (!exit);
            
        }
    }
}
