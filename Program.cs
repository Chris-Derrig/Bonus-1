using System;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            bool tryAgain = true;

            while (repeat)
            {
                while (repeat)
                {
                    Console.WriteLine("Hi! Welcome to your grade converter! \n\nPlease enter any numeric grade and I will convert it into the correspondig letter grade.\n");
                    string grade;
                    grade = Console.ReadLine();
                    decimal num = 0.0m;
                    string[] letter = { "A", "B", "C", "D", "F" };
                    string[] exemp = { "+", "-" };

                    while (repeat)
                    {
                        if (!decimal.TryParse(grade, out num))
                        {
                            Console.WriteLine("Please enter digits\n");
                            grade = Console.ReadLine();
                        }
                        else
                        {
                            repeat = false;
                        }
                    }
                    if (num <= 59)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[4]);
                    }
                    else if (num <= 63 && num >= 60)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[3] + exemp[1]);
                    }
                    else if (num <= 66 && num >= 64)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[3]);
                    }
                    else if (num <= 69 && num >= 67)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[3] + exemp[0]);
                    }
                    else if (num <= 73 && num >= 70)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[2] + exemp[1]);
                    }
                    else if (num <= 76 && num >= 74)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[2]);
                    }
                    else if (num <= 79 && num >= 77)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[2] + exemp[0]);
                    }
                    else if (num <= 83 && num >= 80)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[1] + exemp[1]);
                    }
                    else if (num <= 86 && num >= 84)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[1]);
                    }
                    else if (num <= 89 && num >= 87)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[1] + exemp[0]);
                    }
                    else if (num <= 93 && num >= 90)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[0] + exemp[1]);
                    }
                    else if (num <= 96 && num >= 94)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[0]);
                    }
                    else if (num >= 97)
                    {
                        Console.WriteLine("\nThe corresponding Letter grade is a " + letter[0] + exemp[0]);
                    }

                    Console.WriteLine("\n\nWould you like to run the program again. ('Y' or 'N')\n");
                    string doAgain = Console.ReadLine();
                    while (tryAgain)
                    {
                        if (doAgain == "n" || doAgain == "N")
                        {
                            Console.WriteLine("\nThanks for the chat.  Have a great day!");
                            return;
                        }
                        else if (doAgain == "y" || doAgain == "Y")
                        {
                            tryAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 'Y' or 'N'");
                            doAgain = Console.ReadLine();
                            tryAgain = true;
                        }
                    }
                    tryAgain = true;

                    if (doAgain == "y" || doAgain == "Y")
                    {
                    }
                    repeat = true;
                }
                repeat = true;
            }
        }
    }
}
