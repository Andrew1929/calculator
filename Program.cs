using System;

namespace Сalculator
{   class Calculator
    {
        public void Сalculations()
        {
            Console.WriteLine("Select language (ua/eng) : ");
            string language = Console.ReadLine();
            if (language == "ua")
            {
                Console.Write("Введiть першу цифру : ");
                int first_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введiть другу цифру : ");
                int second_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Виберiть дiю (+ - / *) : ");
                string action = Console.ReadLine();
                Console.WriteLine("------------------");
                switch (action)
                {
                    case "+":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number + second_number}");
                        break;
                    case "-":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number - second_number}");
                        break;
                    case "/":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number / second_number}");
                        break;
                    case "*":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number * second_number}");
                        break;
                    default:
                        Console.WriteLine("Введеної операцiї немає в списку!!!");
                        break;
                }
            }
            else if (language == "eng")
            {
                Console.Write("Enter the first number : ");
                int first_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number : ");
                int second_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose an action (+ - / *) : ");
                string action = Console.ReadLine();
                Console.WriteLine("------------------");
                switch (action)
                {
                    case "+":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number + second_number}");
                        break;
                    case "-":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number - second_number}");
                        break;
                    case "/":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number / second_number}");
                        break;
                    case "*":
                        Console.WriteLine($"{first_number} {action} {second_number} = {first_number * second_number}");
                        break;
                    default:
                        Console.WriteLine("The entered operation is not in the list!!!");
                        break;
                }
            }
            else Console.WriteLine("The entered language is not in the list ");    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Сalculations();
            for(int i = 0; i < 1;)
            {
                Console.Write("Would you like to use the calculator again? (Y/N) : ");
                string x = Console.ReadLine();
                if(x == "Y" || x == "y")
                {
                    calculator.Сalculations();
                }
                else
                {
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
