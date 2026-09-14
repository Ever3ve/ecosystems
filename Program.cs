namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            double result;

            while (keepRunning)
            {
                Console.Clear();
                ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "7")
                {
                    Console.WriteLine("Exiting the application. Bye-bye xx!");
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6")
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    continue;
                }

                EnterNumbers(out double num1, out double num2);

                switch (choice)
                {
                    case "1":
                        result = Addition.Add(num1, num2);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "2":
                        //TODO
                        break;

                    case "3":
                        result = Multiplication.Multiply(num1, num2);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "4":
                        // TODO
                        break;

                    case "5":
                        result = Power.Raise(num1, num2);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "6":
                        result = Remainder.Calculate(num1, num2);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case "7":
                        keepRunning = false;
                        Console.WriteLine("Exiting the application. Bye-bye xx!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (keepRunning)
                {
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Welcome!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Please choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Power");
            Console.WriteLine("6. Remainder");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice (1-7): ");
        }

        private static void EnterNumbers(out double num1, out double num2)
        {
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
