using System;

namespace Program
{

    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello, what would you like to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Please choose an option: ");
            float option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Division();
                    break;
                case 4:
                    Multiplication();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Unnavailable operation");
                    break;
            }
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Sum: {n1 + n2}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Subtraction: {n1 - n2}");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Division: {n1 / n2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication: {n1 * n2}");
            Console.ReadKey();
            Menu();
        }
    }

}
