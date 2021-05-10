using System;

namespace Instructions
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static bool IsDivisorOf(int x, int n)
        {
            Console.WriteLine($"EValuating {IsDivisorOf(x,n)}");

            return x % n == 0;
        }

        private static void ElseIf()
        {
            int x = 10;
            if (IsDivisorOf(x, 2))
            {
                Console.WriteLine($"{x} se imparte exact la 2");
            }
            else if (IsDivisorOf(x, 3))
            {
                Console.WriteLine($"{x} se imparte exact la 3");
            }
            else if (IsDivisorOf(x, 4))
            {
                Console.WriteLine($"{x} se imparte exact la 4");
            }

        }

        private static void SwithCase()
        {
            int x = 31;
            int lastDigit = x % 10;

            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("Last digit is 0");
                    break;
                case 1:
                    Console.WriteLine("Last digit is 1");
                    break;
                case 2:
                    Console.WriteLine("Last digit is 2");
                    break;
                case 3:
                    Console.WriteLine("Last digit is 3");
                    break;
                default:
                    Console.WriteLine("Last digit is any another digit!");
                    break;
            }

        }

        private static string GetMessageForLastDigit(int lastDigit)
        {
            switch (lastDigit)
            {
                case 0:
                case 1:
                    return "Last digit is 0 or 1";
                case 2:
                    return"Last digit is 2";
                case 3:
                    return "Last digit is 3";
                default:
                    return "Last digit is any another digit!";

            }

        }


        private static void HandleKnownType(object obj)
        {
            switch (obj)
            {
                case null:
                    Console.WriteLine("obj is null");
                    break;
                case int objAsInt:
                    Console.WriteLine("Obj is a number");
                    break;
                case string objAsStr:
                    Console.WriteLine("Obj is a string");
                    break;
                default:
                    Console.WriteLine("Obj is something else");
                    break;
            }
        }
    }
}
