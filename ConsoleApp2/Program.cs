using System;

namespace ConsoleApp2
{
    class Program
    {

        public static void summ(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        }
        public static void sub(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        }
        public static void mult(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        }
        public static void div(double num1, double num2)
        {
            if (num2 != 0)
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            else
                Console.WriteLine($"Zero Division Error!");
        }
        public static void power(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} ** {num2} = " + (Math.Pow(num1, num2)));
        }
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type your first number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type your second number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\te - Enter two numbers");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tp - Power");
            Console.WriteLine("\t0 - Exit");
            Console.Write("Your option? ");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "e":
                        Console.WriteLine("Type your first number, and then press Enter");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Type your second number, and then press Enter");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "a":
                        summ(num1, num2);
                        break;
                    case "s":
                        sub(num1, num2);
                        break;
                    case "m":
                        mult(num1, num2);
                        break;
                    case "d":
                        div(num1, num2);
                        break;
                    case "p":
                        power(num1, num2);
                        break;
                    case "0":
                        return;

                }
            }
        }
    }
}
