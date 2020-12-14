using System;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = MenuOptions();
            
            switch (option)
            {
                case 1:
                    int bound = ChooseBoundNumber();                    
                    int result = SumOfMultiple(bound);
                    ShowResult(bound, result);
                    break;

                case 2:
                    SequenceAnalysis();
                    break;
            }
        }

        private static void ShowResult(int bound, int result)
        {
            Console.WriteLine($"The sum of all natural numbers that are a multiple of 3 or 5 below {bound} is {result}");
        }

        /// <summary>Show a menu with options</summary>
        private static int MenuOptions()
        {
            string input = string.Empty;
            bool val;
            int option;

            Console.WriteLine("Welcome!!\nWhich of the problems below would you like to solve? PRESS:\n");
            Console.WriteLine("(1) - to find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input");
            Console.WriteLine("(2) - Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically");
            Console.Write("Option: ");
            input = Console.ReadLine();

            //Convert to integer
            val = int.TryParse(input, out option);

            //Leave program if parse was not succedeed
            if (!val)
            {
                return -1;
            }

            return option;
        }

        /// <summary>Reads a number that will be used to find its multiples</summary>
        private static int ChooseBoundNumber()
        {
            bool val;
            string input = string.Empty;
            int boundVal;

            Console.WriteLine("Enter a value: ");
            input = Console.ReadLine();

            val = int.TryParse(input, out boundVal);
            if (!val)
            {
                return -1;
            }
            else
            {
                return boundVal;
            }
        }


        private static int SumOfMultiple(int bound)
        {
            return new SumOfMultiple().UpTo(bound);
        }

        private static void SequenceAnalysis()
        {
            throw new NotImplementedException();
        }
    }
}
